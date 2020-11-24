using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
   public class FeedBackForm
    {
        [Key]
        public int FeedBackId { get; set; }
        public string Content { get; set; }


        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }
    }
}
