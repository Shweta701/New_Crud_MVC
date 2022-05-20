using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace New_Crud_MVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
    }
}