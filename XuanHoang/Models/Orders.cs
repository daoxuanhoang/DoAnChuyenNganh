using System;
using System.ComponentModel.DataAnnotations;
namespace XuanHoang.Models
{
    public class Orders
    {
        public long Id{get;set;}
        public int ProductId{get;set;}
        public string ProductName{get;set;}
        public int CustomerID{get;set;}
        public int Price{get;set;}
        public int Quantity{get;set;}
        public string Image{get;set;}
        public DateTime Data_Order{get;set;}
    }
}