using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Seniorfon : Telefon
    {
        private bool duzePrzyciski;
        
        public Seniorfon()
        {

        }

        public Seniorfon(string model, bool duzeprzyciski)
        {
            this.model = model;
            this.duzePrzyciski = duzeprzyciski;
        }

        public void ObliczCene()
        {
            this.cena = 100;
        }
    }
}
