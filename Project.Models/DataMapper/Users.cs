using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    public class Users
    {   
        [Key]
        [Required]
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        [Required]
        public String UserName { get; set; }
        [Display(Name = "Pass Word")]
        [Required]
        public String PassWord { get; set; }

        [Display(Name ="Full Name")]
        [Required]
        public String FullName { get; set; }
        [Display(Name = "Address")]
        [Required]
        public String Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
