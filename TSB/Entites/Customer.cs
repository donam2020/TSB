using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TSB.Entites
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name ="Địa chỉ")]
        public string Addres { get; set; }
        [Display(Name ="Số điện thoại"), RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên")]
        public int Phone { get; set; }
        [Display(Name ="Tên khách hàng"),StringLength(20,ErrorMessage ="Độ dài từ 2 > 20 kí tự !!!"),MinLength(2,ErrorMessage ="Độ dài từ 2 > 20 kí tự !!!"),Required(ErrorMessage ="Chưa nhập tên !!!")]
        public string Name { get; set; }
        [Display(Name ="Nội dung")]
        public string Content { get; set; }
        [Display(Name ="Địa chỉ Email"),Required(ErrorMessage ="Chưa nhập Email !!!")]
        public string Email { get; set; }
        [Display(Name ="Ảnh đại diện")]
        public string Image { get; set; }
        [Display(Name ="Trạng thái")]
        public bool Status { get; set; }
    }
}