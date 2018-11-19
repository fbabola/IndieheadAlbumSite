using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAlbumSite.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearCreated { get; set; }
        public List<Album> AlbumsMade { get; set; }
        public int NumViews { get; set; }
    }
}