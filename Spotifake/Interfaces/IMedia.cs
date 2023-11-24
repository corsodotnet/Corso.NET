using Spotifake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Interfaces
{
    public interface IMedia
    {
        public void Play(string title);
        public void Stop();
        public void Pause();
        public void NextSong(User user);
        public PreviousSong(User user);
    }
}
