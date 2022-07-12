using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_layer;


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
        public int GetNewIdEventCreate()
        {
            using var db = new FEventContext();
            int id = db.Events.Max(e => e.Id);
            return id;
        }
        public void Update(Event e)
        {
            try
            {
                Event ev = GetEventById(e.Id);
                if (ev != null)
                {
                    using var db = new FEventContext();
                    db.Events.Update(e);
                    db.SaveChanges();
                }
            }catch (Exception ex) { }  
        }
        public Event GetEventById(int id)
        {
            Event evt =null;
            try {
                using var db = new FEventContext();
                evt = db.Events.FirstOrDefault(e => e.Id == id);
            }catch (Exception ex) { }
            

            return evt;
        }
        public void SaveEvent(Event e)
        {
            using var db = new FEventContext();
            db.Events.Add(e);
            db.SaveChanges();
            int id = e.Id;
        }
    }
}
