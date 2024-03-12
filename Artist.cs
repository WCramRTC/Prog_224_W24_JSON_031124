using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_W24_JSON_031124
{
    public class Artist
    {
        string _name;
        List<Album> _albums;

        public Artist(string name)
        {
            Name = name;
            Albums = new List<Album>();
        }

        public string Name { get => _name; set => _name = value; }
        public List<Album> Albums { get => _albums; set => _albums = value; }

        public void DisplayAlbums()
        {
            foreach (Album album in _albums)
            {
                Console.WriteLine("\t\t");
                Console.WriteLine(album.Name);
                Console.WriteLine("Tracks");
                album.DisplayTracks();

            }
        }

    }
}
