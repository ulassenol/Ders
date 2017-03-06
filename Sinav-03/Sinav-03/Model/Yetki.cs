using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinav_03
{
    public class Yetki
    {
        private static int _ID = 0;

        public Yetki()
        {
            ID = _ID++;
        }

        public int ID { get; set; }
        public string ad { get; set; }

        public List<Kullanici> Kullanicis { get; set; }

        //public YetkiKullanici YetkiKullanici { get; set; }
    }
}