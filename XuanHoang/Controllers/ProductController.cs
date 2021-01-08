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
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Product> reservationList = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/ProductApi/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(reservationList);
        }
        public ViewResult GetProduct() => View();
 
        [HttpPost]
        public async Task<IActionResult> GetProduct(int id)
        {
            Product reservation = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/ProductApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(reservation);
        }

        public ViewResult AddProduct() => View();

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            Product receivedTodoItem = new Product();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
 
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/ProductApi/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedTodoItem = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(receivedTodoItem);
        }


        public async Task<IActionResult> UpdateProduct(int id)
        {
            Product reservation = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/ProductApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(reservation);
        }

 
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            Product receivedReservation = new Product();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://localhost:5001/api/ProductApi/"+ product.Id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedReservation = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return Redirect("/product/index");
        }


        public async Task<IActionResult> UpdateProductPatch(int id)
        {
            Product reservation = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/ProductApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(reservation);
        }
 
        [HttpPost]
        public async Task<IActionResult> UpdateProductPatch(int id, Product reservation)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://localhost:5001/api/ProductApi/" + id),
                    Method = new HttpMethod("Patch"),
                    Content = new StringContent("[{ \"op\": \"replace\", \"path\": \"Name\", \"value\": \"" + reservation.Name + "\"},{ \"op\": \"replace\", \"path\": \"IsComplete\", \"value\": \"" + reservation.Status + "\"}]", Encoding.UTF8, "application/json")
                };
 
                var response = await httpClient.SendAsync(request);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/ProductApi/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
 
            return RedirectToAction("Index");
        }
    }
}