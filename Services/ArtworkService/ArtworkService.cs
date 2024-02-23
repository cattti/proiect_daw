using proiect_daw.Models;
using proiect_daw.Repositories.ArtworkRepository;
using proiect_daw.Services;
namespace proiect_daw.ArtworkService
{
    public class ArtworkService : IArtworkService
    {
        private readonly IArtworkRepository _artworkRepository;

        public ArtworkService(IArtworkRepository artworkRepository)
        {
            _artworkRepository = artworkRepository;
        }

        public async Task<Artwork> CreateArtworkAsync(Artwork artwork)
        {
            await _artworkRepository.CreateAsync(artwork);
            await _artworkRepository.SaveAsync();
            return artwork;
        }

        public async Task<List<Artwork>> GetAllArtworksAsync()
        {
            return await _artworkRepository.GetAll();
        }

        public async Task<Artwork> GetArtworkByIdAsync(Guid id)
        {
            return await _artworkRepository.FindByIdAsync(id);
        }

        public async Task UpdateArtworkAsync(Artwork artwork)
        {
            _artworkRepository.Update(artwork);
            await _artworkRepository.SaveAsync();
        }

        public async Task DeleteArtworkAsync(Guid id)
        {
            var artwork = await _artworkRepository.FindByIdAsync(id);
            if (artwork != null)
            {
                _artworkRepository.Delete(artwork);
                await _artworkRepository.SaveAsync();
            }
        }
    }
}