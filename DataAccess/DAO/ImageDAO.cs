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
                if (images.Count() < 1) return images = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return images;
        }
        public void SaveImage(Image img)
        {
            using var db = new FEventContext();
            db.Images.Add(img);
            db.SaveChanges();
            int id = img.Id;
        }
        public Image GetImage(int idEvent)
        {
            Image image = null;
            try
            {
                var images = GetImages(idEvent);
                if (images != null)
                {
                    image = images.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return image;
        }
        public void Update(Image img)
        {
            try
            {
                Image i = GetImage(img.IdEvent);
                if(i != null)
                {
                    using var db = new FEventContext();
                    db.Images.Update(img);
                    db.SaveChanges();
                }
            }catch (Exception ex) { }
        }
       
    }
}
