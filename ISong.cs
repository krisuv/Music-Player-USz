using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz_muzyki
{
    public interface ISong
    {
        string Title { get; set; }
        string Artist { get; set; }
        string SongName { get; set; }
        TimeSpan SongTime { get; set; }
    }
}
