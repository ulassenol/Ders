using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_02
{
    class Islem
    {
        public static Kisi KisiEkle()
        {
            Kisi kisi = new Kisi();
            kisi.ad = "Ulaş";
            kisi.soyad = "Şenol";
            kisi.TCKN = "1111111111111";
            kisi.dogumTarih = DateTime.Now;
            kisi.adres = "Teknopark";

            return kisi;
        }

        public static Telefon TelefonEkle(string numara, Kisi kisi)
        {
            Telefon telefon = new Telefon();
            telefon.numara = numara;
            telefon.Kisi = kisi;

            return telefon;
        }
    }
}
