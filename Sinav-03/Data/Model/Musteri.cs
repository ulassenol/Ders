using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Musteri
    {
        private static int _musteriID = 0;

        public Musteri()
        {
            musteriID = _musteriID++;
        }

        public int musteriID { get; set; }
        public string TCKN { get; set; }
        public decimal bakiye { get; set; }

        public Kullanici Kullanici { get; set; }
    }
}