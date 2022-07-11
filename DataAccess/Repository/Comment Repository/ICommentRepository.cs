using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetComments(int idEvent);
        void Comment(Comment cmt);
        void DeleteComment(int idComment);
    }
}
