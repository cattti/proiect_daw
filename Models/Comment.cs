using System;
using proiect_daw.Models.Base;
namespace proiect_daw.Models
{
	public class Comment : BaseEntity
	{

        public string Content { get; set; }

        //public int likeCount { get; set; }


        //user relation
        public User User { get; set; } = default!;
        public Guid UserId { get; set; }

        //project relation
        public Project Project { get; set; } = default!;
        public Guid ProjectId { get; set; }
    }
}

