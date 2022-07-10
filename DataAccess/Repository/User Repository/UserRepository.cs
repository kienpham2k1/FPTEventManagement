using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;
namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
       public User GetUser(int id) => UserDAO.Instance.GetUser(id);
    }
}
