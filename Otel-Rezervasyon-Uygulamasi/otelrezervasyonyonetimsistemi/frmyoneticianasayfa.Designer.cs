namespace otelrezervasyonyonetimsistemi
{
    partial class frmyoneticianasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtEposta = new System.Windows.Forms.TextBox();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnİptalEt = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(484, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(891, 407);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri No";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TC Kimlik No";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-Posta";
            this.columnHeader6.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Oda No";
            this.columnHeader7.Width = 89;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giriş Tarihi";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Çıkış Tarihi";
            this.columnHeader9.Width = 96;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ücret";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1065, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Müşterilerin Bilgilerini Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(560, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(497, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "İSİM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(26, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(180, 340);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(233, 22);
            this.DtpCikisTarihi.TabIndex = 37;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(180, 299);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(233, 22);
            this.DtpGirisTarihi.TabIndex = 36;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // TxtUcret
            // 
            this.TxtUcret.Enabled = false;
            this.TxtUcret.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(180, 377);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(233, 22);
            this.TxtUcret.TabIndex = 35;
            this.TxtUcret.TextChanged += new System.EventHandler(this.TxtUcret_TextChanged);
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNo.Location = new System.Drawing.Point(180, 259);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(233, 22);
            this.TxtOdaNo.TabIndex = 34;
            // 
            // TxtEposta
            // 
            this.TxtEposta.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEposta.Location = new System.Drawing.Point(180, 219);
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(233, 22);
            this.TxtEposta.TabIndex = 33;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(180, 176);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(233, 22);
            this.MskTxtTelefon.TabIndex = 32;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKimlikNo.Location = new System.Drawing.Point(180, 133);
            this.TxtKimlikNo.MaxLength = 11;
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(233, 22);
            this.TxtKimlikNo.TabIndex = 31;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Location = new System.Drawing.Point(180, 87);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(233, 22);
            this.TxtSoyadi.TabIndex = 30;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(180, 46);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(233, 22);
            this.TxtAdi.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(65, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ücret:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(65, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Oda No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(63, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "E-posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adı:";
            // 
            // BtnİptalEt
            // 
            this.BtnİptalEt.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnİptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnİptalEt.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnİptalEt.Location = new System.Drawing.Point(253, 433);
            this.BtnİptalEt.Name = "BtnİptalEt";
            this.BtnİptalEt.Size = new System.Drawing.Size(178, 61);
            this.BtnİptalEt.TabIndex = 40;
            this.BtnİptalEt.Text = "Rezervasyonu İptal Et";
            this.BtnİptalEt.UseVisualStyleBackColor = false;
            this.BtnİptalEt.Click += new System.EventHandler(this.BtnİptalEt_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(81, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 58);
            this.button4.TabIndex = 41;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(803, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(180, 533);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(123, 38);
            this.BtnTemizle.TabIndex = 42;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(23, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 59);
            this.button3.TabIndex = 43;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmyoneticianasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1413, 629);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnİptalEt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.TxtEposta);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.TxtKimlikNo);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "frmyoneticianasayfa";
            this.Text = "Yönetici Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtEposta;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnİptalEt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button button3;
    }
}