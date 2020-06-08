using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
namespace TSB.Entites
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Tên thể loại")]
        public string Name { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Số thự tự")]
        public int Order { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Image { get; set; }
        [Display(Name = "Hiển thị")]
        public bool ShowHome { get; set; }
        [Display(Name = "Danh mục cha")]
        public int? ParentId { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
        public TyShow TypeShow { get; set; }
        public virtual IEnumerable<Article> Articles { get; set; }
    }
    public enum TyShow
    {
        [Display(Name = "Thể loại")]
        Category,
        [Display(Name = "Sản phẩm")]
        Product,
        [Display(Name = "Tin tức")]
        Article,
        Slider,
        [Display(Name ="Tuyển dụng")]
        Tuyendung,
        [Display(Name ="Khách hàng")]
        Customer
    }
    public class CategoryC
    {
        private TsbDbContext db = new TsbDbContext();
        public IEnumerable<Category> ParentId { get; set; }
        public IEnumerable<Category> CategoryChilds(int ParentId)
        {
            return db.Categories.Where(x => x.ParentId == ParentId);
        }

    }
}