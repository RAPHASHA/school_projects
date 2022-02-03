using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Driver
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }

     
        [Display(Name = "Name")]
        public string Name { get; set; }

     
        [Display(Name = "Surname")]
        public string Surname { get; set; }

    
        [Display(Name = "Gender")]
        public string Gender { get; set; }

       
        [Display(Name = "Email")]

        public string Email { get; set; }

        [Display(Name = "Cell")]
        public string Cell { get; set; }

        [Display(Name = "DriverType")]
        public string DriverType { get; set; }

        [Display(Name = "Account State")]
        public string AccountActive { get; set; }

        [Display(Name = "Has Driver")]
        public int HasVehicle { get; set; }

   
        [Display(Name = "Has Driver")]
        public string VehicleName { get; set; }


     
        [Display(Name = "Has Driver")]
        public string VehicleDescription { get; set; }


        [Display(Name = "Has Driver")]
        public string VehicleType { get; set; }


     
        [Display(Name = "Has Driver")]
        public int VehicleCapacity { get; set; }


        [Display(Name = "Has Driver")]
        public int VehicleID { get; set; }

     
        [Display(Name = "Has Driver")]
        public string VehicleStateDescription { get; set; }


        [Display(Name = "Has Driver")]
        public string VehicleDateAdded { get; set; }


     
        [Display(Name = "Registration")]
        public string Registration
        {
            get; set;
        }


    } 
}

