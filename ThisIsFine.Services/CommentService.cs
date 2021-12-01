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
        private readonly Guid _userID;
        public CommentService(Guid usedID)
        {
            _userID = usedID;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity = new Comment()
            {
                Text = model.Text;

            }
        
        }
    }
}
