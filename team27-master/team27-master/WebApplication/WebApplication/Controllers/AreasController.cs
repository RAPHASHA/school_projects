using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class AreasController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
    }
}
