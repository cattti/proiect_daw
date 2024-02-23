using System;
using proiect_daw.Models;

namespace proiect_daw.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Project> CreateProjectAsync(Project project)
        {
            await _projectRepository.CreateAsync(project);
            await _projectRepository.SaveAsync();
            return project;
        }

        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAll();
        }

        public async Task<Project> GetProjectByIdAsync(Guid id)
        {
            return await _projectRepository.FindByIdAsync(id);
        }

        public async Task UpdateProjectAsync(Project project)
        {
            _projectRepository.Update(project);
            await _projectRepository.SaveAsync();
        }

        public async Task DeleteProjectAsync(Guid id)
        {
            var project = await _projectRepository.FindByIdAsync(id);
            if (project != null)
            {
                _projectRepository.Delete(project);
                await _projectRepository.SaveAsync();
            }
        }
    }
}

