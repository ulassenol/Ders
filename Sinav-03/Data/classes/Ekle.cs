using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Ekle
    {
        public static Yetki Yetki(string ad)
        {
            Context ctx = new Context();

            Yetki yetki = new Yetki();
            yetki.ad = ad;

            ctx.Yetkis.Add(yetki);

            return yetki;
        }

        public static Kullanici Kullanici(string adSoyad, string kullaniciAdi, string ePosta, string sifre, string istenilenYetki)
        {
            Context ctx = new Context();

            Kullanici kullanici = new Kullanici();
            kullanici.adSoyad = adSoyad;
            kullanici.ePosta = ePosta;
            kullanici.kullaniciAdi = kullaniciAdi;
            kullanici.sifre = sifre;

            Yetki yetki = ctx.Yetkis.FirstOrDefault(x => x.ad == istenilenYetki);

            if (yetki != null)
            {
                kullanici.Yetkis.Add(yetki);

                ctx.Kullanicis.Add(kullanici);

                yetki.Kullanicis.Add(kullanici);

                return kullanici;
            }
            else
            {
                return null;
            }

        }

        public static Musteri Musteri(string TCKN, decimal bakiye, Kullanici kullanici)
        {
            if (kullanici == null)
            {
                return null;
            }
            else
            {
                Context ctx = new Context();

                Musteri musteri = new Musteri();
                musteri.bakiye = bakiye;
                musteri.TCKN = TCKN;
                musteri.Kullanici = kullanici;

                ctx.Musteris.Add(musteri);

                return musteri;
            }
        }
    }
}