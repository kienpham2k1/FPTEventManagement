using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public class ImageRepository : IImageRepository
    {
        public IEnumerable<Image> GetImages(int idEvent) => ImageDAO.Instance.GetImages(idEvent);
        public Image GetImage(int idEvent) => ImageDAO.Instance.GetImage(idEvent);
    }
}
