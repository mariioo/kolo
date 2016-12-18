using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartfon smart1 = new Smartfon("Samsung", true, 4.7);
            Seniorfon senior1 = new Seniorfon("LG", true);
            smart1.obliczCene();
            senior1.ObliczCene();
            Console.WriteLine("Info o smartfonie 1: ");
            smart1.WypiszInfo();
            Console.WriteLine("\nInfo o seniorfonie 1: ");
            senior1.WypiszInfo();
            Console.ReadKey();
        }
    }
}
