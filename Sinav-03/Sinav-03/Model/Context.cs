using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinav_03
{
    public class Context
    {
        private static List<Yetki> _Yetkis;

        public Context()
        {
            Yetkis = new List<Yetki>();
            Kullanicis = new List<Kullanici>();
            Musteris = new List<Musteri>();
        }

        public static List<Kullanici> Kullanicis { get; set; }
        public static List<Musteri> Musteris { get; set; }

        public List<Yetki> Yetkis
        {
            get
            {
                return _Yetkis;
            }

            set
            {
                _Yetkis = value;
            }
        }
    }
}