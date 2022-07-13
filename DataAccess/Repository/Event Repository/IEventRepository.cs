using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;

namespace DataAccess.Repository
{
    public interface IEventRepository
    {
        //void CreateEvent(Event @event);
        //void UpdateEvent(Event @event);
        //void DeleteEvent(int @event);
        //Event GetEvent(string @event);
        //Event GetEvent(int @event);
        IEnumerable<Event> GetEvents();
        int GetNewIdEventCreate();
        void SaveEvent(Event e);

        Event GetEventById(int id);

        void Update(Event e);
        Like Like(int userId, int eventId);
        Follow Follow(int userId, int eventId);
        IEnumerable<Event> GetEvents(DateTime? time);
        IEnumerable<Event> GetEvents(DateTime time);
        IEnumerable<Event> GetEvents(int idUserfollow);
        IEnumerable<Event> GetEventsUserCreate(int idUserCreate);
        IEnumerable<Event> GetEvents(string nameEvent);
        void DeleteEvent(Event evennt);
        //IEnumerable<Event> GetEvents(string nameEvent = null, IEnumerable<Event> searchList = null);
        //IEnumerable<Event> GetEvents(int? idUserCreate = null);
        //IEnumerable<Event> GetEvents(int? idFollower = null, IEnumerable<Event> searchList = null);
        //IEnumerable<Event> GetEvents(DateTime? timeCreate = null, IEnumerable<Event> searchList = null);
        //IEnumerable<Event> GetEvents(DateTime? timeBegin = null, DateTime? timeEnd = null, IEnumerable<Event> searchList = null);
        //IEnumerable<Event> GetEvents(int category, IEnumerable<Event> searchList = null);
        //IEnumerable<Event> GetEvents(int? like = null, int? vote = null, int? follow = null, IEnumerable<Event> searchList = null);
    }
}
