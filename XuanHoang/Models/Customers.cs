using System;
using System.ComponentModel.DataAnnotations;
namespace XuanHoang.Models
{
    public class Customers
    {
        public long Id{get;set;}
        public string Name{get;set;}
        public string Email{get;set;}
        public string Address{get;set;}
        public string Phone{get;set;}
        public string Pass{get;set;}
    }

    public class CustomersDTO
    {
        public long Id{get;set;}
        public string Name{get;set;}
        public string Email{get;set;}
        public string Address{get;set;}
        public string Phone{get;set;}
        public string Pass{get;set;}
    }
}