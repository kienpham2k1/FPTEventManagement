using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_layer;

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
        public IEnumerable<Images> GetImages(int idEvent)
        {
            IEnumerable<Images> images = null;
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
        public void SaveImage(Images img)
        {
            using var db = new FEventContext();
            db.Images.Add(img);
            db.SaveChanges();
            int id = img.Id;
        }
        public Images GetImage(int idEvent)
        {
            Images image = null;
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
        public void Update(Images img)
        {
            try
            {
                Images i = GetImage(img.IdEvent);
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
