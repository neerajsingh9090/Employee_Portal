using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project_Emp.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Required(ErrorMessage="Name is required....!")]
        public string name { get; set; }

        [Required(ErrorMessage = "Email is required....!")]
        public string email { get; set; }


        [Required(ErrorMessage = "Designation is required....!")]
        public string designation { get; set; }

        [Required(ErrorMessage = "Salary is required....!")]
        public double salary { get; set; }

        [Required(ErrorMessage = "City is required....!")]
        public string city { get; set; }
    }
}