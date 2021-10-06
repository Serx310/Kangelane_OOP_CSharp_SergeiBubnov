using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kangelane
{
    public class Kangelane
    {
        protected string _nimi;
        protected string _linn;
        public Kangelane(string nimi, string linn)
        {
            _nimi = nimi;
            _linn = linn;
        }


        virtual public int Päästa(int ohus)
        {
            return Convert.ToInt32(ohus*0.95);
        }

        virtual public string toString()
        {
            return _nimi.ToString();
        }

        //Getter
        public string GetName() { return _nimi; }
        public string GetCity() { return _linn; }
        //Setter
        public void SetX(string uusNimi) { _nimi = uusNimi; }
        public void SetY(string uusLinn) { _linn = uusLinn; }
    }
}
