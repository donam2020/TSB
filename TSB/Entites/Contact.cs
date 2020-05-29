using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSB.Entites
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Họ và tên"), StringLength(10, ErrorMessage = "Độ dài từ 4 -> 10 kí tự !"),
       MinLength(4, ErrorMessage = "Độ dài từ 4 -> 10 kí tự !"), Required(ErrorMessage = "Tên không được để trống !")]
        public string Name { get; set; }
        [Display(Name = " Email"),Required(ErrorMessage ="Email không được để trống !!!")]
        public string Email { get; set; }
        [Display(Name ="Số điện thoại"),Required(ErrorMessage ="Số điện thoại không được để trống !!!"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên")]
        public int Phone { get; set; }
        [Display(Name ="Nội dung")]
        public string Content { get; set; }
        [Display(Name ="Công ty")]
        public string CompanyName { get; set; }
        [Display(Name ="Địa chỉ")]
        public string Addres { get; set; }
        [Display(Name ="Trạng thái")]
        public bool Status { get; set; }
    }
}