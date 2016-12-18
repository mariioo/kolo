using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Smartfon : Telefon
    {
        private bool gps;
        private double rozmiarWyswietlacza;

        public Smartfon()
        {

        }

        public Smartfon(string model, bool gps, double rozmiar)
        {
            this.model = model;
            this.gps = gps;
            this.rozmiarWyswietlacza = rozmiar;
        }

        public void obliczCene()
        {
            this.cena = rozmiarWyswietlacza * 218;
        }
    }
}
