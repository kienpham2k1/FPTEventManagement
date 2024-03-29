﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class Event
    {
        public Event()
        {
            Comments = new HashSet<Comment>();
            Follows = new HashSet<Follow>();
            Images = new HashSet<Image>();
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdUser { get; set; }
        public DateTime Create { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public int? Like { get; set; }
        public int? Follow { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
