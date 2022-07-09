using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess
{
    public class EventDAO
    {
        private static EventDAO instance = null;
        private static object instanceLook = new object();

        public static EventDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new EventDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Event> GetEvents()
        {
            IEnumerable<Event> events = null;
            try
            {
                using (var context = new FEventContext())
                {
                    events = context.Events.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return events;
        }
    }
}
