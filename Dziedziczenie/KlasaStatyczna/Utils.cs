using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.KlasaStatyczna
{
    static class Utils
    {
        public static string hostname = "localhost";
        public static int portNumber = 3306;

        //metoda z dowolną liczbą argumentów, tez musi byc static!
        public static int GetMaxValue(params int[] args)
        {
            return args.Max();
        }
    }
}
