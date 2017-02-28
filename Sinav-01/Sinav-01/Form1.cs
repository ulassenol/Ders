using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Denklem> list = new List<Denklem>();

            for (int i = 0; i < 100; i++)
            {
                Denklem denklem = new Denklem();
                denklem.ID = i;
                denklem.x = Uret.x();
                denklem.y = Uret.y();
                denklem.sonuc = Islem.Fonksiyon(denklem.x, denklem.y);

                list.Add(denklem);
            }

            dgvIlk.DataSource = list;

            dgvDescSonuc.DataSource = list.OrderByDescending(x => x.sonuc).ToList();

            dgvASCSonuc.DataSource = list.OrderBy(x => x.sonuc).Take(10).ToList();



            //int[] x = new int[100];
            //int[] y = new int[100];
            //double[] sonuc = new double[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    Uret uret = new Uret();
            //    Islem islem = new Islem(); 

            //    x[i] = uret.x();
            //    y[i] = uret.y();
            //    sonuc[i] = islem.Fonksiyon(x[i], y[i]);
            //}
        }
    }
}
