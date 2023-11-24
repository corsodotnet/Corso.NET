using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Entities
{
    public class User : Person
    {
        string _username;
        string _password;
        List <Song> _favouriteSongs;
        List<Playlist> _playlist; 
        List<Radio> _radio;
        Setting _setting;

        public User(string username, string password,string UserName, Setting setting, string name, string surname, string birthDate)
            :base(name, surname, birthDate)
        {
            this._username = username;
            this._password = password;
            this._setting = setting;
            this._playlist = new List<Playlist>();
            this._favouriteSongs = new List<Song>();
            this._radio = new List<Radio>();
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public List<Song> FavouriteSongs { get => _favouriteSongs; set => _favouriteSongs = value; }
        internal List<Radio> Radio { get => _radio; set => _radio = value; }
        internal List<Playlist> Playlist { get => _playlist; set => _playlist = value; }

        public void CreatePlaylist(Playlist playlist)
        {
            _playlist.Add(playlist);
            playlist.User = this;  // RIGUARDALO BENE
            Console.WriteLine($"Playlist : {playlist.Name} created");
        }
        public void DeletePlaylist(Playlist playlist)
        {
            _playlist.Remove(playlist);
            playlist.User = null;
            Console.WriteLine($"Playlist : {playlist.Name} removed");
        }
        public void AddSongPlaylist(Song song, string playlistName)
        {
            Playlist playlist = GetPlaylist(playlistName);
            if (playlist != null)
            {
                playlist.AddSong(song);
                Console.WriteLine($"Song: {song.title} added to playlist: {playlist.Name});
            }
            else
                Console.WriteLine("Errore");
        }
        private Playlist GetPlaylist(string name)
        {
            Playlist playlist = _playlist.Find(x => x.Name == name);
            if (playlist == null)
                return playlist;
            else
                return null;
        }
    }
    
}
