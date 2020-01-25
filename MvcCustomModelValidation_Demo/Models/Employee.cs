using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcCustomModelValidation_Demo.CustomValidation;

namespace MvcCustomModelValidation_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter office")]
        public string Office { get; set; }

        [Required(ErrorMessage = "Please enter hire date")]
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [CustomHireDate(ErrorMessage = "Hire Date must be less than or equal to Today's Date")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Please enter salary")]
        public int Salary { get; set; }
    }
}