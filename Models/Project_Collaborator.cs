using System;
using proiect_daw.Models.Base;
namespace proiect_daw.Models
{
	public class Project_Collaborator : BaseEntity
	{
       public int NrCollab { get; set; }

        //collaborator relation
        public Collaborator Collaborator { get; set; }
        public Guid CollaboratorId { get; set; }

        //Project relation
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }


    }
}

