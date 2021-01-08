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
    public class HomeAdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}