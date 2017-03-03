using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program çalıştığında tüm nesneler sıfırlanır
            Kisi kisi = new Kisi();
            Telefon telefon = new Telefon();

            kisi = Islem.KisiEkle(); // Yeni bir kişi oluşturuldu

            telefon = Islem.TelefonEkle("123456", kisi); // Kişiye bağlı telefon oluşturuldu
            kisi.Telefons.Add(telefon); // Kişiye bağlı telefonlar listemize, oluşturduğumuz telefon nesnemizi ekledik

            telefon = Islem.TelefonEkle("456789", kisi);
            kisi.Telefons.Add(telefon);

            telefon = Islem.TelefonEkle("987654", kisi);
            kisi.Telefons.Add(telefon);

            // Telefonlar listemizdeki elemanlara tek tek eriştik
            foreach (Telefon tel in kisi.Telefons)
            {
                Console.WriteLine("Telefon : " + tel.ID + " - " + tel.numara + ";\t\t Kisi : " + tel.Kisi.ID + " - " + tel.Kisi.ad + " " + tel.Kisi.dogumTarih);
            }

            Console.ReadLine();
        }
    }
}
