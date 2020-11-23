using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }

        [ForeignKey("UserId")]
        public Users Users { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public float? TotalPrice { get; set; }
        public string PaymentMethods { get; set; }
        public byte Status { get; set; }
        public DateTime Created { get; set; }
    }
}
