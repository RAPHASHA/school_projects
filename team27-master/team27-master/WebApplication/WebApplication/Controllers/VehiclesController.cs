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
    public class VehiclesController : Controller, IDisposable
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Vehicle> Vehicles { get; set; }
        const string BASE_URL = "http://localhost/taxiclubapi/public";
        public VehiclesController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allVehicles");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicles = await JsonSerializer.DeserializeAsync<IEnumerable<Vehicle>>(responseStream);
            }
            else
            {
                Vehicles = Array.Empty<Vehicle>();
            }
            return View(Vehicles);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }



        public IActionResult Main()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Surname, Gender, Email, Cell, VehicleType")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createVehicle");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Vehicle);
        }

        public async Task<IActionResult> Profile(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }

            if (Vehicle == null)
                return NotFound();

            return View(Vehicle);
        }

        public async Task<IActionResult> Profille(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicleprofile/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }

            if (Vehicle == null)
                return NotFound();

            return View(Vehicle);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Delete;
            message.RequestUri = new Uri($"{BASE_URL}/unasigntriptoVehicle/{id}");

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
              message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
              message.Headers.Add("Accept", "application/json");
              var client = _clientFactory.CreateClient();
              var response = await client.SendAsync(message);

              Vehicle Vehicle = null;

              if (response.IsSuccessStatusCode)
              {
                  using var responseStream = await response.Content.ReadAsStreamAsync();
                  Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
              }

              if (Vehicle == null)
                  return NotFound();

              return View(Vehicle);
          }*/

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Test()
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
                Vehicles = await JsonSerializer.DeserializeAsync<IEnumerable<Vehicle>>(responseStream);
            }
            else
            {
                Vehicles = Array.Empty<Vehicle>();
            }
            return View(Vehicles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Name , Description, Type, Capacity, StateDescription, Registration")] Vehicle driver)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(driver), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createvehicle");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(driver);
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allworkingvehicles");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicles = await JsonSerializer.DeserializeAsync<IEnumerable<Vehicle>>(responseStream);
            }
            else
            {
                Vehicles = Array.Empty<Vehicle>();
            }
            return View(Vehicles);
        }

        public async Task<IActionResult> UnassignedList()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allVehiclessimple");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicles = await JsonSerializer.DeserializeAsync<IEnumerable<Vehicle>>(responseStream);
            }
            else
            {
                Vehicles = Array.Empty<Vehicle>();
            }
            return View(Vehicles);
        }

        public async Task<IActionResult> SimpleList()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allVehiclessimple");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicles = await JsonSerializer.DeserializeAsync<IEnumerable<Vehicle>>(responseStream);
            }
            else
            {
                Vehicles = Array.Empty<Vehicle>();
            }
            return View(Vehicles);
        }


        [HttpGet]
        public async Task<IActionResult> RemoveTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpGet]
        public async Task<IActionResult> TripNotFound(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveTrip(int id, [Bind("")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/unasigntriptoVehicle/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Vehicle);
        }





        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name, Surname,Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateVehicle/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Vehicle);
        }


        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicletrip/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id, [Bind("")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/unasigntriptoVehicle/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Vehicle);
        }

        [HttpGet]
        public async Task<IActionResult> EditTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicletrip/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> EditTrip(int id, [Bind("PickUpArea, DropOffArea")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateassignVehicletotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Vehicle);
        }

        [HttpGet]
        public async Task<IActionResult> AddTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> AddTrip(int id, [Bind("PickUpArea, DropOffArea")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateassignVehicletotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Vehicle);
        }

        public async Task<IActionResult> AssignToTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicle/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }
            return View(Vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> AssignToTrip(int id, [Bind("Name, Surname,Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Vehicle Vehicle)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Vehicle), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateVehicle/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(Vehicle);
        }


        public async Task<IActionResult> Trip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/Vehicletrip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Vehicle Vehicle = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(responseStream);
            }

            if (Vehicle == null)
                return NotFound();

            return View(Vehicle);
        }
    }
}

