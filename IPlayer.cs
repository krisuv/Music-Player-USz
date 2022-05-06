using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz_muzyki
{
    public enum soundOption { tuneUp, tuneDown, reset };
    public enum playerOption { previous, next};
    public enum songOptions { add, delete };



    public interface IPlayer
    {
        List<ISong> Songs { get; set; }
        List<ISong> ListeningHistory { get; set; }
        TimeSpan TotalRecordTime { get; }
        int VolumeLevel { get; set; }
        ISong currentSong { get; set; }
        void modifyPlaylist(ISong song, songOptions option);
        void changeVolume(soundOption option);
        void setVolumeLevel (int volumeLevel);
        void playSelectedSong (ISong song);
        void loadPlaylist(string file);
        void savePlaylist(List<ISong> songs);
        void changeSong (ISong currentSong, playerOption option, ISong otherSong);

    }
}
