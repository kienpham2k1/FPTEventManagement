using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_layer;


namespace DataAccess.Repository
{
    public class EventRepository : IEventRepository
    {
        public Event GetEventById(int id) => EventDAO.Instance.GetEventById(id);
        

        public IEnumerable<Event> GetEvents() => EventDAO.Instance.GetEvents();

        public int GetNewIdEventCreate() => EventDAO.Instance.GetNewIdEventCreate();

        public void SaveEvent(Event e) => EventDAO.Instance.SaveEvent(e);

        public void Update(Event e) => EventDAO.Instance.Update(e);
        
    }
}
