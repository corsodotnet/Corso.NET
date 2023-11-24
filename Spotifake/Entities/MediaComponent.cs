using Spotifake.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Entities
{
    public class MediaComponent : IMedia
    {
        private Song _song;
#pragma warning disable CS0169 // Il campo 'MediaComponent._length' non viene mai usato
        private int _length;
#pragma warning restore CS0169 // Il campo 'MediaComponent._length' non viene mai usato

        public void Play(Song song)
        {
            _song = song;
        }
    }
}
