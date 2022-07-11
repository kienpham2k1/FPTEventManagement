using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess
{
    public class LikeDAO
    {
        private static LikeDAO instance = null;
        private static object instanceLook = new object();

        public static LikeDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new LikeDAO();
                    }
                    return instance;
                }
            }
        }
        public Like GetLike(int userId, int idEvent)
        {
            Like like = null;
            try
            {
                var context = new FEventContext();
                like = context.Likes.SingleOrDefault(x => x.IdUser == userId && x.IdEvent == idEvent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return like;
        }
    }
}
