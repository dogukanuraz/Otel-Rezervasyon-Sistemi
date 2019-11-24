namespace Otel_Rezervasyon
{
    partial class ucMusteriler
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusteriler));
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.girisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcNo = new System.Windows.Forms.TextBox();
            this.ucret = new System.Windows.Forms.TextBox();
            this.telNo = new System.Windows.Forms.MaskedTextBox();
            this.odaNo = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.ara = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 134);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 36;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TC No";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Oda No";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ücret";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giriş Tarihi";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Çıkış Tarihi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = true;
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnGuncelle.Location = new System.Drawing.Point(216, 143);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(207, 44);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = true;
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnSil.Location = new System.Drawing.Point(429, 143);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(207, 44);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisTarihi.Location = new System.Drawing.Point(429, 242);
            this.cikisTarihi.Name = "cikisTarihi";
            this.cikisTarihi.Size = new System.Drawing.Size(207, 27);
            this.cikisTarihi.TabIndex = 53;
            // 
            // girisTarihi
            // 
            this.girisTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihi.Location = new System.Drawing.Point(429, 193);
            this.girisTarihi.Name = "girisTarihi";
            this.girisTarihi.Size = new System.Drawing.Size(207, 27);
            this.girisTarihi.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(426, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = ":Çıkış Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = ":Giriş Tarihi";
            // 
            // tcNo
            // 
            this.tcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.tcNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tcNo.Location = new System.Drawing.Point(216, 242);
            this.tcNo.MaxLength = 11;
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(207, 27);
            this.tcNo.TabIndex = 47;
            this.tcNo.Text = "T.C Kimlik Numarası";
            this.tcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tcNo.Enter += new System.EventHandler(this.tcNo_Enter);
            this.tcNo.Leave += new System.EventHandler(this.tcNo_Leave);
            // 
            // ucret
            // 
            this.ucret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ucret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucret.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucret.Location = new System.Drawing.Point(428, 291);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(207, 27);
            this.ucret.TabIndex = 49;
            this.ucret.Text = "Ücret";
            this.ucret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucret.TextChanged += new System.EventHandler(this.ucret_TextChanged);
            this.ucret.Enter += new System.EventHandler(this.ucret_Enter);
            this.ucret.Leave += new System.EventHandler(this.ucret_Leave);
            // 
            // telNo
            // 
            this.telNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.telNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.telNo.Location = new System.Drawing.Point(3, 291);
            this.telNo.Mask = "(999) 000-0000";
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(207, 27);
            this.telNo.TabIndex = 45;
            this.telNo.Text = "5000000000";
            this.telNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telNo.Enter += new System.EventHandler(this.telNo_Enter);
            this.telNo.Leave += new System.EventHandler(this.telNo_Leave);
            // 
            // odaNo
            // 
            this.odaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.odaNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.odaNo.Location = new System.Drawing.Point(216, 291);
            this.odaNo.Name = "odaNo";
            this.odaNo.Size = new System.Drawing.Size(207, 27);
            this.odaNo.TabIndex = 48;
            this.odaNo.Text = "Oda No";
            this.odaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.odaNo.TextChanged += new System.EventHandler(this.odaNo_TextChanged);
            this.odaNo.Enter += new System.EventHandler(this.odaNo_Enter);
            this.odaNo.Leave += new System.EventHandler(this.odaNo_Leave);
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.mail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.mail.Location = new System.Drawing.Point(216, 193);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(207, 27);
            this.mail.TabIndex = 46;
            this.mail.Text = "someone@example.com";
            this.mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mail.Enter += new System.EventHandler(this.mail_Enter);
            this.mail.Leave += new System.EventHandler(this.mail_Leave);
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.soyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.soyad.Location = new System.Drawing.Point(3, 242);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(207, 27);
            this.soyad.TabIndex = 44;
            this.soyad.Text = "Soyad";
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soyad.Enter += new System.EventHandler(this.soyad_Enter);
            this.soyad.Leave += new System.EventHandler(this.soyad_Leave);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ad.Location = new System.Drawing.Point(3, 193);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(207, 27);
            this.ad.TabIndex = 43;
            this.ad.Text = "Ad";
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ad.Enter += new System.EventHandler(this.ad_Enter);
            this.ad.Leave += new System.EventHandler(this.ad_Leave);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ara.Location = new System.Drawing.Point(3, 347);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(207, 27);
            this.ara.TabIndex = 54;
            this.ara.Text = "İsme Göre Ara";
            this.ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ara.Enter += new System.EventHandler(this.ara_Enter);
            this.ara.Leave += new System.EventHandler(this.ara_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.AutoSize = true;
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnYenile.Location = new System.Drawing.Point(3, 143);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(207, 44);
            this.btnYenile.TabIndex = 56;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 100000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.cikisTarihi);
            this.Controls.Add(this.girisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcNo);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.odaNo);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.listView1);
            this.Name = "ucMusteriler";
            this.Size = new System.Drawing.Size(748, 500);
            this.Load += new System.EventHandler(this.ucMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DateTimePicker cikisTarihi;
        private System.Windows.Forms.DateTimePicker girisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcNo;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.MaskedTextBox telNo;
        private System.Windows.Forms.TextBox odaNo;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Timer timer1;
    }
}
