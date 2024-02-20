using System;
using proiect_daw.Models.Base;
using proiect_daw.Models.Enums;
using System.Text.Json.Serialization;

namespace proiect_daw.Models
{
	public class Collaborator : BaseEntity
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }



        //Project_Collaborator relation

        public ICollection<Project_Collaborator> Project_Collaborators { get; set;}

    }
}

