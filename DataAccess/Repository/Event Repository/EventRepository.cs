﻿using System;
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
    }
}
