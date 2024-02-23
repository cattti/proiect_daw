using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

public interface IProjectRepository : IGenericRepository<Project>
{
    Task<List<Project>> GetProjectsByUserId(Guid userId);
}
