using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_layer;


namespace DataAccess.Repository
{
    public interface IImageRepository
    {
        IEnumerable<Images> GetImages(int idEvent);
        Images GetImage(int idEvent);

        void SaveImage(Images image);
        void Update(Images image);
    }
}
