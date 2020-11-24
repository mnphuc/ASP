using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    public class OrderDetail
    {
        [Column(Order = 0), Key]
        public int OrderId { get; set; }

        public int BookId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
