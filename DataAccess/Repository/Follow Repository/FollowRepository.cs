using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public class FollowRepository: IFollowRepository
    {
        public Follow GetFollow(int userId, int idEvent) => FollowDAO.Instance.GetFollow(userId, idEvent);
    }
}
