using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using XuanHoang.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System;
using Microsoft.AspNetCore.Http;

namespace XuanHoang.Controllers
{
    public class UserController : Controller
    {
        private readonly TodoContext _context;

        public UserController(TodoContext context)
        {
            _context = context;
        }
        public IActionResult  Login(string returnUrl = "")
        {
            if(HttpContext.Session.GetString("id") != null){
                return Redirect("/homeadmin/index");
            }
            var model = new LoginRequest { ReturnUrl = returnUrl }; 
            return View(model); 
        }

        [HttpPost]
         [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Login(LoginRequest request)
        {
            if(request.RememberMe == true)
            {
                HttpContext.Session.SetString("email" , request.Email);
                HttpContext.Session.SetString("pass" , request.Pass);
            }
            
             using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:5001/api/UserApi/",content))
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.OK){
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        Customers customer= JsonConvert.DeserializeObject<Customers>(apiResponse);
                         HttpContext.Session.SetString("id" , customer.Id.ToString());
                    }else{
                    ModelState.AddModelError("","Invalid login attempt"); 
                    }
                    return Login();
                }
            }
        }
    }
}