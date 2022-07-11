using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Follows = new HashSet<Follow>();
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public bool Status { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
