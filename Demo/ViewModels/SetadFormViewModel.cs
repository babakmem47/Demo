using Demo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.ViewModels
{
    public class SetadFormViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "پر کردن فیلد نام اجباری است")]
        public string Name { get; set; }

        [Display(Name = "رنج آی پی")]
        [Required(ErrorMessage = "انتخاب آی پی اجباری است")]
        public int IpRangeId { get; set; }

        public IEnumerable<IpRange> IpRanges { get; set; }

        [Display(Name = "شاخص")]
        [StringLength(4, ErrorMessage = "طول فیلد حداکثر چهار رقم")]
        [Range(1, 9999, ErrorMessage = "مقدار غیر مجاز می باشد")]
        public string Shakhes { get; set; }

        [Display(Name = "ایمیل")]
        [EmailAddress(ErrorMessage = "آدرس ایمیل صحیح نیست")]
        public string Email { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "آیا مدیریت شعب است؟")]
        public bool IsModiriatShoab { get; set; }

        [Display(Name = "استان")]
        public int? ProvinceId { get; set; }                    // use it in DropDownList

        public IEnumerable<Province> Provinces { get; set; }   // created for showing the list in DropDown
    }
}