﻿using System.ComponentModel.DataAnnotations;

namespace RealEstateCourse.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
            [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "نام کامل خود را وارد نمایید.")]
        [MaxLength(100, ErrorMessage = "نام شما نمی تواند از 100 کاراکتر بیشتر باشد")]
        public string FullName { get; set; }
        public string? ReturnUrl { get; set; }
    }
    
}
