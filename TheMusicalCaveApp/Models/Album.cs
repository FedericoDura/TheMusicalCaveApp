using System.Collections.Generic;

namespace TheMusicalCaveApp.Web.Models
{
    public class Album
    {        
        public string Title { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
    }
}