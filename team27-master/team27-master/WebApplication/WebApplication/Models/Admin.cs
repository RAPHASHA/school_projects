using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Admin
    {
        [Display(Name = "id")]
        [Key]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Cell")]
        public string Cell { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "message")]
        public string message { get; set; }

    }
}
