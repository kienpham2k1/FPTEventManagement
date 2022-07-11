using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public IEnumerable<Comment> GetComments(int idEvent) => CommentDAO.Instance.GetComments(idEvent);
        public void Comment(Comment cmt) => CommentDAO.Instance.Comment(cmt);
        public void DeleteComment(int idComment) => CommentDAO.Instance.DeleteComment(idComment);
    }
}
