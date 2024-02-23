using System;
using proiect_daw.Models;

namespace proiect_daw.Services.CollaboratorService
{
    public class CollaboratorService : ICollaboratorService
    {
        private readonly ICollaboratorRepository _collaboratorRepository;

        public CollaboratorService(ICollaboratorRepository collaboratorRepository)
        {
            _collaboratorRepository = collaboratorRepository;
        }

        public async Task<Collaborator> CreateCollaboratorAsync(Collaborator collaborator)
        {
            await _collaboratorRepository.CreateAsync(collaborator);
            await _collaboratorRepository.SaveAsync();
            return collaborator;
        }

        public async Task<List<Collaborator>> GetAllCollaboratorsAsync()
        {
            return await _collaboratorRepository.GetAll();
        }

        public async Task<Collaborator> GetCollaboratorByIdAsync(Guid id)
        {
            return await _collaboratorRepository.FindByIdAsync(id);
        }

        public async Task UpdateCollaboratorAsync(Collaborator collaborator)
        {
            _collaboratorRepository.Update(collaborator);
            await _collaboratorRepository.SaveAsync();
        }

        public async Task DeleteCollaboratorAsync(Guid id)
        {
            var collaborator = await _collaboratorRepository.FindByIdAsync(id);
            if (collaborator != null)
            {
                _collaboratorRepository.Delete(collaborator);
                await _collaboratorRepository.SaveAsync();
            }
        }
    }
}

