using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TSB.Entites
{
    public class Baner
    {
        public int Id { get; set; }
        [DisplayName("Tên baner"),StringLength(100,ErrorMessage ="Tên quá dài !!!"),Required(ErrorMessage ="Tên không được để trống !")]
        public string Name { get; set; }
        [DisplayName("Ảnh")]
        public string Image { get; set; }
        [DisplayName("Số thứ tự")]
        public int Order { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime CreateDate { get; set; }

        public string Url { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
        [DisplayName("Vị trí"),Required(ErrorMessage ="Chưa chọn vị trí")]
        public GruopBaner Positon { get; set; }

    }
    public enum GruopBaner
    {
        [Display(Name ="Baner Top")]
        BanerTop,
        [Display(Name ="Slider")]
        Slider,
        [Display(Name ="Đối tác")]
        Partner,
        Logo,
        [Display(Name ="Thể loại")]
        Category,
        [Display(Name ="Sản phẩm")]
        Product
    }
}