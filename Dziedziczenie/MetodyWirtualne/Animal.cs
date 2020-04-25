using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.MetodyWirtualne
{
    class Ssak
    {
        public void Karmienie()
        {
            Console.WriteLine("Operacja karmienia");
        }
    }

    class Kot : Ssak
    {
        public new void Karmienie()
        {
            Console.WriteLine("Kot - karmienie");
        }

        public override string ToString() //metoda wirtualna 
        {
            return "obiekt klasy kot";
        }
    }
}
