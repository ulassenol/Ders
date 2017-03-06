using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinav_03
{
    public class Musteri
    {
        private static int _ID = 0;

        public Musteri()
        {
            ID = _ID++;
        }

        public int ID { get; set; }
        public string adSoyad { get; set; }
        public string TCKN { get; set; }
        public decimal bakiye { get; set; }

        public Kullanici Kullanici { get; set; }
    }
}