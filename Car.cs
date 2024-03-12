using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_224_W24_JSON_031124
{
    public class Car
    {
        string _make;
        string _model;
        int _year;
        double _mileage;
        Engine _engine;

        public Car() { }

        public Car(string make, string model, int year, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public double Mileage { get => _mileage; set => _mileage = value; }
        public Engine Engine { get => _engine; set => _engine = value; }
    }
}
