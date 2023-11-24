using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Entities
{
    public class Song
    {
        public string title;
        public int _lentgth;
#pragma warning disable CS0169 // Il campo 'Song.artists' non viene mai usato
        private List<Artist> artists;
#pragma warning restore CS0169 // Il campo 'Song.artists' non viene mai usato
#pragma warning disable CS0169 // Il campo 'Song.albums' non viene mai usato
        private List<Album> albums;
#pragma warning restore CS0169 // Il campo 'Song.albums' non viene mai usato
#pragma warning disable CS0169 // Il campo 'Song._group' non viene mai usato
        private List<Group> _group;
#pragma warning restore CS0169 // Il campo 'Song._group' non viene mai usato
#pragma warning disable CS0649 // Non è possibile assegnare un valore diverso al campo 'Song._songs'. Il valore predefinito è null
        private List<Song> _songs;
#pragma warning restore CS0649 // Non è possibile assegnare un valore diverso al campo 'Song._songs'. Il valore predefinito è null

        public Song(string name)
        {
            title = name;
        }
        public void Add(Song song) 
        {
            _songs.Add(song);
        }
        public void CreateSong(Song song) 
        {
            Song newSong = new Song(newSong);
        }
    }
}
