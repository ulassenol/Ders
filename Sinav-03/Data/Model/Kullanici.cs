using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Kullanici
    {
        private static int _kullaniciID = 0;

        public Kullanici()
        {
            kullaniciID = _kullaniciID++;
            Yetkis = new List<Yetki>();
        }

        public int kullaniciID { get; set; }
        public string adSoyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string ePosta { get; set; }
        public string sifre { get; set; }

        public List<Yetki> Yetkis { get; set; }

        //public YetkiKullanici YetkiKullanici { get; set; }
    }
}