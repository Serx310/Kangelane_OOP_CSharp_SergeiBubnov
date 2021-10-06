using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kangelane
{
    public class Superkangelane : Kangelane
    {
        private double _osavus;

        public Superkangelane(string nimi, string linn, double osavus) : base(nimi, linn)
        {
            Random r = new Random();
            osavus = r.Next(1, 5);
            _osavus = osavus;
        }

        public override int Päästa(int ohus)
        {
            int päästetud = ohus * ((95+Convert.ToInt32(_osavus))/100);
            return päästetud;
        }

        public override string toString()
        {
            return $"{_nimi}, {_osavus}";
        }
    }
}
