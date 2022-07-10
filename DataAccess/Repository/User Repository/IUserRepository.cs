using BussinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.User_Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void SaveUser(User user);
        User GetUser(int id);
        void DeleteUser(int id);
        void UpdateUser(User user);

        User CheckLogin(string email, string password);
        public int getID();
    }
}
