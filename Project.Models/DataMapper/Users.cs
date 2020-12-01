using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string UserName { get; set; }
        [Display(Name = "Pass Word")]
        [Required]
        public string PassWord { get; set; }

        [Display(Name ="Full Name")]
        [Required]
        public string FullName { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool Status { get; set; }

        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Groups { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
