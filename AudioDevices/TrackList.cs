using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioDevices
{
    public class TrackList
    {
        private List<Track> tracks;

        public TrackList()
        {
            this.tracks = new List<Track>();
        }

        public TrackList(List<Track> tracks)
        {
            this.tracks = tracks;
        }

        public void Add(Track newTrack)
        {
            tracks.Add(newTrack);
        }

        public void Remove(Track oldTrack)
        {
            tracks.Remove(oldTrack);
        }
        public void Clear()
        {
            tracks.Clear();
        }

        public List<Track> GetAllTracks()
        {
            return tracks;
        }

        public List<Track> Shuffle()
        {
            List<Track> temp = new List<Track>();
            foreach (var track in tracks)
            {
                temp.Add(track);
            }
            List<Track> shuffled = new List<Track>();
            Random r = new Random();
            while (temp.Count > 0)
            {
                int randomNumber = r.Next(temp.Count);
                shuffled.Add(temp[randomNumber]);
                temp.RemoveAt(randomNumber);
            }
            return shuffled;
        }

        public int Count
        {
            get { return tracks.Count; }
        }

        public Time TotalTime
        {
            get
            {
                int seconds = 0;
                foreach (var item in tracks)
                {
                    seconds += item.GetLengthInSeconds();
                }
                return new Time(seconds);
            }
        }
    }


}