using proiect_daw.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proiect_daw.Services
{
    public interface IArtworkService
    {
        Task<Artwork> CreateArtworkAsync(Artwork artwork);
        Task<List<Artwork>> GetAllArtworksAsync();
        Task<Artwork> GetArtworkByIdAsync(Guid id);
        Task UpdateArtworkAsync(Artwork artwork);
        Task DeleteArtworkAsync(Guid id);
    }
}
