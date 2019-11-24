namespace Otel_Rezervasyon
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panelUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabYG = new System.Windows.Forms.Button();
            this.tabKayitOl = new System.Windows.Forms.Button();
            this.tabGirisYap = new System.Windows.Forms.Button();
            this.panelAna = new System.Windows.Forms.Panel();
            this.ucYG1 = new Otel_Rezervasyon.ucYG();
            this.ucKayitOl1 = new Otel_Rezervasyon.ucKayitOl();
            this.ucGirisYap1 = new Otel_Rezervasyon.ucGirisYap();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTab.SuspendLayout();
            this.panelAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelUst.Controls.Add(this.pictureBox1);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(560, 32);
            this.panelUst.TabIndex = 0;
            this.panelUst.Move += new System.EventHandler(this.panel1_Move);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTab.Controls.Add(this.tabYG);
            this.panelTab.Controls.Add(this.tabKayitOl);
            this.panelTab.Controls.Add(this.tabGirisYap);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTab.Location = new System.Drawing.Point(0, 32);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(100, 348);
            this.panelTab.TabIndex = 4;
            this.panelTab.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTab_Paint);
            // 
            // tabYG
            // 
            this.tabYG.AutoSize = true;
            this.tabYG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabYG.FlatAppearance.BorderSize = 0;
            this.tabYG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabYG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabYG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.tabYG.Location = new System.Drawing.Point(3, 133);
            this.tabYG.Name = "tabYG";
            this.tabYG.Size = new System.Drawing.Size(94, 52);
            this.tabYG.TabIndex = 7;
            this.tabYG.Text = "Yönetici \r\nGiriş";
            this.tabYG.UseVisualStyleBackColor = false;
            this.tabYG.Click += new System.EventHandler(this.tabYG_Click);
            // 
            // tabKayitOl
            // 
            this.tabKayitOl.AutoSize = true;
            this.tabKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabKayitOl.FlatAppearance.BorderSize = 0;
            this.tabKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabKayitOl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.tabKayitOl.Location = new System.Drawing.Point(3, 83);
            this.tabKayitOl.Name = "tabKayitOl";
            this.tabKayitOl.Size = new System.Drawing.Size(94, 44);
            this.tabKayitOl.TabIndex = 6;
            this.tabKayitOl.Text = "Kayıt Ol";
            this.tabKayitOl.UseVisualStyleBackColor = false;
            this.tabKayitOl.Click += new System.EventHandler(this.tabKayitOl_Click);
            // 
            // tabGirisYap
            // 
            this.tabGirisYap.AutoSize = true;
            this.tabGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabGirisYap.FlatAppearance.BorderSize = 0;
            this.tabGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabGirisYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabGirisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.tabGirisYap.Location = new System.Drawing.Point(3, 33);
            this.tabGirisYap.Name = "tabGirisYap";
            this.tabGirisYap.Size = new System.Drawing.Size(94, 44);
            this.tabGirisYap.TabIndex = 5;
            this.tabGirisYap.Text = "Giriş Yap";
            this.tabGirisYap.UseVisualStyleBackColor = false;
            this.tabGirisYap.Click += new System.EventHandler(this.tabGirisYap_Click);
            // 
            // panelAna
            // 
            this.panelAna.Controls.Add(this.ucYG1);
            this.panelAna.Controls.Add(this.ucKayitOl1);
            this.panelAna.Controls.Add(this.ucGirisYap1);
            this.panelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAna.Location = new System.Drawing.Point(100, 32);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(460, 348);
            this.panelAna.TabIndex = 5;
            // 
            // ucYG1
            // 
            this.ucYG1.Location = new System.Drawing.Point(0, 0);
            this.ucYG1.Name = "ucYG1";
            this.ucYG1.Size = new System.Drawing.Size(460, 348);
            this.ucYG1.TabIndex = 2;
            this.ucYG1.Load += new System.EventHandler(this.ucYG1_Load);
            // 
            // ucKayitOl1
            // 
            this.ucKayitOl1.BackColor = System.Drawing.Color.White;
            this.ucKayitOl1.Location = new System.Drawing.Point(0, 0);
            this.ucKayitOl1.Name = "ucKayitOl1";
            this.ucKayitOl1.Size = new System.Drawing.Size(460, 348);
            this.ucKayitOl1.TabIndex = 1;
            this.ucKayitOl1.Load += new System.EventHandler(this.ucKayitOl1_Load);
            // 
            // ucGirisYap1
            // 
            this.ucGirisYap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ucGirisYap1.Location = new System.Drawing.Point(0, 0);
            this.ucGirisYap1.Name = "ucGirisYap1";
            this.ucGirisYap1.Size = new System.Drawing.Size(460, 348);
            this.ucGirisYap1.TabIndex = 0;
            this.ucGirisYap1.Load += new System.EventHandler(this.ucGirisYap1_Load);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.panelAna);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTab.ResumeLayout(false);
            this.panelTab.PerformLayout();
            this.panelAna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button tabKayitOl;
        private System.Windows.Forms.Button tabGirisYap;
        private System.Windows.Forms.Panel panelAna;
        private ucGirisYap ucGirisYap1;
        private ucKayitOl ucKayitOl1;
        private System.Windows.Forms.Button tabYG;
        private ucYG ucYG1;
    }
}

