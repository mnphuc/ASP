using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    class OrderDetail
    {
        [Column(Order = 0), Key]
        public int OrderId { get; set; }
        [Column(Order = 1), Key]
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        [ForeignKey("OrderId")]
        public Order Orders { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
