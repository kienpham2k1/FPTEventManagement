using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public class EventRepository : IEventRepository
    {
        public IEnumerable<Event> GetEvents(DateTime? time) => EventDAO.Instance.GetEvents(time);
        public IEnumerable<Event> GetEvents(DateTime time) => EventDAO.Instance.GetEvents(time);
        public Like Like(int userId, int eventId) => EventDAO.Instance.Like(userId, eventId);
        public Follow Follow(int userId, int eventId) => EventDAO.Instance.Follow(userId, eventId);
        public IEnumerable<Event> GetEvents(int idUserfollow) => EventDAO.Instance.GetEvents(idUserfollow);
        public IEnumerable<Event> GetEventsUserCreate(int idUserCreate) => EventDAO.Instance.GetEventsUserCreate(idUserCreate);
        public IEnumerable<Event> GetEvents(string nameEvent) => EventDAO.Instance.GetEvents(nameEvent);
        public Event GetEventById(int id) => EventDAO.Instance.GetEventById(id);
        

        public IEnumerable<Event> GetEvents() => EventDAO.Instance.GetEvents();

        public int GetNewIdEventCreate() => EventDAO.Instance.GetNewIdEventCreate();

        public void SaveEvent(Event e) => EventDAO.Instance.SaveEvent(e);

        public void Update(Event e) => EventDAO.Instance.Update(e);
        
    }
}
