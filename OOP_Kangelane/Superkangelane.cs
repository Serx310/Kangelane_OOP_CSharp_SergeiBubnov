using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kangelane
{
    public class Superkangelane : Kangelane
    {
        private static Random r = new Random();
        private double _osavus;

        public Superkangelane(string nimi, string linn) : base(nimi, linn)
        {
            _osavus = r.NextDouble()+r.Next(1, 5);
             
        }

        public override int Päästa(int ohus)
        {
            int päästetud = Convert.ToInt32(ohus * (95 + _osavus) / 100);
            return päästetud;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nLisaks on ta {_osavus}% võrra osavam kui tavakangelane.";
        }
    }
}
