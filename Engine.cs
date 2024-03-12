using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_W24_JSON_031124
{
    public class Engine
    {
        int _hp;

        public Engine(int hp)
        {
            Hp = hp;
        }

        public int Hp { get => _hp; set => _hp = value; }
    }
}
