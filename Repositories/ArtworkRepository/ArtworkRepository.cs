using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Models.DTOs;
using proiect_daw.Repositories;
using proiect_daw.Repositories.GenericRepository;
namespace proiect_daw.Repositories.ArtworkRepository { 

public class ArtworkRepository : GenericRepository<Artwork>, IArtworkRepository
{
    public ArtworkRepository(clasaContext context) : base(context)
    {
    }

    public async Task<List<Artwork>> GetArtworkByProjectId(Guid projectId)
    {
        return await _table.Where(a => a.ProjectId == projectId).ToListAsync();
    }


     public async Task<List<Artwork>> GetAllArtworksWithDetailsAsync()
        {
            return await _table
                .Include(a => a.Istoric) 
                .Include(a => a.Project) 
                .ToListAsync();
        }

        public async Task<List<Artwork>> GetArtworksWithDetailsJoinAsync()
        {
            return await _context.Artworks
                .Join(
                    _context.Projects,
                    artwork => artwork.ProjectId,
                    project => project.Id,
                    (artwork, project) => new Artwork
                    {
                        Id = artwork.Id,
                        Title = artwork.Title,
                        Description = artwork.Description,
                        ArtType = artwork.ArtType,
                        Project = project  
                    }
                )
                .ToListAsync();
        }


        public async Task<List<IGrouping<string, Artwork>>> GroupArtworksByTypeAsync()
        {
            return await _context.Artworks
                .GroupBy(a => a.ArtType)
                .ToListAsync();
        }



        public async Task<Artwork> GetFirstArtworkAsync()
        {
            return await _table.OrderBy(a => a.DateCreated).FirstOrDefaultAsync();
        }


        public async Task<List<ArtworkDto>> GetAllArtworkTitlesAsync()
        {
            return await _table.Select(a => new ArtworkDto { Id = a.Id, Title = a.Title }).ToListAsync();
        }


        public async Task<List<Artwork>> GetArtworksOrderedByTitleAsync()
        {
            return await _table.OrderBy(a => a.Title).ToListAsync();
        }




    }


}