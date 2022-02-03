using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class RequestsController : Controller, IDisposable
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Request> Requests { get; set; }
        public IEnumerable<Driver>Drivers { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }

        const string BASE_URL = "http://localhost/taxiclubapi/public";
        public RequestsController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allRequests");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Requests = await JsonSerializer.DeserializeAsync<IEnumerable<Request>>(responseStream);
            }
            else
            {
                Requests = Array.Empty<Request>();
            }
            return View(Requests);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Surname, Gender, Email, Cell, RequestType")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createRequest");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Request);
        }

        public async Task<IActionResult> Info(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengerrequest/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }

            if (Request == null)
                return NotFound();

            return View(Request);
        }

        public async Task<IActionResult> Information(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengerrequest/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }

            if (Request == null)
                return NotFound();

            return View(Request);
        }

        public async Task<IActionResult> Accept(int id)
        {
            var myModel = new MultipleData();

            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengerrequest/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);



                message = new HttpRequestMessage();
                message.Method = HttpMethod.Get;
                message.RequestUri = new Uri($"{BASE_URL}/alldrivers");
                message.Headers.Add("Accept", "application/json");

                client = _clientFactory.CreateClient();

                response = await client.SendAsync(message);

                if (response.IsSuccessStatusCode)
                {
                    using var responseStream2 = await response.Content.ReadAsStreamAsync();
                    Drivers = await JsonSerializer.DeserializeAsync<IEnumerable<Driver>>(responseStream2);


                    message = new HttpRequestMessage();
                    message.Method = HttpMethod.Get;
                    message.RequestUri = new Uri($"{BASE_URL}/allworkingvehicles");
                    message.Headers.Add("Accept", "application/json");
                    client = _clientFactory.CreateClient();
                    response = await client.SendAsync(message);
                    if (response.IsSuccessStatusCode)
                    {
                        using var responseStream3 = await response.Content.ReadAsStreamAsync();
                       Vehicles = await JsonSerializer.DeserializeAsync<IEnumerable<Vehicle>>(responseStream3);
                    }
                    else
                    {
                        Vehicles = Array.Empty<Vehicle>();
                    }


                }
                else
                {
                    Drivers = Array.Empty<Driver>();
                }

            }

            if (Request == null)
                return NotFound();
            myModel.Drivers = Drivers.ToList();
            myModel.Vehicles = Vehicles.ToList();
            myModel.Request = Request;
            return View(myModel);
        }

        public async Task<IActionResult> Profille(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Requestprofile/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }

            if (Request == null)
                return NotFound();

            return View(Request);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Delete;
            message.RequestUri = new Uri($"{BASE_URL}/unasigntriptoRequest/{id}");

            HttpClient client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(message);
            var result = await response.Content.ReadAsStringAsync();
            return RedirectToAction(nameof(List));
        }









        /*[HttpGet]
          public async Task<IActionResult> Edit(int id)
          {
              if (id == null)
                  return NotFound();

              var message = new HttpRequestMessage();
              message.Method = HttpMethod.Get;
              message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
              message.Headers.Add("Accept", "application/json");
              var client = _clientFactory.CreateClient();
              var response = await client.SendAsync(message);

              Request Request = null;

              if (response.IsSuccessStatusCode)
              {
                  using var responseStream = await response.Content.ReadAsStreamAsync();
                  Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
              }

              if (Request == null)
                  return NotFound();

              return View(Request);
          }*/

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }


        public IActionResult SuccessAccept()
        {
            return View();
        }






        public async Task<IActionResult> ListTrips()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/alltrips");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Requests = await JsonSerializer.DeserializeAsync<IEnumerable<Request>>(responseStream);
            }
            else
            {
                Requests = Array.Empty<Request>();
            }
            return View(Requests);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Name, Surname, Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Request driver)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(driver), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createRequest");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(driver);
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allrequests");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Requests = await JsonSerializer.DeserializeAsync<IEnumerable<Request>>(responseStream);
            }
            else
            {
                Requests = Array.Empty<Request>();
            }
            return View(Requests);
        }

        public async Task<IActionResult> UnassignedList()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allRequestssimple");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Requests = await JsonSerializer.DeserializeAsync<IEnumerable<Request>>(responseStream);
            }
            else
            {
                Requests = Array.Empty<Request>();
            }
            return View(Requests);
        }

        public async Task<IActionResult> SimpleList()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allRequestssimple");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Requests = await JsonSerializer.DeserializeAsync<IEnumerable<Request>>(responseStream);
            }
            else
            {
                Requests = Array.Empty<Request>();
            }
            return View(Requests);
        }


        [HttpGet]
        public async Task<IActionResult> RemoveTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpGet]
        public async Task<IActionResult> TripNotFound(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveTrip(int id, [Bind("")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/unasigntriptoRequest/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }





        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpGet]
        public async Task<IActionResult> Decline(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengerrequest/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name, Surname,Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateRequest/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> Decline(int id, [Bind("")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/decline/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }


        [HttpPost]
        public async Task<IActionResult> Accept(int id, [Bind("DriverName, VehicleName")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/Accept/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(Request);
        }


        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Requesttrip/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id, [Bind("")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/unasigntriptoRequest/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }

        [HttpGet]
        public async Task<IActionResult> EditTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Requesttrip/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> EditTrip(int id, [Bind("PickUpArea, DropOffArea")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateassignRequesttotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }

        [HttpGet]
        public async Task<IActionResult> AddTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> AddTrip(int id, [Bind("PickUpArea, DropOffArea")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateassignRequesttotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }

        public async Task<IActionResult> AssignToTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Request/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }
            return View(Request);
        }

        [HttpPost]
        public async Task<IActionResult> AssignToTrip(int id, [Bind("Name, Surname,Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Request Request)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Request), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateRequest/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Request);
        }


        public async Task<IActionResult> Trip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Requesttrip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Request Request = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Request = await JsonSerializer.DeserializeAsync<Request>(responseStream);
            }

            if (Request == null)
                return NotFound();

            return View(Request);
        }
    }
}

