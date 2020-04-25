using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class SamochodElektryczny : Samochod
    {
        private double pojemnoscBaterii;
        public void Zatankuj()
        {
            Console.WriteLine("Podłącz do prądu");
        }
    }
}
