using System;
using proiect_daw.Models.Base;
using proiect_daw.Models.Enums;

namespace proiect_daw.Models
{
	public class Collaborator : BaseEntity
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public CollaboratorRole Role { get; set; }


        //Project_Collaborator relation

        public ICollection<Project_Collaborator> Project_Collaborators { get; set;}

    }
}

