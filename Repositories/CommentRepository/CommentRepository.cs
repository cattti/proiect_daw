using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    public CommentRepository(clasaContext context) : base(context)
    {
    }

    public async Task<List<Comment>> GetCommentsByUserId(Guid userId)
    {
        return await _table.Where(c => c.UserId == userId).ToListAsync();

    }
}
