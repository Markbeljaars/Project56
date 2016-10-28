using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Models
{
    public class Account
    {
        [Key]
        public string username { get; set; }

        [Required(ErrorMessage = "Your password is required")]
        public string password { get; set; }
        [Compare("Password", EmailMessage = "Please confirm your password")]
        public string confirmPassword { get; set; }
        [Required(ErrorMessage = "Your first name is required and must be unique!")]
        public string name { get; set; }
        [Required(ErrorMessage = "Your surname is required")]
        public string surname { get; set; }
        [Required(ErrorMessage = "Your address name is required")]
        public string address { get; set; }
        [Required(ErrorMessage = "Your email is required")]
        public string email { get; set; }
        public string type { get; set; }
    }
}