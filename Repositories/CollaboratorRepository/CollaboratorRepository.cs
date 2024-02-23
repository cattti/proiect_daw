using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

public class CollaboratorRepository : GenericRepository<Collaborator>, ICollaboratorRepository
{
    public CollaboratorRepository(clasaContext context) : base(context)
    {
    }

    public async Task<List<Collaborator>> GetCollaboratorsByProjectId(Guid projectId)
    {
        return await _table.Where(c => c.Project_Collaborators.Any(pc => pc.ProjectId == projectId)).ToListAsync();
    }
}
