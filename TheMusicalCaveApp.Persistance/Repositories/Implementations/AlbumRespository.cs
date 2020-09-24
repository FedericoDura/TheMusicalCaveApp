using System.Collections.Generic;
using System.Linq;
using TheMusicalCaveApp.Models.Entities;
using TheMusicalCaveApp.Persistance.Context;
using TheMusicalCaveApp.Persistance.Repositories.Interfaces;

namespace TheMusicalCaveApp.Persistance.Repositories.Implementations
{
    public class AlbumRespository: IAlbumRepository
    {
        private AppDbContext _context;

        public AlbumRespository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<AlbumEntity> GetAll()
        {
            return _context.Albums.ToList();
        }

        public IEnumerable<AlbumEntity> GetFilteredAlbums(string filter)
        {
            return _context.Albums.Where(x => x.Title.Contains(filter));
        }
    }
}
