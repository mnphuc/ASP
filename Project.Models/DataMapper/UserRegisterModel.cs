using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Tên phải từ 8 - 50 kí tự!")]
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tài khoản!")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Tài khoản phải từ 8 - 16 kí tự!")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng xác nhận mật khẩu!")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp!")]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [RegularExpression(@"[\w]+@[\w]+\.[a-zA-Z]{2,4}", ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone")]
        /*[DataType(DataType.PhoneNumber, ErrorMessage = "Vui lòng nhập đúng định dạng phone")]*/
        /*[RegularExpression(@"^[0]{1}\\d{10}$", ErrorMessage = "Vui lòng nhập đúng định dạng phone")]*/
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ !")]
        public string Address { get; set; }

    }
}
