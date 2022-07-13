using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int IdEvent { get; set; }
        public int IdUser { get; set; }
        public string Comment1 { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
