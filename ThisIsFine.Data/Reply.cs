using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Data
{
    public class Reply
    {
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        [Required]
        public int ReplyId { get; set; }
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
    }
}
