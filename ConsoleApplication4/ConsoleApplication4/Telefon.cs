using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Telefon
    {
        protected string model;
        protected double cena;

        public void WypiszInfo()
        {
            Console.WriteLine("Model: {0}\nCena: {1}", model, cena);
        }

        public Telefon()
        {

        }

        public Telefon(string model, double cena)
        {
            this.model = model;
            this.cena = cena;
        }
    }
}
