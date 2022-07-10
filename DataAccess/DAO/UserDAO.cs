using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static object instanceLook = new object();

        public static UserDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public User GetUser(int id)
        {
            User user = null;
            try
            {
                var context = new FEventContext();
                user = context.Users.SingleOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
    }
}
