using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMusicApplication
{
    internal class Album
    {
        public int ID { get; set; }
        public String AlbumTitle { get; set; }
        public String ArtistTitle { get; set; }
        public int YearRelease { get; set; }
        public String ImageLink { get; set; }
        public String Summary { get; set; }

        //Making a List<Track>
        public List<Track> Tracks { get; set; }
     }
}
