using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Models
{
    public class CommentList
    {
        
        public int CommentId { get; set; }
        [Display (Name ="Created")]
        public DateTimeOffset CreatedUTC { get; set; }
    }
}
