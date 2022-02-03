using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class Authentication :Controller, IDisposable
    {

        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Admin> Admins { get; set; }
        const string BASE_URL = "http://localhost/taxiclubapi/public";
        public Authentication(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }


        public IActionResult NotMatch()
        {
            return View();
        }

        public IActionResult InvalidEmail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NotMatch([Bind("Email, Password")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(admin), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/Adminlogin");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);
                var result = await response.Content.ReadAsStringAsync();


                if (!admin.Email.Equals("Xolani@gmail.com"))
                {
                    return RedirectToAction(nameof(InvalidEmail));
                }

         

                if (admin.Email.Equals("Xolani@gmail.com"))
                {
                    if (!admin.Password.Equals("Admin02"))
                    {
                        return RedirectToAction(nameof(NotMatch));
                    }
                    if (admin.Password.Equals("Admin02"))
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }   
            }
            return View(admin);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InvalidEmail([Bind("Email, Password")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(admin), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/Adminlogin");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);
                var result = await response.Content.ReadAsStringAsync();
                if (!admin.Email.Equals("Xolani@gmail.com"))
                {
                   
                }
              

                if (admin.Email.Equals("Xolani@gmail.com"))
                {
                    if (!admin.Password.Equals("Admin02"))
                    {
                        return RedirectToAction(nameof(NotMatch));
                    }
                    if (admin.Password.Equals("Admin02"))
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }
            }
            return View(admin);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email, Password")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(admin), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/Adminlogin");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);
                var result = await response.Content.ReadAsStringAsync();


                if (!admin.Email.Equals("Xolani@gmail.com"))
                {
                     return RedirectToAction(nameof(InvalidEmail));

                }

                if (admin.Email.Equals("Xolani@gmail.com"))
                {
                    if (!admin.Password.Equals("Admin02"))
                    {
                          return RedirectToAction(nameof(NotMatch));
                    }       
                }

                if ((admin.Email.Equals("Xolani@gmail.com") && (admin.Password.Equals("Admin02"))))
                {

                    return RedirectToAction("Index", "Home");
                }


                


            }
            return View(admin);
        }
    }
}
