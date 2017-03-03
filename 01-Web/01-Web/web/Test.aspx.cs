using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_Web
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Kisi> kisis = new List<Kisi>();

            for (int i = 1; i <= 10; i++)
            {
                Kisi kisi = new Kisi();
                kisi.kisiID = i;
                kisi.ad = "Ulaş";
                kisi.soyad = "Şenol";
                kisi.tarih = DateTime.Now;

                kisis.Add(kisi);
            }

            rptKisiler.DataSource = kisis;
            rptKisiler.DataBind();
        }
    }
}