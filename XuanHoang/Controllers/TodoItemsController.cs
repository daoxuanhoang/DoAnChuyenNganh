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
    public class TodoItemsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<TodoItem> reservationList = new List<TodoItem>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/TodoItemsApi/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<TodoItem>>(apiResponse);
                }
            }
            return View(reservationList);
        }
        public ViewResult GetTodoItem() => View();
 
        [HttpPost]
        public async Task<IActionResult> GetTodoItem(int id)
        {
            TodoItem reservation = new TodoItem();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/TodoItemsApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }
            return View(reservation);
        }

        public ViewResult AddTodoItem() => View();

        [HttpPost]
        public async Task<IActionResult> AddTodoItem(TodoItem todoItem)
        {
            TodoItem receivedTodoItem = new TodoItem();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(todoItem), Encoding.UTF8, "application/json");
 
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/TodoItemsApi/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedTodoItem = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }
            return View(receivedTodoItem);
        }


        public async Task<IActionResult> UpdateTodoItem(int id)
        {
            TodoItem reservation = new TodoItem();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/TodoItemsApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }
            return View(reservation);
        }

 
        [HttpPost]
        public async Task<IActionResult> UpdateTodoItem(TodoItem todoItem)
        {
            TodoItem receivedReservation = new TodoItem();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(todoItem), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("https://localhost:5001/api/TodoItemsApi/"+ todoItem.Id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedReservation = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }
            return Redirect("/todoitems/index");
        }


        public async Task<IActionResult> UpdateTodoItemPatch(int id)
        {
            TodoItem reservation = new TodoItem();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/TodoItemsApi/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }
            return View(reservation);
        }
 
        [HttpPost]
        public async Task<IActionResult> UpdateTodoItemPatch(int id, TodoItem reservation)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://localhost:5001/api/TodoItemsApi/" + id),
                    Method = new HttpMethod("Patch"),
                    Content = new StringContent("[{ \"op\": \"replace\", \"path\": \"Name\", \"value\": \"" + reservation.Name + "\"},{ \"op\": \"replace\", \"path\": \"IsComplete\", \"value\": \"" + reservation.IsComplete + "\"}]", Encoding.UTF8, "application/json")
                };
 
                var response = await httpClient.SendAsync(request);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTodoItem(int TodoItemId)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/TodoItemsApi/" + TodoItemId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
 
            return RedirectToAction("Index");
        }
    }
}