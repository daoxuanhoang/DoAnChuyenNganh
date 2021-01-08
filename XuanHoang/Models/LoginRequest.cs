using System;
using System.ComponentModel.DataAnnotations;

namespace XuanHoang.Models
{
    public class LoginRequest
    {
        public string Email { get; set; }  
   
        [DataType(DataType.Password)] 
        public string Pass { get; set; }  
        
        [Display(Name ="Remember Me")] 
        public bool RememberMe { get; set; } 
        public string ReturnUrl { get; set; } 
    }
}