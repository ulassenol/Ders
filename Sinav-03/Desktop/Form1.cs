using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            #region Ekle Kısımları
            Ekle.Yetki("Yönetici");
            Ekle.Yetki("Admin");
            Ekle.Yetki("Yazar");
            Ekle.Yetki("Müşteri");
            Ekle.Yetki("Diğer");

            Kullanici ulas = Ekle.Kullanici("Baran Ulaş", "ulas", "u@u.com", "uuu", "Yazar");
            Kullanici ozan = Ekle.Kullanici("Ozan Cem", "ozan", "o@o.com", "ooo", "");
            Kullanici cuma = Ekle.Kullanici("Cuma Özgün", "cuma", "c@c.com", "ccc", "");
            Kullanici eren = Ekle.Kullanici("Eren Saygılı", "eren", "e@e.com", "eee", "Yönetici");
            Kullanici kotu = Ekle.Kullanici("Halil Engin", "kötü", "k@k.com", "kkk", "Yönetici");
            Kullanici hamit = Ekle.Kullanici("Hamit Kaya", "hamit", "h@h.com", "hhh", "Yönetici");
            Kullanici seyma = Ekle.Kullanici("Şeyma Durak", "şeyma", "ş@ş.com", "şşş", "Admin");

            Ekle.Musteri("11111111111", 0, ulas);
            Ekle.Musteri("2222222222", 100, ozan);
            Ekle.Musteri("3333333333", 1000, cuma);
            #endregion


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context ctx = new Context();

            dgvKullanici.DataSource = ctx.Kullanicis;
        }
    }
}
