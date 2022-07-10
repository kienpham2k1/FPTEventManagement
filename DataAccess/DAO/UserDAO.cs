using BussinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        private static readonly object instanceLock = new object();

        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<User> GetUsers()
        {
            var listMember = new List<User>();
            try
            {
                using var db = new FEventContext();
                listMember = db.Users.ToList();
            }
            catch (Exception ex) { }
            return listMember;
        }

        public User GetUserByID(int id)
        {
            User member = null;
            try
            {
                using var db = new FEventContext();
                member = db.Users.SingleOrDefault(c => c.Id == id);

            }
            catch (Exception ex) { }
            return member;
        }
        public void UpdateUser(User m)
        {
            try
            {
                User mem = GetUserByID(m.Id);
                if (mem != null)
                {
                    using var db = new FEventContext();
                    db.Users.Update(m);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { }
        }
        public void SaveUser(User m)
        {
            try
            {
                User mem = GetUserByID(m.Id);
                if (mem == null)
                {
                    
                    using var db = new FEventContext();

                    db.Users.Add(m);
                    db.SaveChanges();
                    int id = m.Id;
                }
                else
                {
                    throw new Exception("Member not found");
                }
            }
            catch (Exception ex) { }
        }
        public int getId()
        {
            using var db = new FEventContext();
            int id = db.Users.Max(c => c.Id + 1);
            return id;
        }
        public void DeleteUser(int id)
        {
            try
            {
                User m = GetUserByID(id);
                if (m != null)
                {
                    using var db = new FEventContext();
                    db.Users.Remove(m);
                    db.SaveChanges();
                }
            }
            catch { }
        }

        public User CheckLogin(string email, string password)
        {
            User member = null;

            try
            {
                using(var db = new FEventContext())
                {
                    member = db.Users.SingleOrDefault(c => c.Email == email && c.Password == password);
                }
            }catch (Exception ex) { }
            return member;

        }
    }
}
