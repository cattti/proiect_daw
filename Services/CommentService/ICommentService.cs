using System;
using proiect_daw.Models;

namespace proiect_daw.Services.CommentService
{
    public interface ICommentService
    {
        Task<Comment> CreateCommentAsync(Comment comment);
        Task<List<Comment>> GetAllCommentsAsync();
        Task<Comment> GetCommentByIdAsync(Guid id);
        Task UpdateCommentAsync(Comment comment);
        Task DeleteCommentAsync(Guid id);
    }
}

