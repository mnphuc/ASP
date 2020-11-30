using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public float? Price { get; set; }
        public string Code { get; set; }
        public DateTime? Create_at { get; set; }
        public DateTime? Update_at { get; set; }
        [Required]
        public bool Status { get; set; }
        public string Author { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
       
}
