using System;
using proiect_daw.Models;

namespace proiect_daw.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            await _commentRepository.CreateAsync(comment);
            await _commentRepository.SaveAsync();
            return comment;
        }

        public async Task<List<Comment>> GetAllCommentsAsync()
        {
            return await _commentRepository.GetAll();
        }

        public async Task<Comment> GetCommentByIdAsync(Guid id)
        {
            return await _commentRepository.FindByIdAsync(id);
        }

        public async Task UpdateCommentAsync(Comment comment)
        {
            _commentRepository.Update(comment);
            await _commentRepository.SaveAsync();
        }

        public async Task DeleteCommentAsync(Guid id)
        {
            var comment = await _commentRepository.FindByIdAsync(id);
            if (comment != null)
            {
                _commentRepository.Delete(comment);
                await _commentRepository.SaveAsync();
            }
        }
    }
}

