using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class Like
    {
        public int IdEvent { get; set; }
        public int IdUser { get; set; }

        public virtual User IdUser1 { get; set; }
        public virtual Event IdUserNavigation { get; set; }
    }
}
