using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisIsFine.Data;
using ThisIsFine.Models;

namespace ThisIsFine.Services
{
    public class CommentService
    {
        private readonly Guid _usedId;
        public CommentService(Guid usedId)
        {
            _usedId = usedId;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity = new Comment()
            {
                AuthorId = _usedId,
                Text = model.Text,
                
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CommentList> GetComments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Comments.Where(e => e.AuthorId == _usedId).Select(e => new CommentList
                {
                    CommentId = e.CommentId

                }) ;
                return query.ToArray();
            }
        }
    }
}
