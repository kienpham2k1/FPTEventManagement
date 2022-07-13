using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Models;
using Microsoft.EntityFrameworkCore;

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
        public Event GetEvent(int idEvent)
        {
            Event @event = null;
            try
            {
                var context = new FEventContext();
                @event = context.Events.SingleOrDefault(x => x.Id == idEvent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return @event;
        }

        public IEnumerable<Event> GetEvents(string nameEvent)
        {
            IEnumerable<Event> events;
            try
            {
                var context = new FEventContext();
                events = context.Events.Where(x => x.Name.ToLower().Contains(nameEvent.ToLower()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return events;
        }

        public IEnumerable<Event> GetEvents(DateTime? time)
        {
            IEnumerable<Event> events = null;
            try
            {
                using (var context = new FEventContext())
                {
                    events = from item in context.Events.ToList() where (item.Begin >= time.Value.Date) orderby item.Begin ascending select item;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return events;
        }
        public IEnumerable<Event> GetEvents(DateTime time)
        {
            IEnumerable<Event> events = null;
            DateTime startDay = time.Date;
            DateTime endDay = startDay.AddDays(1);
            try
            {
                using (var context = new FEventContext())
                {
                    events = from item in context.Events.ToList() where (item.Begin >= startDay && item.End < endDay) orderby item.Begin ascending select item;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return events;
        }
        public IEnumerable<Event> GetEvents(int idUserfollow)
        {
            IEnumerable<Event> events = null;
            try
            {
                var context = new FEventContext();
                var listEvent = context.Events;
                var listFollow = context.Follows;
                if (listFollow == null || listEvent == null)
                {
                    events = null;
                }
                else
                {
                    events = from e in context.Events
                             join fl in context.Follows
                             on e.Id equals fl.IdEvent
                             where fl.IdUser == idUserfollow
                             select e;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return events;
        }
        public IEnumerable<Event> GetEventsUserCreate(int idUserCreate)
        {
            IEnumerable<Event> events = null;
            try
            {
                var context = new FEventContext();
                events = context.Events.Where(x => x.IdUser == idUserCreate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return events;
        }
        public Follow Follow(int userId, int eventId)
        {
            Follow follow = null;
            try
            {
                var context = new FEventContext();
                if (context.Follows.SingleOrDefault(x => x.IdUser == userId && x.IdEvent == eventId) == null)
                {
                    follow = new Follow
                    {
                        IdUser = userId,
                        IdEvent = eventId,
                    };
                    context.Follows.Add(follow);
                    Event _evet = GetEvent(eventId);
                    context.Events.Update(_evet);
                    context.SaveChanges();
                }
                else
                {
                    var _follow = context.Follows.SingleOrDefault(x => x.IdUser == userId && x.IdEvent == eventId);
                    context.Follows.Remove(_follow);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return follow;
        }
        public Like Like(int userId, int eventId)
        {
            Like like = null;
            try
            {
                var context = new FEventContext();
                if (context.Likes.SingleOrDefault(x => x.IdUser == userId && x.IdEvent == eventId) == null)
                {
                    like = new Like
                    {
                        IdUser = userId,
                        IdEvent = eventId,
                    };
                    context.Likes.Add(like);
                    Event _evet = GetEvent(eventId);
                    context.Events.Update(_evet);
                    context.SaveChanges();
                }
                else
                {
                    var _like = context.Likes.SingleOrDefault(x => x.IdUser == userId && x.IdEvent == eventId);
                    context.Likes.Remove(_like);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return like;
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
            }
            catch (Exception ex) { }
        }
        public Event GetEventById(int id)
        {
            Event evt = null;
            try
            {
                using var db = new FEventContext();
                evt = db.Events.FirstOrDefault(e => e.Id == id);
            }
            catch (Exception ex) { }


            return evt;
        }
        public void SaveEvent(Event e)
        {
            using var db = new FEventContext();
            db.Events.Add(e);
            db.SaveChanges();
            int id = e.Id;
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
