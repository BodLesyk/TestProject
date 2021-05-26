using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Project.Models
{
    public class Appointment
    {
        [Required(ErrorMessage ="Поле имя должно быть заполнено!")]
        [StringLength(40)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        
        public bool CaseClosed { get; set; }
    }
}
