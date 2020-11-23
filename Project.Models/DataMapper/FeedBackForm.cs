using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.DataMapper
{
    class FeedBackForm
    {
        public int FeedBackId { get; set; }
        public string Content { get; set; }
        [ForeignKey("UserId")]
        public Users Users { get; set; }
    }
}
