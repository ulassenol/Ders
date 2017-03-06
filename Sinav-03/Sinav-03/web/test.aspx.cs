using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sinav_03.web
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ekle.Yetki("Yönetici");
            Ekle.Yetki("Admin");
            Ekle.Yetki("Yazar");
            Ekle.Yetki("Müşteri");

            List<Yetki> yetkiler = Sinav_03.Context.Yetkis;
        }
    }
}