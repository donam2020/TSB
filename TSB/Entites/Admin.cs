using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TSB.Entites
{
    public class Admin
    {
        public int Id { get; set; }
        [Display(Name ="Tên")]
        public string Name { get; set; }
        [Display(Name ="Tài khoản"),Required(ErrorMessage ="Tài khoản không được để trống !!!")]
        public string UserName { get; set; }
        [Display(Name ="Mật khẩu"),Required(ErrorMessage ="Chưa nhập mật khẩu !!!")]
        public string PassWord { get; set; }
        [Display(Name ="Trạng thái")]
        public bool Status { get; set; }
    }
}