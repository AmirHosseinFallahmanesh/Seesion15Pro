using Demo.Infrastrucuture;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class PersonViewModel
    {

        [Required(ErrorMessage ="لطفا نام را وارد کنید")]
        [StringLength(20, ErrorMessage = "طول نام باید بین 6 نا 20 کارکتر باشد",MinimumLength = 6)]
        [Remote("CheckUserName", "Home", ErrorMessage ="این نام گرفته شده")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [EmailAddress(ErrorMessage ="ایمیل صحیح نیست")]

        public string Email { get; set; }


        [RegularExpression(@"09\d{9}",ErrorMessage ="شماره نلفن معتبر نیست")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       

        [Compare("Password",ErrorMessage ="پسورد ها یکسان نیستند")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }


        [Required(ErrorMessage = "لطفا سن خود را وارد کنید")]
        [Range(18,50,ErrorMessage ="سن معتبر نیست")]
        public int Age { get; set; }

        [Required]

        public DateTime HireadDate { get; set; }

       
        [AcceptConfirmation(ErrorMessage ="لطفا وارد کنید")]
        public bool Accept { get; set; }

        [DataType(DataType.MultilineText)]
        public string Descriptoin { get; set; }
   



    }
}