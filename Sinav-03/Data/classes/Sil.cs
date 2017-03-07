using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Sil
    {
        public static bool Yetki(int yetkiID)
        {
            bool sonuc = false;

            Context ctx = new Context();

            Yetki yetki = ctx.Yetkis.SingleOrDefault(x => x.yetkiID == yetkiID);

            if (yetki != null)
            {
                if (yetki.Kullanicis.Count == 0)
                {
                    ctx.Yetkis.Remove(yetki);

                    sonuc = true;
                }
                else
                {
                    sonuc = false;
                }
            }

            return sonuc;
        }

        public static bool Kullanici(int kullaniciID)
        {
            bool sonuc = false;

            Context ctx = new Context();

            Kullanici kullanici = ctx.Kullanicis.SingleOrDefault(x => x.kullaniciID == kullaniciID);

            if (kullanici != null)
            {
                ctx.Kullanicis.Remove(kullanici);

                sonuc = true;
            }

            return sonuc;
        }

        public static bool Musteri(int musteriID)
        {
            bool sonuc = false;

            Context ctx = new Context();

            Musteri musteri = ctx.Musteris.SingleOrDefault(x => x.musteriID == musteriID);

            if (musteri != null)
            {
                ctx.Kullanicis.Remove(musteri.Kullanici);

                ctx.Musteris.Remove(musteri);

                sonuc = true;
            }

            return sonuc;
        }
    }
}