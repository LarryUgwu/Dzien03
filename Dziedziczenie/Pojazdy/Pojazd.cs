using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class Pojazd : IPojazd
    {
        protected int liczbaKol;
        protected int liczbaDrzwi;
        protected int predkoscMax;
        protected bool czySilnikowy;

        public void Uruchom()
        {
            throw new NotImplementedException();
        }

        public void Zatankuj()
        {
            throw new NotImplementedException();
        }

        public void Zatrzymaj()
        {
            throw new NotImplementedException();
        }
    }
}
