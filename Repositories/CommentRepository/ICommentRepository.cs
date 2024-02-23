using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

public interface ICommentRepository : IGenericRepository<Comment>
{
    Task<List<Comment>> GetCommentsByUserId(Guid userId);
}
