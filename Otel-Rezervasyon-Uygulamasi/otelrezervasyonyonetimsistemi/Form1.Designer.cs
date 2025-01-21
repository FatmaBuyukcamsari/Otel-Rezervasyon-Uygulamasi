namespace otelrezervasyonyonetimsistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnYoneticiGiris = new System.Windows.Forms.Button();
            this.BtnMusteriGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(72, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pıtı Pıtı Oteline Hoşgeldiniz!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(180, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Giriş Modülü Seçiniz:";
            // 
            // BtnYoneticiGiris
            // 
            this.BtnYoneticiGiris.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnYoneticiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYoneticiGiris.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYoneticiGiris.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnYoneticiGiris.Location = new System.Drawing.Point(96, 305);
            this.BtnYoneticiGiris.Name = "BtnYoneticiGiris";
            this.BtnYoneticiGiris.Size = new System.Drawing.Size(153, 91);
            this.BtnYoneticiGiris.TabIndex = 2;
            this.BtnYoneticiGiris.Text = "Yönetici Girişi";
            this.BtnYoneticiGiris.UseVisualStyleBackColor = false;
            this.BtnYoneticiGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMusteriGiris
            // 
            this.BtnMusteriGiris.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnMusteriGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusteriGiris.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriGiris.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnMusteriGiris.Location = new System.Drawing.Point(332, 305);
            this.BtnMusteriGiris.Name = "BtnMusteriGiris";
            this.BtnMusteriGiris.Size = new System.Drawing.Size(153, 91);
            this.BtnMusteriGiris.TabIndex = 3;
            this.BtnMusteriGiris.Text = "Müşteri Girişi";
            this.BtnMusteriGiris.UseVisualStyleBackColor = false;
            this.BtnMusteriGiris.Click += new System.EventHandler(this.BtnMusteriGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(592, 467);
            this.Controls.Add(this.BtnMusteriGiris);
            this.Controls.Add(this.BtnYoneticiGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnYoneticiGiris;
        private System.Windows.Forms.Button BtnMusteriGiris;
    }


}

