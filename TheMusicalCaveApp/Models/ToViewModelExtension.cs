using System.Collections.Generic;
using System.Linq;
using TheMusicalCaveApp.Models.Entities;

namespace TheMusicalCaveApp.Web.Models
{
    public static class ToViewModelExtension
    {
        public static IEnumerable<Album> ToViewModel(this IEnumerable<AlbumEntity> albumEntities)
        {
            return albumEntities.Select(album => ToViewModel(album)).ToList();
        }

        public static Album ToViewModel(this AlbumEntity albumEntity)
        {
            return new Album
            {
                Title = albumEntity.Title,
                Tracks = albumEntity.Tracks.Select(track => new Track() {
                    Title = track.Title
                }).ToList()
            };
        }            
    }
}