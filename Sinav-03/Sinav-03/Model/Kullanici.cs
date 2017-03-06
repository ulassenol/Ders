using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinav_03
{
    public class Kullanici
    {
        private static int _ID = 0;

        public Kullanici()
        {
            ID = _ID++;
        }

        public int ID { get; set; }
        public string adSoyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string ePosta { get; set; }
        public string sifre { get; set; }

        public List<Yetki> Yetkis { get; set; }

        //public YetkiKullanici YetkiKullanici { get; set; }
    }
}