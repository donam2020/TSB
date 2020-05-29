using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSB.Models
{
    public class LoginModel
    {
        public int UserId { get; set; }
        [Display(Name ="Tài khoản"),Required(ErrorMessage ="Chưa nhập tài khoản !!!")]
        public string UserName { get; set; }
        [Display(Name ="Mật khẩu"),Required(ErrorMessage ="Chưa nhập mật khẩu !!!")]
        public string Password { get; set; }
        public bool RememberMe { set; get; }

    }
}