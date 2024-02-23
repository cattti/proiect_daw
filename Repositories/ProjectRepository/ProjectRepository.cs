using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    public ProjectRepository(clasaContext context) : base(context)
    {
    }

    public async Task<List<Project>> GetProjectsByUserId(Guid userId)
    {
        return await _table.Where(p => p.UserId == userId).ToListAsync();
    }
}
