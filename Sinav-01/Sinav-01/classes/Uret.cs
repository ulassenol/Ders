using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_01
{
    class Uret
    {
        private const int xAltSinir = 0;
        private const int xUstSinir = 10;
        private const int yAltSinir = 0;
        private const int yUstSinir = 10;

        private static readonly Random random = new Random();

        public static int x()
        {
            int x = random.Next(xAltSinir, xUstSinir);

            return x;
        }

        public static int y()
        {
            int y = random.Next(yAltSinir, yUstSinir);

            return y;
        }
    }
}
