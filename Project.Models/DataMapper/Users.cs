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
        public int id { get; set; }

        [Display(Name = "User Name")]
        public String UserName { get; set; }
        [Display(Name = "Pass Word")]
        public String PassWord { get; set; }

        [Display(Name ="Full Name")]
        public String FullName { get; set; }
        [Display(Name = "Address")]
        public String Address { get; set; }
    }
}
