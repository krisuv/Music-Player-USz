using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz_muzyki
{
    public class Song : ISong
    {
        public string Title { get; set; }
        public string Artist { get; set; }  
        public string SongName { get; set; }
        public TimeSpan SongTime { get; set; }
    }
}
