using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using XuanHoang.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System;
 
namespace XuanHoang.Controllers
{
    public class CustomersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Customers> reservationList = new List<Customers>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CustomersApi/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Customers>>(apiResponse);
                }
            }
            return View(reservationList);
        }
        public ViewResult GetCustomers() => View();
 
        [HttpPost]
        public async Task<IActionResult> GetCustomers(int id)
        {
            Customers reservation = new Customers();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CustomersApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Customers>(apiResponse);
                }
            }
            return View(reservation);
        }

        public ViewResult AddCustomers() => View();

        [HttpPost]
        public async Task<IActionResult> AddCustomers(Customers customers)
        {
            Customers receivedTodoItem = new Customers();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customers), Encoding.UTF8, "application/json");
 
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/CustomersApi/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedTodoItem = JsonConvert.DeserializeObject<Customers>(apiResponse);
                }
            }
            return View(receivedTodoItem);
        }


        public async Task<IActionResult> UpdateCustomers(int id)
        {
            Customers reservation = new Customers();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CustomersApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Customers>(apiResponse);
                }
            }
            return View(reservation);
        }

 
        [HttpPost]
        public async Task<IActionResult> UpdateCustomers(Customers customers)
        {
            Customers receivedReservation = new Customers();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customers), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://localhost:5001/api/CustomersApi/"+ customers.Id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedReservation = JsonConvert.DeserializeObject<Customers>(apiResponse);
                }
            }
            return Redirect("/customers/index");
        }


        // public async Task<IActionResult> UpdateCategoryPatch(int id)
        // {
        //     Category reservation = new Category();
        //     using (var httpClient = new HttpClient())
        //     {
        //         using (var response = await httpClient.GetAsync("https://localhost:5001/api/CategoryApi/" + id))
        //         {
        //             string apiResponse = await response.Content.ReadAsStringAsync();
        //             reservation = JsonConvert.DeserializeObject<Category>(apiResponse);
        //         }
        //     }
        //     return View(reservation);
        // }
 
        // [HttpPost]
        // public async Task<IActionResult> UpdateCategoryPatch(int id, Category reservation)
        // {
        //     using (var httpClient = new HttpClient())
        //     {
        //         var request = new HttpRequestMessage
        //         {
        //             RequestUri = new Uri("https://localhost:5001/api/CategoryApi/" + id),
        //             Method = new HttpMethod("Patch"),
        //             Content = new StringContent("[{ \"op\": \"replace\", \"path\": \"Name\", \"value\": \"" + reservation.Name + "\"},{ \"op\": \"replace\", \"path\": \"IsComplete\", \"value\": \"" + reservation.Status + "\"}]", Encoding.UTF8, "application/json")
        //         };
 
        //         var response = await httpClient.SendAsync(request);
        //     }
        //     return RedirectToAction("Index");
        // }

        public async Task<IActionResult> DeleteCustomers(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/CustomersApi/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
 
            return RedirectToAction("Index");
        }
    }
}