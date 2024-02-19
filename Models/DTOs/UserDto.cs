using System;
using proiect_daw.Models.Enums;
namespace proiect_daw.Models.DTOs
{
	public class UserDto
	{
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public UserRole Role { get; set; }
    }
}

