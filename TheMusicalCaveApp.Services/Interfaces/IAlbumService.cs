using System.Collections.Generic;
using TheMusicalCaveApp.Models.Entities;

namespace TheMusicalCaveApp.Services.Interfaces
{
    public interface IAlbumService
    {
        IEnumerable<AlbumEntity> GetAllAlbums();
        IEnumerable<AlbumEntity> GetFilteredAlbums(string filter);
    }
}
