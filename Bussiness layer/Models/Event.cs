using System;
using System.Collections.Generic;

#nullable disable

namespace Bussiness_layer
{
    public partial class Event
    {
        public Event()
        {
            Comments = new HashSet<Comment>();
            Images = new HashSet<Images>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdUser { get; set; }
        public DateTime Create { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public int? Like { get; set; }
        public int? Vote { get; set; }
        public int? Follow { get; set; }
        public bool Status { get; set; }
        public int IdCategory { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
