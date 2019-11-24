namespace Otel_Rezervasyon
{
    partial class ucKayitOl
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
            this.gradientPanel1 = new Otel_Rezervasyon.GradientPanel();
            this.soyad = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.imail = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.SeaGreen;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gradientPanel1.Controls.Add(this.soyad);
            this.gradientPanel1.Controls.Add(this.btnKayitOl);
            this.gradientPanel1.Controls.Add(this.sifre);
            this.gradientPanel1.Controls.Add(this.ad);
            this.gradientPanel1.Controls.Add(this.kullaniciAdi);
            this.gradientPanel1.Controls.Add(this.imail);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(460, 348);
            this.gradientPanel1.TabIndex = 7;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.soyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.soyad.Location = new System.Drawing.Point(122, 105);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(215, 27);
            this.soyad.TabIndex = 3;
            this.soyad.Text = "Soyisim";
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soyad.Enter += new System.EventHandler(this.soyad_Enter);
            this.soyad.Leave += new System.EventHandler(this.soyad_Leave);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.AutoSize = true;
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnKayitOl.Location = new System.Drawing.Point(122, 243);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(215, 44);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.sifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sifre.Location = new System.Drawing.Point(122, 171);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(215, 27);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre";
            this.sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ad.Location = new System.Drawing.Point(122, 72);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(215, 27);
            this.ad.TabIndex = 2;
            this.ad.Text = "İsim";
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ad.Enter += new System.EventHandler(this.ad_Enter);
            this.ad.Leave += new System.EventHandler(this.ad_Leave);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.kullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.kullaniciAdi.Location = new System.Drawing.Point(122, 39);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(215, 27);
            this.kullaniciAdi.TabIndex = 1;
            this.kullaniciAdi.Text = "Kullanıcı Adı";
            this.kullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullaniciAdi.Enter += new System.EventHandler(this.id_Enter);
            this.kullaniciAdi.Leave += new System.EventHandler(this.id_Leave);
            // 
            // imail
            // 
            this.imail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.imail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.imail.Location = new System.Drawing.Point(122, 138);
            this.imail.Name = "imail";
            this.imail.Size = new System.Drawing.Size(215, 27);
            this.imail.TabIndex = 4;
            this.imail.Text = "someone@example.com";
            this.imail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imail.TextChanged += new System.EventHandler(this.imail_TextChanged);
            this.imail.Enter += new System.EventHandler(this.imail_Enter);
            this.imail.Leave += new System.EventHandler(this.imail_Leave);
            // 
            // ucKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ucKayitOl";
            this.Size = new System.Drawing.Size(460, 348);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox imail;
        private System.Windows.Forms.TextBox ad;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox soyad;
    }
}
