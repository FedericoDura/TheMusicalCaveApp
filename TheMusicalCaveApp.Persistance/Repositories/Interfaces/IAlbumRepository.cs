using System.Collections.Generic;
using TheMusicalCaveApp.Models.Entities;
using TheMusicalCaveApp.Persistance.Interfaces;

namespace TheMusicalCaveApp.Persistance.Repositories.Interfaces
{
    public interface IAlbumRepository : IRepository<AlbumEntity>
    {
        IEnumerable<AlbumEntity> GetFilteredAlbums(string filter);
    }
}
