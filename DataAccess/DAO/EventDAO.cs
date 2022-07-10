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
            try {
                var context = new FEventContext();
                @event = context.Events.SingleOrDefault(x => x.Id == idEvent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return @event;
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
    }
}
