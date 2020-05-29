using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TSB.Entites
{
    public class Article
    {
        public int Id { get; set; }
        [Display(Name = "Tên bài viết"), Required(ErrorMessage = "Chưa nhập tên bài viết !")]
        public string Name { get; set; }
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Display(Name = "Tóm tắt")]
        public string Sumary { get; set; }
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [Display(Name = "Ảnh nền")]
        public string Image { get; set; }
        [Display(Name = "Ngày đăng")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Người đăng")]
        public string CreateBy { get; set; }
        [Display(Name = "Danh mục bài viết"), Required(ErrorMessage = "Chưa chọn danh mục !")]
        public int? CategoryId { get; set; }
        [Display(Name = "Hiển thị")]
        public bool ShowHome { get; set; }
        [ScaffoldColumn(false)]
        public int CountView { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category{ get; set; }
    }
}