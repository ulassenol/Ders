using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_02
{
    class Telefon
    {
        private static int _ID; 

        public Telefon()
        {
            ID = _ID++;
        }

        public int ID { get; set; }
        public string numara { get; set; }
        public int kisiID { get; set; }

        public virtual Kisi Kisi { get; set; }


        // 11111111 1
        // 11111112 1
        // 11111113 4
        // 11111114 1
        // 11111115 2
        // 11111116 2
    }
}
