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
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Category> reservationList = new List<Category>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CategoryApi/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Category>>(apiResponse);
                }
            }
            return View(reservationList);
        }
        public ViewResult GetCategory() => View();
 
        [HttpPost]
        public async Task<IActionResult> GetCategory(int id)
        {
            Category reservation = new Category();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CategoryApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Category>(apiResponse);
                }
            }
            return View(reservation);
        }

        public ViewResult AddCategory() => View();

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            Category receivedTodoItem = new Category();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
 
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/CategoryApi/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedTodoItem = JsonConvert.DeserializeObject<Category>(apiResponse);
                }
            }
            return View(receivedTodoItem);
        }


        public async Task<IActionResult> UpdateCategory(int id)
        {
            Category reservation = new Category();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CategoryApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Category>(apiResponse);
                }
            }
            return View(reservation);
        }

 
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            Category receivedReservation = new Category();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://localhost:5001/api/CategoryApi/"+ category.Id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedReservation = JsonConvert.DeserializeObject<Category>(apiResponse);
                }
            }
            return Redirect("/category/index");
        }


        public async Task<IActionResult> UpdateCategoryPatch(int id)
        {
            Category reservation = new Category();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/CategoryApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Category>(apiResponse);
                }
            }
            return View(reservation);
        }
 
        [HttpPost]
        public async Task<IActionResult> UpdateCategoryPatch(int id, Category reservation)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://localhost:5001/api/CategoryApi/" + id),
                    Method = new HttpMethod("Patch"),
                    Content = new StringContent("[{ \"op\": \"replace\", \"path\": \"Name\", \"value\": \"" + reservation.Name + "\"},{ \"op\": \"replace\", \"path\": \"IsComplete\", \"value\": \"" + reservation.Status + "\"}]", Encoding.UTF8, "application/json")
                };
 
                var response = await httpClient.SendAsync(request);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/CategoryApi/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
 
            return RedirectToAction("Index");
        }
    }
}