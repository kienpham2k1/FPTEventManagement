using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_layer;


namespace DataAccess.Repository
{
    public class ImageRepository : IImageRepository
    {
        public IEnumerable<Images> GetImages(int idEvent) => ImageDAO.Instance.GetImages(idEvent);
        public Images GetImage(int idEvent) => ImageDAO.Instance.GetImage(idEvent);

        public void SaveImage(Images image) => ImageDAO.Instance.SaveImage(image);

        public void Update(Images image) => ImageDAO.Instance.Update(image);
       
    }
}
