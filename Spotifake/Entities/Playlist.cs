using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Entities
{
    public class Playlist
    {
        User _user;
        string _name;
        List<Song> _playlist;

        public Playlist(string name)
        {
            _name = name;
            // QUAN CREO SOLO IL RIFERIMENTO ALLA LISTA MA NON PASSSO NULLA
            _playlist = new List<Song>();
        }

        public User User { get => _user; set => _user = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Song> playlist { get => _playlist; set => _playlist = value; }

        public void AddSong(Song song)
        {
             _playlist.Add(song);
        }
        public void RemoveSong(Song song)
        {
             _playlist.Remove(song);
        }

    }
}
