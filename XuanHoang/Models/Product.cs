using System;
using System.ComponentModel.DataAnnotations;
namespace XuanHoang.Models
{
    public class Product{
        public long Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public int CategoryId{get;set;}
        public string Image{get;set;}
        public int Price{get;set;}
        public bool Status{get;set;}
    }

    public class ProductDTO
    {
        public long Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public int CategoryId{get;set;}
        public string Image{get;set;}
        public int Price{get;set;}
        public bool Status{get;set;}
    }
}