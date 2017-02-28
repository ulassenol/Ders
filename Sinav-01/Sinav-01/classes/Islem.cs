using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_01
{
    class Islem
    {
        public static double Fonksiyon(int x, int y)
        {
            double sonuc = Math.Pow(x, 2) + 3 * Math.Sqrt(y);

            return sonuc;
        }
    }
}
