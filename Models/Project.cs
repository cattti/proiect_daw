using System;
using proiect_daw.Models.Base;
namespace proiect_daw.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }



        //Artwork relation
        public ICollection<Artwork> Artworks { get; set; } = default!;


        //Comment relation
        public ICollection<Comment> Comments { get; set; } = default!;

        //User relation
        public User User { get; set; } = default!;
        public Guid UserId { get; set; }

        //Project_collaborator relation
        public ICollection<Project_Collaborator> Project_Collaborators = default!;



    }
}

