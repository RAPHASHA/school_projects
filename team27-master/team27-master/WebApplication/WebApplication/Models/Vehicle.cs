using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Vehicle
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }


        [Required]
        [Display(Name = "StateDescription")]
        public string StateDescription { get; set; }

        [Required]
        [Display(Name = "Registration")]
        public string Registration { get; set; }

    }
}
