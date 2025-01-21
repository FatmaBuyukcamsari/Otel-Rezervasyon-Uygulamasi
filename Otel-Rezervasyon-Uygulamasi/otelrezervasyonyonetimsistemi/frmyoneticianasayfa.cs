using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otelrezervasyonyonetimsistemi
{
 

        public partial class frmyoneticianasayfa : Form
    {
        public frmyoneticianasayfa()
        {
            InitializeComponent();

            this.MaximizeBox = false; // Büyütme düğmesini devre dışı bırak
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Formun boyutunu değiştirilemez hale getir

        }

        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU");

        private void musteribilgilerigoster()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from Musteri", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            if (!oku.HasRows)
            {
                MessageBox.Show("Veritabanında görüntülenecek kayıt bulunamadı.");
                baglanti.Close();
                return;
            }

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku.GetValue(0).ToString());
                ekle.SubItems.Add(oku.GetValue(1).ToString());
                ekle.SubItems.Add(oku.GetValue(2).ToString());
                ekle.SubItems.Add(oku.GetValue(3).ToString()); 
                ekle.SubItems.Add(oku.GetValue(4).ToString());
                ekle.SubItems.Add(oku.GetValue(5).ToString());
                ekle.SubItems.Add(oku.GetValue(6).ToString());
                ekle.SubItems.Add(oku.GetValue(7).ToString());
                ekle.SubItems.Add(oku.GetValue(8).ToString());
                ekle.SubItems.Add(oku.GetValue(9).ToString());
                

                listView1.Items.Add(ekle);
                
            }
            
            
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            musteribilgilerigoster();
          
        }
        int id = 0;
        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from Musteri where Adi like '%"+textBox1.Text + "%'" , baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            if (!oku.HasRows)
            {
                MessageBox.Show("Veritabanında görüntülenecek kayıt bulunamadı.");
                baglanti.Close();
                return;
            }

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku.GetValue(0).ToString());
                ekle.SubItems.Add(oku.GetValue(1).ToString());
                ekle.SubItems.Add(oku.GetValue(2).ToString());
                ekle.SubItems.Add(oku.GetValue(3).ToString());
                ekle.SubItems.Add(oku.GetValue(4).ToString());
                ekle.SubItems.Add(oku.GetValue(5).ToString());
                ekle.SubItems.Add(oku.GetValue(6).ToString());
                ekle.SubItems.Add(oku.GetValue(7).ToString());
                ekle.SubItems.Add(oku.GetValue(8).ToString());
                ekle.SubItems.Add(oku.GetValue(9).ToString());


                listView1.Items.Add(ekle);

            }


            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            {         
                string musteriid = listView1.SelectedItems[0].SubItems[0].Text; 
            
                string ad = TxtAdi.Text;
                string soyad = TxtSoyadi.Text;
                string tcKimlikNo = TxtKimlikNo.Text;
                string telefon = MskTxtTelefon.Text;
                string eposta = TxtEposta.Text;
                string odaNo = TxtOdaNo.Text;
                string girisTarihi = DtpGirisTarihi.Value.ToString("yyyy-MM-dd");
                string cikisTarihi = DtpCikisTarihi.Value.ToString("yyyy-MM-dd");
                string ucret = TxtUcret.Text;

               
                string query = "UPDATE Musteri SET Adi = @Adi, Soyadi = @Soyadi, TcKimlikNo = @TcKimlikNo, " +
                               "Telefon = @Telefon, Eposta = @Eposta, OdaNo = @OdaNo, GirisTarihi = @GirisTarihi, " +
                               "CikisTarihi = @CikisTarihi, Ucret = @Ucret WHERE Musteriid = @Musteriid";

             
                using (MySqlConnection conn = new MySqlConnection("Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Adi", ad);
                        cmd.Parameters.AddWithValue("@Soyadi", soyad);
                        cmd.Parameters.AddWithValue("@TcKimlikNo", tcKimlikNo);
                        cmd.Parameters.AddWithValue("@Telefon", telefon);
                        cmd.Parameters.AddWithValue("@Eposta", eposta);
                        cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                        cmd.Parameters.AddWithValue("@GirisTarihi", girisTarihi);
                        cmd.Parameters.AddWithValue("@CikisTarihi", cikisTarihi);
                        cmd.Parameters.AddWithValue("@Ucret", ucret);
                        cmd.Parameters.AddWithValue("@Musteriid", musteriid); 


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.");
                         
                            button1_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız. Lütfen tekrar deneyin.");
                        }
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtEposta.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[9].Text;
            

        }

        private void BtnİptalEt_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            MySqlCommand Komut = new MySqlCommand("delete from Musteri where Musteriid=(" + id + ")", baglanti);
            Komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervsayon İptal Edildi.");




            listView1.Items.Clear();
            string query = "SELECT * FROM Musteri"; 
            using (MySqlConnection conn = new MySqlConnection("Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Musteriid"].ToString());
                    item.SubItems.Add(reader["Adi"].ToString());
                    item.SubItems.Add(reader["Soyadi"].ToString());
                    item.SubItems.Add(reader["TcKimlikNo"].ToString());
                    item.SubItems.Add(reader["Telefon"].ToString());
                    item.SubItems.Add(reader["Eposta"].ToString());
                    item.SubItems.Add(reader["OdaNo"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["GirisTarihi"]).ToShortDateString());
                    item.SubItems.Add(Convert.ToDateTime(reader["CikisTarihi"]).ToShortDateString());
                    item.SubItems.Add(reader["Ucret"].ToString());
                    listView1.Items.Add(item);
                }

         

            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();  
            TxtSoyadi.Clear();
            MskTxtTelefon.Clear();
            TxtKimlikNo.Clear();
            TxtEposta.Text = "";
            TxtOdaNo.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            TxtUcret.Clear();
            
         

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmyoneticigiris menu2 = new frmyoneticigiris();
            menu2.Show();
            this.Hide();
        }

    }
}
