namespace Otel_Rezervasyon
{
    partial class ucYG
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
            this.yoneticiID = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.SeaGreen;
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gradientPanel1.Controls.Add(this.yoneticiID);
            this.gradientPanel1.Controls.Add(this.btnGiris);
            this.gradientPanel1.Controls.Add(this.sifre);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(460, 348);
            this.gradientPanel1.TabIndex = 0;
            // 
            // yoneticiID
            // 
            this.yoneticiID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.yoneticiID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.yoneticiID.Location = new System.Drawing.Point(114, 93);
            this.yoneticiID.Name = "yoneticiID";
            this.yoneticiID.Size = new System.Drawing.Size(215, 27);
            this.yoneticiID.TabIndex = 7;
            this.yoneticiID.Text = "Yönetici ID";
            this.yoneticiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yoneticiID.Enter += new System.EventHandler(this.yoneticiID_Enter);
            this.yoneticiID.Leave += new System.EventHandler(this.yoneticiID_Leave);
            // 
            // btnGiris
            // 
            this.btnGiris.AutoSize = true;
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.btnGiris.Location = new System.Drawing.Point(114, 183);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(215, 44);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.sifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sifre.Location = new System.Drawing.Point(114, 150);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(215, 27);
            this.sifre.TabIndex = 8;
            this.sifre.Text = "Şifre";
            this.sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // ucYG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ucYG";
            this.Size = new System.Drawing.Size(460, 348);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.TextBox yoneticiID;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox sifre;
    }
}
