using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess
{
    public class ImageDAO
    {
        private static ImageDAO instance = null;
        private static object instanceLook = new object();

        public static ImageDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new ImageDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Image> GetImages(int idEvent)
        {
            IEnumerable<Image> images = null;
            try
            {
                var context = new FEventContext();
                images = from item in context.Images where item.IdEvent == idEvent orderby item.Id select item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return images;
        }
        public Image GetImage(int idEvent)
        {
            Image image = null;
            try
            {
                var images = GetImages(idEvent);
                image = images.FirstOrDefault();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return image;
        }
    }
}
