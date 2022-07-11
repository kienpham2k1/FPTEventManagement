using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public class LikeRepository : ILikeRepository
    {
        public Like GetLike(int userId, int idEvent) => LikeDAO.Instance.GetLike(userId, idEvent);
    }
}
