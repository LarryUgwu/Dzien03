using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Samochod
    {
        //pola klasy
        private string marka;
        private int predkoscMax;

        //deklaracja właściwosci klasy (property) 
        public int Predkosc {
            get { return predkoscMax; }
            set {
                if ( value <= 0)
                {
                    Console.WriteLine("Prędkość >=0");
                }
                else
                {
                    predkoscMax = value; }
            }
        }

        public int LiczbaDrzwi { get; set; }

        //dostep do klasy (konstrukctor)
        public Samochod(string marka, int predkosc)
        {
            this.marka = marka; //dlatego this, bo pole klasy ma te sama nazwe co konstruktor
            predkoscMax = predkosc;
        }
        /// <summary>
        /// Metoda zmienia prędkość maksymalną
        /// </summary>
        /// <param name="predkosc">nowa predkosc maksymalna</param>
        public void UstawPredkoscMax(int predkosc)
        {
            predkoscMax = predkosc;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }
    }
}
