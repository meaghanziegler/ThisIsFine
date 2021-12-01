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
        [Required]
        public Guid AuthorId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
