using System.ComponentModel.DataAnnotations.Schema;

namespace TheMusicalCaveApp.Models.Entities
{
    [Table("Tracks")]
    public class TrackEntity : BaseModel
    {
        public int AlbumId { get; set; }
        public virtual AlbumEntity Album { get; set; }
        public string Title { get; set; }
    }
}