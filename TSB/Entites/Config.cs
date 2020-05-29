using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Entites;
using System.ComponentModel.DataAnnotations;
namespace TSB.Entites
{
    public class Config
    {
        public int Id { get; set; }

        
        public string Name { get; set; }
        [Display(Name ="Địa chỉ")]
        public string Addres { get; set; }

        public string InfoAbout { get; set; }

        public string LinkFacebook { get; set; }

        public string CategoryAbout { get; set; }

        public string ImageAbout { get; set; }

        public string ImageCategory { get; set; }

        public string TitleHome { get; set; }

        public string Description { get; set; }
        [RegularExpression(@"\d+", ErrorMessage = "Chỉ nhập số nguyên")]
        public int Phone { get; set; }

        public string Email { get; set; }

        public string LinkYoutube { get; set; }

        public string LinkTwichter { get; set; }

        public string LinkGoogle { get; set; }
    }
}