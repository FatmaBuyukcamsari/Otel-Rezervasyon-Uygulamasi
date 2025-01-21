using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelrezervasyonyonetimsistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.MaximizeBox = false; // Büyütme düğmesini devre dışı bırak
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Formun boyutunu değiştirilemez hale getir

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmyoneticigiris yonet = new frmyoneticigiris();
            yonet.Show();
            this.Hide();
        }

        private void BtnMusteriGiris_Click(object sender, EventArgs e)
        {
            frmmusterigiris musteri = new frmmusterigiris();
            musteri.Show();
            this.Hide();
        }

      

    }
}
