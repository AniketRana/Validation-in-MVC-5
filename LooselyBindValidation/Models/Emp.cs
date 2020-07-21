using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LooselyBindValidation.Models
{
    public class Emp
    {
        [Required(ErrorMessage ="Please Enter the first name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Please Enter the last name")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Please Enter the Valid mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}