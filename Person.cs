using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_W24_JSON_031124
{
    public class Person
    {

        string _name;
        int _age;
        Car _car;

        // Default Constuctor
        public Person() { }

        public Person(string name, int age, Car car)
        {
            Name = name;
            Age = age;
            Car = car;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public Car Car { get => _car; set => _car = value; }
    }
}
