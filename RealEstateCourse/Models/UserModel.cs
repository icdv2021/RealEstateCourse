using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RealEstateCourse.Models
{
    public class UserModel:IdentityUser
    {
        [Required(ErrorMessage ="نام کامل خود را وارد نمایید.")]
        [MaxLength(100,ErrorMessage ="نام شما نمی تواند از 100 کاراکتر بیشتر باشد")]
        public string FullName { get; set; }


    }
}
