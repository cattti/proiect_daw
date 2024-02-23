using System;

namespace proiect_daw.Models.DTOs
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
