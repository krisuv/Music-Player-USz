using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz_muzyki
{
    public class Player : IPlayer
    {

        public List<ISong> Songs { get; set; }        
        public List<ISong> ListeningHistory { get; set; }

        private int startVolumeLevel;
        public int VolumeLevel { get; set;}
        public ISong currentSong { get; set; }

        public TimeSpan TotalRecordTime
        {
            get
            {
                TimeSpan total = new TimeSpan();
                foreach (ISong song in Songs)
                {
                    total += song.SongTime;
                };
                return total;
            }
        }

        public void modifyPlaylist(ISong song, songOptions option)
        {
            if (option == songOptions.add)
            {
                Songs.Add(song);
            }
            else if (option == songOptions.delete)
            {
                Songs.Remove(song);
            }
        }

        public void changeSong(ISong currentSong, playerOption option, ISong otherSong)
        {
            throw new NotImplementedException();
        }

        public void changeVolume(soundOption option)
        {
            if (option == soundOption.tuneUp && VolumeLevel < 100)
            {
                VolumeLevel++;
            }
            else if (option == soundOption.tuneDown && VolumeLevel >= 0){
                VolumeLevel--;
            }
            else
            {
                Console.WriteLine("Osiągnięto już minimalny/maksymalny poziom głośności!");
            }
        }


        public void playSelectedSong(ISong song)
        {
            throw new NotImplementedException();
        }

        public void setVolumeLevel(int volumeLevel)
        {
            if(volumeLevel >= 0 && volumeLevel <= 100)
            {
                VolumeLevel = volumeLevel;
            }
            else
            {
                Console.WriteLine("Podano poziom głośności spoaza zakresu 0-100!");
            };
        }


        // Praca z plikami
        public void savePlaylist(List<ISong> songs)
        {
            throw new NotImplementedException();
        }
        public void loadPlaylist(string file)
        {
            throw new NotImplementedException();
        }
    }
}
