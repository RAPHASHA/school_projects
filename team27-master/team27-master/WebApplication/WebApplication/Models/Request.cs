using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Request
    {
        [Display(Name = "id")]
        [Key]
        public int id { get; set; }

        [Display(Name = "PickUpArea")]
        public string PickUpArea { get; set; }

        [Display(Name = "DropOffArea")]
        public string DropOffArea { get; set; }

        [Display(Name = "Session")]
        public string Session { get; set; }

        [Display(Name = "PassengerID")]







        public int PassengerID { get; set; }

        [Display(Name = "PickUpLocation")]
        public string PickUpLocation{ get; set; }

        [Display(Name = "DropOffLocation")]
        public string DropOffLocation { get; set; }

        [Display(Name = "PickUpTime")]
        public String PickUpTime { get; set; }

        [Display(Name = "DropOffTime")]
        public string DropOffTime { get; set; }

        [Display(Name = "SchoolName")]
        public string SchoolName { get; set; }

        [Display(Name = "SchoolAddress")]
        public String SchoolAddress { get; set; }

        [Display(Name = "SchoolCell")]
        public int SchoolCell { get; set; }

        [Display(Name = "GroupType")]
        public string GroupType { get; set; }

        [Display(Name = "NumberPassenger")]
        public int NumberPassenger { get; set; }

        [Display(Name = "TripDate")]
        public String TripDate { get; set; }


        [Display(Name = "PassengerName")]
        public string PassengerName { get; set; }

        [Display(Name = "PassengerSurname")]
        public string PassengerSurname { get; set; }

        [Display(Name = "PassengerEmail")]
        public String PassengerEmail { get; set; }

        [Display(Name = "PassengerCell")]
        public String PassengerCell { get; set; }


        [Display(Name = "DriverName")]
        public String DriverName { get; set; }

        [Display(Name = "VehicleName")]
        public String VehicleName { get; set; }

        [Display(Name = "RequestStatus")]
        public String RequestStatus { get; set; }



        public IEnumerable<Driver> Drivers { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }

    }
}
