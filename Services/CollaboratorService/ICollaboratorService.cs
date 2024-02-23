using System;
using proiect_daw.Models;

namespace proiect_daw.Services
{
    public interface ICollaboratorService
    {
        Task<Collaborator> CreateCollaboratorAsync(Collaborator collaborator);
        Task<List<Collaborator>> GetAllCollaboratorsAsync();
        Task<Collaborator> GetCollaboratorByIdAsync(Guid id);
        Task UpdateCollaboratorAsync(Collaborator collaborator);
        Task DeleteCollaboratorAsync(Guid id);
    }
}

