using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Models
{
    public class CommentDetail
    {
        public int ID { get; set; }
        public string Text { get; set;  }
        [Display(Name ="Created")]
        public DateTimeOffset CreatedUTC { get; set; }
        [Display(Name ="Modified")]
        public DateTimeOffset? ModifiedUTC { get; set; }
    }
}
