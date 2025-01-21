using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace otelrezervasyonyonetimsistemi
{
    public partial class frmmusterigiris : Form
    {

        private string GetRoomStatus(string odaNo)
        {
            string durum = "Boş"; // Varsayılan olarak oda boş kabul edilir.
            string connectionString = "Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU";

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();

                // Odadan durumu alacak SQL sorgusu
                string query = "SELECT OdaDurumu FROM Odalar WHERE OdaNo = @OdaNo";
                MySqlCommand komut = new MySqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@OdaNo", odaNo);

                object result = komut.ExecuteScalar(); // Tek bir değer almak için ExecuteScalar kullanıyoruz.

                if (result != null)
                {
                    durum = result.ToString();
                }

                baglanti.Close();
            }

            return durum;
        }





        public frmmusterigiris()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.frmmusterigiris_Load);

            this.MaximizeBox = false; // Büyütme düğmesini devre dışı bırak
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Formun boyutunu değiştirilemez hale getir

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






        private bool roomSelected = false;
 

        private void BtnOda401_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "401";
                HesaplaUcret();
                selectedRoomNo = 401;
                MessageBox.Show("Oda 401 seçildi.");
                BtnOda401.BackColor = Color.MistyRose;
                BtnOda401.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
            else if (selectedRoomNo == 401) 
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda401.BackColor = Color.Honeydew;
                BtnOda401.Text = "401";
               
                ButonKontrol2();
                ButonKontrolUltra();

            }

        }

        private void BtnOda402_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "403";
                HesaplaUcret();
                selectedRoomNo = 403;
                MessageBox.Show("Oda 403 seçildi.");
                BtnOda403.BackColor = Color.MistyRose;
                BtnOda403.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
           else if (selectedRoomNo == 403)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda403.BackColor = Color.Honeydew;
                BtnOda403.Text = "403";
                ButonKontrol2();
                ButonKontrolUltra();
            }
        }

        private void BtnOda403_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "403";
                HesaplaUcret();
                selectedRoomNo = 403;
                MessageBox.Show("Oda 403 seçildi.");
                BtnOda403.BackColor = Color.MistyRose;
                BtnOda403.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
          else  if (selectedRoomNo == 403)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda403.BackColor = Color.Honeydew;
                BtnOda403.Text = "403";
                ButonKontrol2();
                ButonKontrolUltra();
            }
        }

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "301";
                HesaplaUcret();
                selectedRoomNo = 301;
                MessageBox.Show("Oda 301 seçildi.");
                BtnOda301.BackColor = Color.MistyRose;
                BtnOda301.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
            else  if (selectedRoomNo == 301)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda301.BackColor = Color.Honeydew;
                BtnOda301.Text = "301";
                ButonKontrol2();
                ButonKontrolUltra();
            }

        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "302";
                HesaplaUcret();
                selectedRoomNo = 302;
                MessageBox.Show("Oda 302 seçildi.");
                BtnOda302.BackColor = Color.MistyRose;
                BtnOda302.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
           else if (selectedRoomNo == 302)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda302.BackColor = Color.Honeydew;
                BtnOda302.Text = "302";
                ButonKontrol2();
                ButonKontrolUltra();
            }
        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "303";
                HesaplaUcret();
                selectedRoomNo = 303;
                MessageBox.Show("Oda 303 seçildi.");
                BtnOda303.BackColor = Color.MistyRose;
                BtnOda303.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
            else if (selectedRoomNo == 303)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda303.BackColor = Color.Honeydew;
                BtnOda303.Text = "303";
                ButonKontrol2();
                ButonKontrolUltra();
            }
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "201";
                HesaplaUcret();
                selectedRoomNo = 201;
                MessageBox.Show("Oda 201 seçildi.");
                BtnOda201.BackColor = Color.MistyRose;
                BtnOda201.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
           else if (selectedRoomNo == 201)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda201.BackColor = Color.Honeydew;
                BtnOda201.Text = "201";
                ButonKontrol2();
                ButonKontrolUltra();
            }
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "202";
                HesaplaUcret();
                selectedRoomNo = 202;
                MessageBox.Show("Oda 202 seçildi.");
                BtnOda202.BackColor = Color.MistyRose;
                BtnOda202.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
           else if (selectedRoomNo == 202)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda202.BackColor = Color.Honeydew;
                BtnOda202.Text = "202";
                ButonKontrol2();
                ButonKontrolUltra();
            }
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "203";
                HesaplaUcret();
                selectedRoomNo = 203;
                MessageBox.Show("Oda 203 seçildi.");
                BtnOda203.BackColor = Color.MistyRose;
                BtnOda203.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
           else  if (selectedRoomNo == 203)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda203.BackColor = Color.Honeydew;
                BtnOda203.Text = "203";
                ButonKontrol2();
                ButonKontrolUltra();
            }

        }
        private int selectedRoomNo = -1;


        private void BtnOda101_Click(object sender, EventArgs e)
        {
            if (selectedRoomNo == -1)
            {
                BtnRezervasyonYap.Enabled = true;
                TxtOdaNo.Text = "101";
                HesaplaUcret();
                selectedRoomNo = 101;
                MessageBox.Show("Oda 101 seçildi.");
                BtnOda101.BackColor = Color.MistyRose;
                BtnOda101.Text = "Seçildi";
                roomSelected = true;
                ButonKontrol();
            }
           else if (selectedRoomNo == 101)
            {
                BtnRezervasyonYap.Enabled = false;
                selectedRoomNo = -1;
                roomSelected = true;
                BtnOda101.BackColor = Color.Honeydew;
                BtnOda101.Text = "101";
                ButonKontrol2();
                ButonKontrolUltra();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }





        




        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

            DtpCikisTarihi.CustomFormat = "dd MMMM yyyy";

            MüşteriBilgileriKontrolEt();
        }

        private void HesaplaUcret()
        {
            int Ucret;
            DateTime girisTarihi = DtpGirisTarihi.Value;
            DateTime cikisTarihi = DtpCikisTarihi.Value;

            if (cikisTarihi <= girisTarihi)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden önce veya aynı olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan fark = cikisTarihi - girisTarihi;
            int gunSayisi = (int)fark.TotalDays;
            label11.Text = gunSayisi.ToString();

            int odaFiyati = 0;
            if (!string.IsNullOrEmpty(TxtOdaNo.Text))
            {
                if (TxtOdaNo.Text == "401" || TxtOdaNo.Text == "402" || TxtOdaNo.Text == "403")
                {
                    odaFiyati = 2000;
                }
                else
                {
                    odaFiyati = 1000;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir oda seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int toplamUcret = gunSayisi * odaFiyati;
            TxtUcret.Text = toplamUcret.ToString();

        }


        private void label11_Click(object sender, EventArgs e)
        {



        }

        private void Btnilerle_Click(object sender, EventArgs e)

        {
           
        


        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU");
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("INSERT INTO Musteri (Adi, Soyadi, TcKimlikNo, Telefon, Eposta, OdaNo, GirisTarihi, CikisTarihi, Ucret) " +
                                                  "VALUES (@Adi, @Soyadi, @TcKimlikNo, @Telefon, @Eposta, @OdaNo, @GirisTarihi, @CikisTarihi, @Ucret)", baglanti);

            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@TcKimlikNo", TxtKimlikNo.Text);
            komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@Eposta", TxtEposta.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);


            komut.ExecuteNonQuery();


            baglanti.Close();




            {



                if (selectedRoomNo == -1)
                {
                    MessageBox.Show("Lütfen bir oda seçin!");
                    return;
                }

                UpdateRoomStatus(selectedRoomNo);

                MessageBox.Show($"Oda {selectedRoomNo} Başarıyla rezerve edildi, Ana Menüye yönlendiriliyorsunuz.");


            }

            ButonKontrolOmega();

            Form1 menu = new Form1();
            menu.Show();
            this.Hide();

        }

       

        






        private void UpdateRoomStatus(int odaNo)
        {

            using (var connection = new MySqlConnection("Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU"))
            {
                connection.Open();


                string updateRoomStatusQuery = $"UPDATE Oda SET Durum = 'Dolu' WHERE OdaNo = {odaNo};";


                MySqlCommand cmd = new MySqlCommand(updateRoomStatusQuery, connection);
                cmd.ExecuteNonQuery();


            }
        }

        private string GetRoomStatus(int odaNo)
        {
            string connectionString = "Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU";
            string odaDurumu = string.Empty;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string getRoomStatusQuery = $"SELECT Durum FROM Oda WHERE OdaNo = {odaNo};";
                MySqlCommand komut = new MySqlCommand(getRoomStatusQuery, connection);

                
                odaDurumu = komut.ExecuteScalar()?.ToString();

                connection.Close();
            }


            return odaDurumu;
        }






        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public class DatabaseHelper
        {
            private string connectionString = "Server=172.21.54.253;Database=25_132330014;User=25_132330014;Password=!nif.ogr14BU;";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
        }
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string createOdaTableQuery = @"
            CREATE TABLE IF NOT EXISTS Oda (
            OdaNo INT PRIMARY KEY,
            Durum VARCHAR(10) NOT NULL,
            Tur VARCHAR(20) NOT NULL,
            Ucret DECIMAL(10, 2) NOT NULL
            );";

            string createMusteriTableQuery = @"
            CREATE TABLE IF NOT EXISTS Musteri (
            MusteriID INT PRIMARY KEY AUTO_INCREMENT,
            Ad VARCHAR(50),
            Soyad VARCHAR(50),
            OdaNo INT,
            FOREIGN KEY (OdaNo) REFERENCES Oda(OdaNo)
            );";

            using (var connection = new DatabaseHelper().GetConnection())
            {
                connection.Open();

               
                MySqlCommand cmd = new MySqlCommand(createOdaTableQuery, connection);
                cmd.ExecuteNonQuery();

                
                cmd.CommandText = createMusteriTableQuery;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Tablolar başarıyla oluşturuldu!");
            }
        }
        private void btnInsertData_Click(object sender, EventArgs e)
        {
            string insertDataQuery = @"
    INSERT INTO Oda (OdaNo, Durum, Tur, Ucret) VALUES
    (101, 'Boş', 'Standart', 1000),
    (201, 'Boş', 'Standart', 1000),
    (202, 'Boş', 'Standart', 1000),
    (203, 'Boş', 'Standart', 1000),
    (301, 'Boş', 'Standart', 1000),
    (302, 'Boş', 'Standart', 1000),
    (303, 'Boş', 'Standart', 1000),
    (401, 'Boş', 'Lüks', 2000),
    (402, 'Boş', 'Lüks', 2000),
    (403, 'Boş', 'Lüks', 2000);";


            using (var connection = new DatabaseHelper().GetConnection())
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(insertDataQuery, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Veriler başarıyla eklendi!");
            }
        }
        private void TxtSoyadi_TextChanged(object sender, EventArgs e)
        {
            MüşteriBilgileriKontrolEt();

        }

        private void TxtEposta_TextChanged(object sender, EventArgs e)
        {
            MüşteriBilgileriKontrolEt();
        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {
            MüşteriBilgileriKontrolEt();
        }


        private void TxtKimlikNo_TextChanged(object sender, EventArgs e)
        {
            MüşteriBilgileriKontrolEt();
        }

        private void MskTxtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MüşteriBilgileriKontrolEt();
        }








        private void ButonKontrolOmega()
        {
            if (GetRoomStatus(101) == "Dolu")
            {
                UpdateRoomStatus(101);
                BtnOda101.BackColor = Color.MistyRose;
                BtnOda101.Text = "Dolu";
                BtnOda101.Enabled = false;
            }

            if (GetRoomStatus(201) == "Dolu")
            {
                UpdateRoomStatus(201);
                BtnOda201.BackColor = Color.MistyRose;
                BtnOda201.Text = "Dolu";
                BtnOda201.Enabled = false;
            }

            if (GetRoomStatus(202) == "Dolu")
            {
                UpdateRoomStatus(202);
                BtnOda202.BackColor = Color.MistyRose;
                BtnOda202.Text = "Dolu";
                BtnOda202.Enabled = false;
            }

            if (GetRoomStatus(203) == "Dolu")
            {
                UpdateRoomStatus(203);
                BtnOda203.BackColor = Color.MistyRose;
                BtnOda203.Text = "Dolu";
                BtnOda203.Enabled = false;
            }

            if (GetRoomStatus(301) == "Dolu")
            {
                UpdateRoomStatus(301);
                BtnOda301.BackColor = Color.MistyRose;
                BtnOda301.Text = "Dolu";
                BtnOda301.Enabled = false;
            }

            if (GetRoomStatus(302) == "Dolu")
            {
                UpdateRoomStatus(302);
                BtnOda302.BackColor = Color.MistyRose;
                BtnOda302.Text = "Dolu";
                BtnOda302.Enabled = false;
            }

            if (GetRoomStatus(303) == "Dolu")
            {
                UpdateRoomStatus(303);
                BtnOda303.BackColor = Color.MistyRose;
                BtnOda303.Text = "Dolu";
                BtnOda303.Enabled = false;
            }

            if (GetRoomStatus(401) == "Dolu")
            {
                UpdateRoomStatus(401);
                BtnOda401.BackColor = Color.MistyRose;
                BtnOda401.Text = "Dolu";
                BtnOda401.Enabled = false;
            }

            if (GetRoomStatus(402) == "Dolu")
            {
                UpdateRoomStatus(402);
                BtnOda402.BackColor = Color.MistyRose;
                BtnOda402.Text = "Dolu";
                BtnOda402.Enabled = false;
            }

            if (GetRoomStatus(403) == "Dolu")
            {
                UpdateRoomStatus(403);
                BtnOda403.BackColor = Color.MistyRose;
                BtnOda403.Text = "Dolu";
                BtnOda403.Enabled = false;
            }
        }
        private void ButonKontrolUltra()
        {
            if (GetRoomStatus(401) == "Dolu") { BtnOda401.Enabled = false; }
            if (GetRoomStatus(402) == "Dolu") { BtnOda402.Enabled = false; }
            if (GetRoomStatus(403) == "Dolu") { BtnOda403.Enabled = false; }
            if (GetRoomStatus(301) == "Dolu") { BtnOda301.Enabled = false; }
            if (GetRoomStatus(302) == "Dolu") { BtnOda302.Enabled = false; }
            if (GetRoomStatus(303) == "Dolu") { BtnOda303.Enabled = false; }
            if (GetRoomStatus(201) == "Dolu") { BtnOda201.Enabled = false; }
            if (GetRoomStatus(202) == "Dolu") { BtnOda202.Enabled = false; }
            if (GetRoomStatus(203) == "Dolu") { BtnOda203.Enabled = false; }
            if (GetRoomStatus(101) == "Dolu") { BtnOda101.Enabled = false; }
        }
            
        private void ButonKontrol()
        {
            if (roomSelected)
            {
                if (selectedRoomNo != 403) { BtnOda403.Enabled = false; }
                if (selectedRoomNo != 402) { BtnOda402.Enabled = false; }
                if (selectedRoomNo != 401) { BtnOda401.Enabled = false; }
                if (selectedRoomNo != 303) { BtnOda303.Enabled = false; }
                if (selectedRoomNo != 302) { BtnOda302.Enabled = false; }
                if (selectedRoomNo != 301) { BtnOda301.Enabled = false; }
                if (selectedRoomNo != 203) { BtnOda203.Enabled = false; }
                if (selectedRoomNo != 202) { BtnOda202.Enabled = false; }
                if (selectedRoomNo != 201) { BtnOda201.Enabled = false; }
                if (selectedRoomNo != 101) { BtnOda101.Enabled = false; }

            }
        }  
        
        private void ButonKontrol2()
        {
      
            
                BtnOda401.Enabled = true;
                BtnOda402.Enabled = true;
                BtnOda403.Enabled = true;
                BtnOda301.Enabled = true;
                BtnOda302.Enabled = true;
                BtnOda303.Enabled = true;
                BtnOda201.Enabled = true;
                BtnOda202.Enabled = true;
                BtnOda203.Enabled = true;
                BtnOda101.Enabled = true;
            
        }


        private void MüşteriBilgileriKontrolEt()
        {
            if (!string.IsNullOrEmpty(TxtAdi.Text) &&
               !string.IsNullOrEmpty(TxtSoyadi.Text) &&
               !string.IsNullOrEmpty(TxtKimlikNo.Text) &&
               !string.IsNullOrEmpty(MskTxtTelefon.Text) &&
               !string.IsNullOrEmpty(TxtEposta.Text) &&
               DtpCikisTarihi.CustomFormat != " ") 

            {

                
                if (!roomSelected)
                {
                    if (GetRoomStatus(401) == "Boş") { BtnOda401.Enabled = true; }
                    if (GetRoomStatus(402) == "Boş") { BtnOda402.Enabled = true; }
                    if (GetRoomStatus(403) == "Boş") { BtnOda403.Enabled = true; }
                    if (GetRoomStatus(301) == "Boş") { BtnOda301.Enabled = true; }
                    if (GetRoomStatus(302) == "Boş") { BtnOda302.Enabled = true; }
                    if (GetRoomStatus(303) == "Boş") { BtnOda303.Enabled = true; }
                    if (GetRoomStatus(201) == "Boş") { BtnOda201.Enabled = true; }
                    if (GetRoomStatus(202) == "Boş") { BtnOda202.Enabled = true; }
                    if (GetRoomStatus(203) == "Boş") { BtnOda203.Enabled = true; }
                    if (GetRoomStatus(101) == "Boş") { BtnOda101.Enabled = true; }
                }
            }
            else
            {
                
                BtnOda401.Enabled = false;
                BtnOda402.Enabled = false;
                BtnOda403.Enabled = false;
                BtnOda301.Enabled = false;
                BtnOda302.Enabled = false;
                BtnOda303.Enabled = false;
                BtnOda201.Enabled = false;
                BtnOda202.Enabled = false;
                BtnOda203.Enabled = false;
                BtnOda101.Enabled = false;
            }

        }

        private void txtBilgi_TextChanged(object sender, EventArgs e)
        {
            
            MüşteriBilgileriKontrolEt();
        }

        private bool onlyOnce = false;


        private void frmmusterigiris_Load(object sender, EventArgs e)
        {
            DisableOdaButtons();
            BtnRezervasyonYap.Enabled = false;
            DtpCikisTarihi.CustomFormat = " ";
            DtpCikisTarihi.Format = DateTimePickerFormat.Custom;
            BtnRezervasyonYap.Enabled = false;

            if (!onlyOnce)
            {


                ButonKontrolOmega();

                onlyOnce = true;
            }

        }



        private void DisableOdaButtons()
        {
            BtnOda401.Enabled = false;
            BtnOda402.Enabled = false;
            BtnOda403.Enabled = false;
            BtnOda301.Enabled = false;
            BtnOda302.Enabled = false;
            BtnOda303.Enabled = false;
            BtnOda201.Enabled = false;
            BtnOda202.Enabled = false;
            BtnOda203.Enabled = false;
            BtnOda101.Enabled = false;

      
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }

}





