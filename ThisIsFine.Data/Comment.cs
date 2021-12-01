using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Data
{
    public class Comment
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public string Text { get; set; }
        public Guid AuthorID { get; set; }
        public virtual List<Reply> ReplyId { get; set; }
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }
    }
}
