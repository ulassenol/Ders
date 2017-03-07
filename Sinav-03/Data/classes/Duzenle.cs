using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Duzenle
    {
        public static bool Yetki(int yetkiID, string yeniAd)
        {
            bool sonuc = false;

            Context ctx = new Context();

            Yetki yetki = ctx.Yetkis.SingleOrDefault(x => x.yetkiID == yetkiID);

            if (yetki != null)
            {
                yetki.ad = yeniAd;

                sonuc = true;
            }

            return sonuc;
        }

        public static bool Kullanici(int kullaniciID, string yeniAdSoyad)
        {
            bool sonuc = false;

            Context ctx = new Context();

            Kullanici kullanici = ctx.Kullanicis.SingleOrDefault(x => x.kullaniciID == kullaniciID);

            if (kullanici != null)
            {
                kullanici.adSoyad = yeniAdSoyad;

                sonuc = true;
            }

            return sonuc;
        }

        public static bool Musteri(int musteriID, string yeniSifre)
        {
            bool sonuc = false;

            Context ctx = new Context();

            Musteri musteri = ctx.Musteris.SingleOrDefault(x => x.musteriID == musteriID);

            if (musteri != null)
            {
                musteri.Kullanici.sifre = yeniSifre;

                sonuc = true;
            }

            return sonuc;
        }
    }
}