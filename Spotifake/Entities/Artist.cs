using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Entities
{
    internal class Artist : Person
    {
        string _name;
        int _id;
        List<Album> _albums;
        List<Artist> _artists;
        Group _group;

        public Artist(string name, string surname, Group group, string data) : base(name, surname, data)
        {
            this._id = Id;
            this._group = group;
            this._albums = new List<Album>();
            this._artists = new List<Artist>();
        }

        //mostra tutti album artista

        public string Name { get => _name; set => _name = value; }
        internal List<Album> Albums { get => _albums; set => _albums = value; }
        internal List<Artist> Artists { get => _artists; set => _artists = value; }
        internal Group Group { get => _group; set => _group = value; }
    }
}
