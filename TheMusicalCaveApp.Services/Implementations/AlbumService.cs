using System.Collections.Generic;
using TheMusicalCaveApp.Models.Entities;
using TheMusicalCaveApp.Persistance.Repositories.Interfaces;
using TheMusicalCaveApp.Services.Interfaces;

namespace TheMusicalCaveApp.Services.Implementations
{
    public class AlbumService : IAlbumService
    {
        IAlbumRepository _albumRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public IEnumerable<AlbumEntity> GetAllAlbums()
        {
            return _albumRepository.GetAll();
        }

        public IEnumerable<AlbumEntity> GetFilteredAlbums(string filter)
        {
            return _albumRepository.GetFilteredAlbums(filter);
        }
    }
}
