using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Demo.Models;

namespace Demo.ViewModels
{
    public class SetadFormViewModel
    {
        [Display(Name = "نام ")]
        public string Name { get; set; }

        [Display(Name = "شاخص")]
        public string Shakhes { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "استان")]
        public int? ProvinceId { get; set; }                    // use it in DropDownList

        public IEnumerable<Province> Provinces { get; set; }   // created for showing the list in DropDown

        public bool IsModiriatShoab { get; set; }

        public int IpRangeId { get; set; }
        
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
    }
}