using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinav_03
{
    public class Ekle
    {
        public static Yetki Yetki(string ad)
        {
            Yetki yetki = new Yetki();
            yetki.ad = ad;

            Context.Yetkis.Add(yetki);

            return yetki;
        }

        public static Kullanici Kullanici(string adSoyad, string kullaniciAdi, string ePosta, string sifre)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.adSoyad = adSoyad;
            kullanici.ePosta = ePosta;
            kullanici.kullaniciAdi = kullaniciAdi;
            kullanici.sifre = sifre;

            Context.Kullanicis.Add(kullanici);

            return kullanici;
        }

        public static Musteri Musteri(string adSoyad, string TCKN, decimal bakiye)
        {
            Musteri musteri = new Musteri();
            musteri.adSoyad = adSoyad;
            musteri.bakiye = bakiye;
            musteri.TCKN = TCKN;

            Context.Musteris.Add(musteri);

            return musteri;
        }
    }
}