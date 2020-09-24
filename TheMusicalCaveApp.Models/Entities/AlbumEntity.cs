using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheMusicalCaveApp.Models.Entities
{
    [Table("Albums")]
    public class AlbumEntity : BaseModel
    {
        public string Title { get; set; }
        public virtual ICollection<TrackEntity> Tracks { get; set; }
    }
}