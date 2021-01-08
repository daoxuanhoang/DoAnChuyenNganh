using System;
using System.ComponentModel.DataAnnotations;
namespace XuanHoang.Models
{
    public class Category
    {
        public long Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public bool Status{get;set;}
    }

    public class CategoryDTO
    {
        public long Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public bool Status{get;set;}
    }
}