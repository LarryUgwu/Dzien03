using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Kwadrat : Prostokat
    {
        public Kwadrat(double bok) : base(bok, bok)
        {
            Console.WriteLine("Konstruktor klasy kwadrat");
        }

        public bool CzyKwadrat() //jesli zrobimy te samą metodę co u przodka, to przyslaniamy metodę przodka
        {
            return true;
            // return base.CzyKwadrat(); wywołujemy metodę z przodka
        }
    }
}
