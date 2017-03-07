using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Context
    {
        private static List<Yetki> _Yetkis = new List<Yetki>();
        private static List<Kullanici> _Kullanicis = new List<Kullanici>();
        private static List<Musteri> _Musteris = new List<Musteri>();

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

        public List<Kullanici> Kullanicis
        {
            get
            {
                return _Kullanicis;
            }

            set
            {
                _Kullanicis = value;
            }
        }

        public List<Musteri> Musteris
        {
            get
            {
                return _Musteris;
            }

            set
            {
                _Musteris = value;
            }
        }
    }
}