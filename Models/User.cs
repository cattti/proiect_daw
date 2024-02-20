using System;
using proiect_daw.Models.Base;
using proiect_daw.Models.Enums;
using System.Text.Json.Serialization;

namespace proiect_daw.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public UserRole Role { get; set; }


        //comment relation
        public ICollection<Comment> Comments { get; set; } = default!;

        //Project relation
        public ICollection<Project> Projects { get; set; } = default!;
    }
}

