using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class CommentDAO
    {
        private static CommentDAO instance = null;
        private static object instanceLook = new object();

        public static CommentDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new CommentDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Comment> GetComments()
        {
            IEnumerable<Comment> comments = null;
            try
            {
                var context = new FEventContext();
                comments = context.Comments;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return comments;
        }
        public IEnumerable<Comment> GetComments(int idEvent)
        {
            IEnumerable<Comment> comments = null;
            try
            {
                var context = new FEventContext();
                comments = context.Comments.Where(cmt => cmt.IdEvent == idEvent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return comments;
        }
        public void Comment(Comment cmt)
        {
            try
            {
                using (var context = new FEventContext())
                {
                    context.Comments.Add(cmt);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void DeleteComment(int idComment)
        {
            try
            {
                var context = new FEventContext();
                Comment cmt = context.Comments.Find(idComment);
                context.Remove(cmt);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
