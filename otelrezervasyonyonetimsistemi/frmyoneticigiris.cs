using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelrezervasyonyonetimsistemi
{
    public partial class frmyoneticigiris : Form
    {
        public frmyoneticigiris()
        {
            InitializeComponent();


            this.MaximizeBox = false; // Büyütme düğmesini devre dışı bırak
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Formun boyutunu değiştirilemez hale getir

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAdi.Text=="admin" && TxtSifre.Text=="0123456789")
            {
                frmyoneticianasayfa yoneticisayfa = new frmyoneticianasayfa();
                yoneticisayfa.Show();
                this.Hide();               
            }
           else
           {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }
}