using System;
using System.ComponentModel.DataAnnotations;

namespace XuanHoang.Models
{
    public class RegisterRequest
    {
        public string Name{get;set;}
        public string Email{get;set;}
        public string Address{get;set;}
        public string Phone{get;set;}
        public string Pass{get;set;}
        public string ConfirmPass{get;set;}
    }
}