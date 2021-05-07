using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test_Project.Models;

namespace Test_Project.Controllers
{
    public class HomeController : Controller
    {
        public List<Employee> employees;
        public  void Employees()
        {
            employees = new List<Employee> {
             new Employee() { FirstName = "Oleg", LastName = "Drobina", position = Position.Support_L3},
            new Employee() { FirstName = "Bogdan", LastName = "Lesyk", position = Position.Support_L3 },
            new Employee() { FirstName = "Bogdan", LastName = "Spasibov", position = Position.Team_Lead }
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
        
}
}
