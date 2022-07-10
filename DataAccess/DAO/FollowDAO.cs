using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess
{
    public class FollowDAO
    {
        private static FollowDAO instance = null;
        private static object instanceLook = new object();

        public static FollowDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new FollowDAO();
                    }
                    return instance;
                }
            }
        }
        public Follow GetFollow(int userId, int idEvent)
        {
            Follow follow = null;
            try
            {
                var context = new FEventContext();
                follow = context.Follows.SingleOrDefault(x => x.IdUser == userId && x.IdEvent == idEvent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return follow;
        }
    }
}
