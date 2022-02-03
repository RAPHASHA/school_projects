using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class DropOffAreaModel
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }

        [Display(Name = "DropOffArea")]
        public string DropOffArea { get; set; }

        [Display(Name = "TimeArrival")]
        public string TimeArrival { get; set; }


        [Display(Name = "TimeDepture")]
        public string TimeDepature { get; set; }
    }
}
