namespace Otel_Rezervasyon
{
    partial class ucYME
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
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.odaNo = new System.Windows.Forms.TextBox();
            this.telNo = new System.Windows.Forms.MaskedTextBox();
            this.btnYME = new System.Windows.Forms.Button();
            this.oda12 = new System.Windows.Forms.Button();
            this.oda11 = new System.Windows.Forms.Button();
            this.oda10 = new System.Windows.Forms.Button();
            this.oda9 = new System.Windows.Forms.Button();
            this.oda8 = new System.Windows.Forms.Button();
            this.oda7 = new System.Windows.Forms.Button();
            this.oda6 = new System.Windows.Forms.Button();
            this.oda5 = new System.Windows.Forms.Button();
            this.oda4 = new System.Windows.Forms.Button();
            this.oda3 = new System.Windows.Forms.Button();
            this.oda1 = new System.Windows.Forms.Button();
            this.oda2 = new System.Windows.Forms.Button();
            this.ucret = new System.Windows.Forms.TextBox();
            this.tcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aTema = new System.Windows.Forms.ToolStripMenuItem();
            this.kTema = new System.Windows.Forms.ToolStripMenuItem();
            this.girisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.tema.SuspendLayout();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ad.Location = new System.Drawing.Point(3, 18);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(215, 27);
            this.ad.TabIndex = 1;
            this.ad.Text = "Ad";
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ad.Enter += new System.EventHandler(this.ad_Enter);
            this.ad.Leave += new System.EventHandler(this.ad_Leave);
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.soyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.soyad.Location = new System.Drawing.Point(3, 51);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(215, 27);
            this.soyad.TabIndex = 2;
            this.soyad.Text = "Soyad";
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soyad.Enter += new System.EventHandler(this.soyad_Enter);
            this.soyad.Leave += new System.EventHandler(this.soyad_Leave);
            // 
            // mail
            // 
            this.mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.mail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.mail.Location = new System.Drawing.Point(3, 117);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(215, 27);
            this.mail.TabIndex = 4;
            this.mail.Text = "someone@example.com";
            this.mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mail.Enter += new System.EventHandler(this.mail_Enter);
            this.mail.Leave += new System.EventHandler(this.mail_Leave);
            // 
            // odaNo
            // 
            this.odaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.odaNo.Enabled = false;
            this.odaNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.odaNo.Location = new System.Drawing.Point(3, 183);
            this.odaNo.Name = "odaNo";
            this.odaNo.Size = new System.Drawing.Size(215, 27);
            this.odaNo.TabIndex = 6;
            this.odaNo.Text = "Oda No";
            this.odaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.odaNo.Click += new System.EventHandler(this.odaNo_Click);
            this.odaNo.Enter += new System.EventHandler(this.odaNo_Enter);
            this.odaNo.Leave += new System.EventHandler(this.odaNo_Leave);
            // 
            // telNo
            // 
            this.telNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.telNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.telNo.Location = new System.Drawing.Point(3, 84);
            this.telNo.Mask = "(999) 000-0000";
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(215, 27);
            this.telNo.TabIndex = 3;
            this.telNo.Text = "5000000000";
            this.telNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telNo.Enter += new System.EventHandler(this.telNo_Enter);
            this.telNo.Leave += new System.EventHandler(this.telNo_Leave);
            // 
            // btnYME
            // 
            this.btnYME.AutoSize = true;
            this.btnYME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnYME.FlatAppearance.BorderSize = 0;
            this.btnYME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYME.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnYME.Location = new System.Drawing.Point(3, 347);
            this.btnYME.Name = "btnYME";
            this.btnYME.Size = new System.Drawing.Size(215, 44);
            this.btnYME.TabIndex = 10;
            this.btnYME.Text = "Yeni Müşteri Ekle";
            this.btnYME.UseVisualStyleBackColor = false;
            this.btnYME.Click += new System.EventHandler(this.btnYME_Click);
            // 
            // oda12
            // 
            this.oda12.AutoSize = true;
            this.oda12.BackColor = System.Drawing.Color.SeaGreen;
            this.oda12.FlatAppearance.BorderSize = 0;
            this.oda12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda12.Location = new System.Drawing.Point(466, 261);
            this.oda12.Name = "oda12";
            this.oda12.Size = new System.Drawing.Size(80, 80);
            this.oda12.TabIndex = 38;
            this.oda12.Text = "112";
            this.oda12.UseVisualStyleBackColor = false;
            this.oda12.Click += new System.EventHandler(this.oda12_Click);
            // 
            // oda11
            // 
            this.oda11.AutoSize = true;
            this.oda11.BackColor = System.Drawing.Color.SeaGreen;
            this.oda11.FlatAppearance.BorderSize = 0;
            this.oda11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda11.Location = new System.Drawing.Point(380, 261);
            this.oda11.Name = "oda11";
            this.oda11.Size = new System.Drawing.Size(80, 80);
            this.oda11.TabIndex = 37;
            this.oda11.Text = "111";
            this.oda11.UseVisualStyleBackColor = false;
            this.oda11.Click += new System.EventHandler(this.oda11_Click);
            // 
            // oda10
            // 
            this.oda10.AutoSize = true;
            this.oda10.BackColor = System.Drawing.Color.SeaGreen;
            this.oda10.FlatAppearance.BorderSize = 0;
            this.oda10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda10.Location = new System.Drawing.Point(294, 261);
            this.oda10.Name = "oda10";
            this.oda10.Size = new System.Drawing.Size(80, 80);
            this.oda10.TabIndex = 36;
            this.oda10.Text = "110";
            this.oda10.UseVisualStyleBackColor = false;
            this.oda10.Click += new System.EventHandler(this.oda10_Click);
            // 
            // oda9
            // 
            this.oda9.AutoSize = true;
            this.oda9.BackColor = System.Drawing.Color.SeaGreen;
            this.oda9.FlatAppearance.BorderSize = 0;
            this.oda9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda9.Location = new System.Drawing.Point(466, 175);
            this.oda9.Name = "oda9";
            this.oda9.Size = new System.Drawing.Size(80, 80);
            this.oda9.TabIndex = 35;
            this.oda9.Text = "109";
            this.oda9.UseVisualStyleBackColor = false;
            this.oda9.Click += new System.EventHandler(this.oda9_Click);
            // 
            // oda8
            // 
            this.oda8.AutoSize = true;
            this.oda8.BackColor = System.Drawing.Color.SeaGreen;
            this.oda8.FlatAppearance.BorderSize = 0;
            this.oda8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda8.Location = new System.Drawing.Point(380, 175);
            this.oda8.Name = "oda8";
            this.oda8.Size = new System.Drawing.Size(80, 80);
            this.oda8.TabIndex = 34;
            this.oda8.Text = "108";
            this.oda8.UseVisualStyleBackColor = false;
            this.oda8.Click += new System.EventHandler(this.oda8_Click);
            // 
            // oda7
            // 
            this.oda7.AutoSize = true;
            this.oda7.BackColor = System.Drawing.Color.SeaGreen;
            this.oda7.FlatAppearance.BorderSize = 0;
            this.oda7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda7.Location = new System.Drawing.Point(294, 175);
            this.oda7.Name = "oda7";
            this.oda7.Size = new System.Drawing.Size(80, 80);
            this.oda7.TabIndex = 33;
            this.oda7.Text = "107";
            this.oda7.UseVisualStyleBackColor = false;
            this.oda7.Click += new System.EventHandler(this.oda7_Click);
            // 
            // oda6
            // 
            this.oda6.AutoSize = true;
            this.oda6.BackColor = System.Drawing.Color.SeaGreen;
            this.oda6.FlatAppearance.BorderSize = 0;
            this.oda6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda6.Location = new System.Drawing.Point(466, 89);
            this.oda6.Name = "oda6";
            this.oda6.Size = new System.Drawing.Size(80, 80);
            this.oda6.TabIndex = 32;
            this.oda6.Text = "106";
            this.oda6.UseVisualStyleBackColor = false;
            this.oda6.Click += new System.EventHandler(this.oda6_Click);
            // 
            // oda5
            // 
            this.oda5.AutoSize = true;
            this.oda5.BackColor = System.Drawing.Color.SeaGreen;
            this.oda5.FlatAppearance.BorderSize = 0;
            this.oda5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda5.Location = new System.Drawing.Point(380, 89);
            this.oda5.Name = "oda5";
            this.oda5.Size = new System.Drawing.Size(80, 80);
            this.oda5.TabIndex = 31;
            this.oda5.Text = "105";
            this.oda5.UseVisualStyleBackColor = false;
            this.oda5.Click += new System.EventHandler(this.oda5_Click);
            // 
            // oda4
            // 
            this.oda4.AutoSize = true;
            this.oda4.BackColor = System.Drawing.Color.SeaGreen;
            this.oda4.FlatAppearance.BorderSize = 0;
            this.oda4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda4.Location = new System.Drawing.Point(294, 89);
            this.oda4.Name = "oda4";
            this.oda4.Size = new System.Drawing.Size(80, 80);
            this.oda4.TabIndex = 30;
            this.oda4.Text = "104";
            this.oda4.UseVisualStyleBackColor = false;
            this.oda4.Click += new System.EventHandler(this.oda4_Click);
            // 
            // oda3
            // 
            this.oda3.AutoSize = true;
            this.oda3.BackColor = System.Drawing.Color.SeaGreen;
            this.oda3.FlatAppearance.BorderSize = 0;
            this.oda3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda3.Location = new System.Drawing.Point(466, 3);
            this.oda3.Name = "oda3";
            this.oda3.Size = new System.Drawing.Size(80, 80);
            this.oda3.TabIndex = 29;
            this.oda3.Text = "103";
            this.oda3.UseVisualStyleBackColor = false;
            this.oda3.Click += new System.EventHandler(this.oda3_Click);
            // 
            // oda1
            // 
            this.oda1.AutoSize = true;
            this.oda1.BackColor = System.Drawing.Color.SeaGreen;
            this.oda1.FlatAppearance.BorderSize = 0;
            this.oda1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda1.Location = new System.Drawing.Point(294, 3);
            this.oda1.Name = "oda1";
            this.oda1.Size = new System.Drawing.Size(80, 80);
            this.oda1.TabIndex = 27;
            this.oda1.Text = "101";
            this.oda1.UseVisualStyleBackColor = false;
            this.oda1.Click += new System.EventHandler(this.oda1_Click);
            // 
            // oda2
            // 
            this.oda2.AutoSize = true;
            this.oda2.BackColor = System.Drawing.Color.SeaGreen;
            this.oda2.FlatAppearance.BorderSize = 0;
            this.oda2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oda2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oda2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.oda2.Location = new System.Drawing.Point(380, 3);
            this.oda2.Name = "oda2";
            this.oda2.Size = new System.Drawing.Size(80, 80);
            this.oda2.TabIndex = 28;
            this.oda2.Text = "102";
            this.oda2.UseVisualStyleBackColor = false;
            this.oda2.Click += new System.EventHandler(this.oda2_Click);
            // 
            // ucret
            // 
            this.ucret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ucret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucret.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucret.Location = new System.Drawing.Point(3, 314);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(215, 27);
            this.ucret.TabIndex = 9;
            this.ucret.Text = "Ücret";
            this.ucret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucret.TextChanged += new System.EventHandler(this.ucret_TextChanged);
            this.ucret.Enter += new System.EventHandler(this.ucret_Enter);
            this.ucret.Leave += new System.EventHandler(this.ucret_Leave);
            // 
            // tcNo
            // 
            this.tcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.tcNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tcNo.Location = new System.Drawing.Point(3, 148);
            this.tcNo.MaxLength = 11;
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(215, 27);
            this.tcNo.TabIndex = 5;
            this.tcNo.Text = "T.C Kimlik Numarası";
            this.tcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tcNo.TextChanged += new System.EventHandler(this.tcNo_TextChanged);
            this.tcNo.Enter += new System.EventHandler(this.tcNo_Enter_1);
            this.tcNo.Leave += new System.EventHandler(this.tcNo_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // tema
            // 
            this.tema.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTema,
            this.kTema});
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(147, 48);
            this.tema.Opening += new System.ComponentModel.CancelEventHandler(this.tema_Opening);
            // 
            // aTema
            // 
            this.aTema.Name = "aTema";
            this.aTema.Size = new System.Drawing.Size(146, 22);
            this.aTema.Text = "Açık Tema";
            this.aTema.Click += new System.EventHandler(this.aTema_Click);
            // 
            // kTema
            // 
            this.kTema.Name = "kTema";
            this.kTema.Size = new System.Drawing.Size(146, 22);
            this.kTema.Text = "Koyu Tema";
            this.kTema.Click += new System.EventHandler(this.kTema_Click);
            // 
            // girisTarihi
            // 
            this.girisTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihi.Location = new System.Drawing.Point(3, 232);
            this.girisTarihi.Name = "girisTarihi";
            this.girisTarihi.Size = new System.Drawing.Size(215, 27);
            this.girisTarihi.TabIndex = 41;
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisTarihi.Location = new System.Drawing.Point(3, 281);
            this.cikisTarihi.Name = "cikisTarihi";
            this.cikisTarihi.Size = new System.Drawing.Size(215, 27);
            this.cikisTarihi.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(686, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Giriş Tarihi";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Giriş Tarihi";
            // 
            // btnYenile
            // 
            this.btnYenile.AutoSize = true;
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnYenile.Location = new System.Drawing.Point(294, 347);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(252, 44);
            this.btnYenile.TabIndex = 46;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // ucYME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ContextMenuStrip = this.tema;
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oda12);
            this.Controls.Add(this.oda11);
            this.Controls.Add(this.oda10);
            this.Controls.Add(this.cikisTarihi);
            this.Controls.Add(this.oda9);
            this.Controls.Add(this.girisTarihi);
            this.Controls.Add(this.oda8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oda7);
            this.Controls.Add(this.oda6);
            this.Controls.Add(this.tcNo);
            this.Controls.Add(this.oda5);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.oda4);
            this.Controls.Add(this.oda3);
            this.Controls.Add(this.btnYME);
            this.Controls.Add(this.oda1);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.oda2);
            this.Controls.Add(this.odaNo);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Name = "ucYME";
            this.Size = new System.Drawing.Size(748, 500);
            this.Load += new System.EventHandler(this.ucYME_Load);
            this.tema.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox odaNo;
        private System.Windows.Forms.MaskedTextBox telNo;
        private System.Windows.Forms.Button btnYME;
        private System.Windows.Forms.Button oda12;
        private System.Windows.Forms.Button oda11;
        private System.Windows.Forms.Button oda10;
        private System.Windows.Forms.Button oda9;
        private System.Windows.Forms.Button oda8;
        private System.Windows.Forms.Button oda7;
        private System.Windows.Forms.Button oda6;
        private System.Windows.Forms.Button oda5;
        private System.Windows.Forms.Button oda4;
        private System.Windows.Forms.Button oda3;
        private System.Windows.Forms.Button oda1;
        private System.Windows.Forms.Button oda2;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.TextBox tcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip tema;
        private System.Windows.Forms.ToolStripMenuItem aTema;
        private System.Windows.Forms.ToolStripMenuItem kTema;
        private System.Windows.Forms.DateTimePicker girisTarihi;
        private System.Windows.Forms.DateTimePicker cikisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYenile;
    }
}
