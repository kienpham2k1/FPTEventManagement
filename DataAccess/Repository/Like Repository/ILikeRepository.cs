using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public interface ILikeRepository
    {
        Like GetLike(int userId, int idEvent);
    }
}
