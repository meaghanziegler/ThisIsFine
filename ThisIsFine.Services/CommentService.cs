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
        private readonly Guid _usedID;
        public CommentService(Guid usedID)
        {
            _usedID = usedID;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity = new Comment()
            {
                AuthorID = _usedID,
                Text = model.Text,
                ID = model.ID
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
                var query = ctx.Comments.Where(e => e.AuthorID == _usedID).Select(e => new CommentList
                {
                    ID = e.ID

                }) ;
                return query.ToArray();
            }
        }
    }
}
