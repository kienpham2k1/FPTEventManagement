using BussinessLayer.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.User_Repository
{
    public class UserRepository : IUserRepository
    {
        public User CheckLogin(string email, string password) =>UserDAO.Instance.CheckLogin(email, password);
        

        public void DeleteUser(int id) => UserDAO.Instance.DeleteUser(id);

        public int getID() => UserDAO.Instance.getId();
       
        public User GetUser(int id) => UserDAO.Instance.GetUserByID(id);
        

        public IEnumerable<User> GetUsers() => UserDAO.Instance.GetUsers();
     

        public void SaveUser(User user) => UserDAO.Instance.SaveUser(user);
      

        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);
       
    }
}
