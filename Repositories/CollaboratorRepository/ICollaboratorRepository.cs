using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;

public interface ICollaboratorRepository : IGenericRepository<Collaborator>
{
    Task<List<Collaborator>> GetCollaboratorsByProjectId(Guid projectId);
}
