using System;
using proiect_daw.Models.Base;
namespace proiect_daw.Models
{
	public class Artwork : BaseEntity
    {

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? ArtType { get; set; }

        //public int likeCount { get; set; }


        //istoric relation
        public Istoric Istoric { get; set; } = default!;

        //project relation
        public Project Project { get; set; } = default!;
        public Guid ProjectId { get; set; }


    }
}

