using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class MultipleData
    {

       public IEnumerable<PickUpAreaModel> PickUpAreas { get; set; }
       public IEnumerable<DropOffAreaModel> DropOffAreas { get; set; }

        [Display(Name = "ArrivalTime")]
        public string ArrivalTime { get; set; }

        [Display(Name = "DropOfArea")]
        public string DepartureTime { get; set; }

        [Display(Name = "PickUpArea")]
        public string PickUpArea { get; set; }

        [Display(Name = "DropOfArea")]
        public string DropOffArea { get; set; }

        [Display(Name = "DriverName")]
        public string DriverName { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "VehicleName")]
        public string VehicleName{ get; set; }

        [Display(Name = "Registration")]
        public string Registration { get; set; }

        public IEnumerable<Driver> Drivers { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }

        public Request Request { get; set; }

        public Driver Driver { get; set; }

        public Trip Trip { get; set; }





    }
}
