using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Project.Models
{

    public enum Position
    {
        Support_L1, 
        Support_L2, 
        Support_L3, 
        Team_Lead
    }
    public class Employee
    {
        public int Id;

        public string FirstName;

        public string LastName;

        public Position position;
    }
}
