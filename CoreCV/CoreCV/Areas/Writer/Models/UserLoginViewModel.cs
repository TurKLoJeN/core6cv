﻿using System.ComponentModel.DataAnnotations;

namespace CoreCV.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz")]
        public string Username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
