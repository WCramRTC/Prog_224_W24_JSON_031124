using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_W24_JSON_031124
{
    public class Track
    {
        string _name;
        int _length;
        DateTime _createdOn;

        public Track(string name, int length)
        {
            Name = name;
            Length = length;
        }

        public string Name { get => _name; set => _name = value; }
        public int Length { get => _length; set => _length = value; }
        public DateTime CreatedOn { get => _createdOn; set => _createdOn = value; }
    }
}
