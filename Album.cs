using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_W24_JSON_031124
{
    public class Album
    {
        string _name;
        int _year;
        List<Track> _tracks;

        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Tracks = new List<Track>();
        }

        public string Name { get => _name; set => _name = value; }
        public int Year { get => _year; set => _year = value; }
        public List<Track> Tracks { get => _tracks; set => _tracks = value; }

        public void AddTrack(Track track)
        {
            _tracks.Add(track);
        }

        public void DisplayTracks()
        {
            foreach (Track track in _tracks)
            {
                Console.WriteLine("\t\t\t");
                Console.WriteLine($"{track.Name} : Length: {track.Length}");
            }
        }
    }
}
