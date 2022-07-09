using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class Follow
    {
        public int IdEvent { get; set; }
        public int IdUser { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
