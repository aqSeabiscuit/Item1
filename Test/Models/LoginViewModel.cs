using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class LoginViewModel
    {
        [Display(Name="用户名")]
        [Required,StringLength(10,MinimumLength =2)]
        public string username { get; set; }
        [Display(Name = "密码")]
        public string password { get; set; }
    }
}