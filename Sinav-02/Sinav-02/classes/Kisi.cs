using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_02
{
    class Kisi
    {
        private static int _ID;

        public Kisi()
        {
            ID = _ID++;
            Telefons = new List<Telefon>();
        }

        public int ID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string TCKN { get; set; }
        public DateTime dogumTarih { get; set; }
        public string adres { get; set; }

        public List<Telefon> Telefons { get; set; }


        //1 Ulaş Şenol 111111 11.11.1111 adres
        //2 Ozan Şenol 111111 11.11.1111 adres
        //3 Cuma Şenol 111111 11.11.1111 adres
        //4 Eren Şenol 111111 11.11.1111 adres
    }
}
