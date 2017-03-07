using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Yetki
    {
        private static int _yetkiID = 0;

        public Yetki()
        {
            yetkiID = _yetkiID++;
            Kullanicis = new List<Kullanici>();
        }

        public int yetkiID { get; set; }
        public string ad { get; set; }

        public List<Kullanici> Kullanicis { get; set; }

        //public YetkiKullanici YetkiKullanici { get; set; }
    }
}