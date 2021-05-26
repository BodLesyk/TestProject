using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test_Project.Models;
using Test_Project.Check;
using System.Text.RegularExpressions;

namespace Test_Project.Controllers
{
    public class HomeController : Controller
    {



        public List<Employee> employees;
        public void Employees()
        {
            employees = new List<Employee> {
             new Employee() { Id=1, FirstName = "Oleg", LastName = "Drobina", position = Position.Support_L3},
            new Employee() {Id=2,  FirstName = "Bogdan", LastName = "Lesyk", position = Position.Support_L3 },
            new Employee() {Id=3, FirstName = "Bogdan", LastName = "Spasibov", position = Position.Team_Lead }
        };
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SquareInput()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Square(int a, int b)
        {
            var r = (double)a * b / 2;

            return Content(@$"<h2>Area of triangle with base {a} and height {b} equals {r}.</h2>", "text/html");
        }

        public IActionResult GoPerekur()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Perekur(string password)
        {
            if (password != "Supervisor")
            {
                return View("Frai");
            }
            else
            {
                return View();
            }

        }
        public IActionResult ShowEmployees()
        {
            Employees();
            return View(employees);
        }


        public IActionResult Books()
            
        {
            List<string> books = new List<string> { "book 1", "book 2", "book 3" };

            

            return View(books);
        }

        public IActionResult Films()
        {
            var films = new Films();
            return View(films);
        }

        [HttpGet]
        public ViewResult AppointPerekur()
        {
            return View(new Appointment { Date = DateTime.UtcNow});
        }

        [HttpPost]
        public ViewResult AppointPerekur(Appointment appointment)
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var invalidNums = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            var invalidCharss = new[] { '!', '@', '"', '#', '№', '$', ';', '%', '^', ':', '&', '?', '*', '(', ')', '_', '-', '+', '=','\\','|','/','<','>',',','.','"', '{','}','[',']',';'};
            

            if (appointment.Name.Any(x => invalidNums.Contains(x)))
            {
                ModelState.AddModelError("", "Цифры не доступны при вводе имени!");
            }
            if (appointment.Name.Any(x => invalidCharss.Contains(x)))
            {
                ModelState.AddModelError("", "Символы не доступны при вводе имени!");
            }

            //if (IsNumberCheck.IsNumber(appointment.Name))
            //{
            //    ModelState.AddModelError("Name", "Пожалуйста, введите свое настоящее имя!");
                
            //}
            if (appointment.Date <=yesterday)
            {
                ModelState.AddModelError("", " Ошибка! Выбрать прошедшую дату невозможно!");
            }
            if(appointment.Date.DayOfWeek == DayOfWeek.Saturday || appointment.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                ModelState.AddModelError("", "Вы выбрали выходной день, курите дома!");
            }
            if (!appointment.CaseClosed)
            {
                ModelState.AddModelError("", "Пожалуйста, скажите, что производительность это легко");
            }

            if (ModelState.IsValid)
            {
                return View("Completed", appointment);
            }
            else
            {
                return View();
            }

        }

        

    }
}
