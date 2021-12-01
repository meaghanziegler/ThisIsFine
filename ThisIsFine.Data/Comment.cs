using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsFine.Data
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public Guid AuthorID { get; set; }
        public virtual List<Replies> Replies { get; set; }
    }
}
