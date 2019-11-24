namespace Otel_Rezervasyon
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelUst = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTab = new System.Windows.Forms.Panel();
            this.yabHesabım = new System.Windows.Forms.Button();
            this.yabHakkinda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yabMusteriler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yabOdalar = new System.Windows.Forms.Button();
            this.yabYME = new System.Windows.Forms.Button();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.ucHesap1 = new Otel_Rezervasyon.ucHesap();
            this.ucHakkinda1 = new Otel_Rezervasyon.ucHakkinda();
            this.ucMusteriler1 = new Otel_Rezervasyon.ucMusteriler();
            this.ucOdalar1 = new Otel_Rezervasyon.ucOdalar();
            this.ucYME1 = new Otel_Rezervasyon.ucYME();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbKullanici = new System.Windows.Forms.Label();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTab.SuspendLayout();
            this.anaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelUst.Controls.Add(this.lblToplam);
            this.panelUst.Controls.Add(this.pictureBox1);
            this.panelUst.Controls.Add(this.label3);
            resources.ApplyResources(this.panelUst, "panelUst");
            this.panelUst.Name = "panelUst";
            this.panelUst.TabStop = true;
            this.panelUst.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUst_Paint);
            // 
            // lblToplam
            // 
            resources.ApplyResources(this.lblToplam, "lblToplam");
            this.lblToplam.ForeColor = System.Drawing.Color.Gold;
            this.lblToplam.Name = "lblToplam";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Name = "label3";
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTab.Controls.Add(this.lbSoyad);
            this.panelTab.Controls.Add(this.lbKullanici);
            this.panelTab.Controls.Add(this.yabHesabım);
            this.panelTab.Controls.Add(this.yabHakkinda);
            this.panelTab.Controls.Add(this.label2);
            this.panelTab.Controls.Add(this.yabMusteriler);
            this.panelTab.Controls.Add(this.label1);
            this.panelTab.Controls.Add(this.yabOdalar);
            this.panelTab.Controls.Add(this.yabYME);
            resources.ApplyResources(this.panelTab, "panelTab");
            this.panelTab.Name = "panelTab";
            this.panelTab.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTab_Paint);
            // 
            // yabHesabım
            // 
            resources.ApplyResources(this.yabHesabım, "yabHesabım");
            this.yabHesabım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.yabHesabım.FlatAppearance.BorderSize = 0;
            this.yabHesabım.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.yabHesabım.Name = "yabHesabım";
            this.yabHesabım.UseVisualStyleBackColor = false;
            this.yabHesabım.Click += new System.EventHandler(this.yabHesabım_Click);
            // 
            // yabHakkinda
            // 
            resources.ApplyResources(this.yabHakkinda, "yabHakkinda");
            this.yabHakkinda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.yabHakkinda.FlatAppearance.BorderSize = 0;
            this.yabHakkinda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.yabHakkinda.Name = "yabHakkinda";
            this.yabHakkinda.UseVisualStyleBackColor = false;
            this.yabHakkinda.Click += new System.EventHandler(this.yabHakkinda_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // yabMusteriler
            // 
            resources.ApplyResources(this.yabMusteriler, "yabMusteriler");
            this.yabMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.yabMusteriler.FlatAppearance.BorderSize = 0;
            this.yabMusteriler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.yabMusteriler.Name = "yabMusteriler";
            this.yabMusteriler.UseVisualStyleBackColor = false;
            this.yabMusteriler.Click += new System.EventHandler(this.yabMusteriler_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // yabOdalar
            // 
            resources.ApplyResources(this.yabOdalar, "yabOdalar");
            this.yabOdalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.yabOdalar.FlatAppearance.BorderSize = 0;
            this.yabOdalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.yabOdalar.Name = "yabOdalar";
            this.yabOdalar.UseVisualStyleBackColor = false;
            this.yabOdalar.Click += new System.EventHandler(this.yabOdalar_Click);
            // 
            // yabYME
            // 
            resources.ApplyResources(this.yabYME, "yabYME");
            this.yabYME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.yabYME.FlatAppearance.BorderSize = 0;
            this.yabYME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.yabYME.Name = "yabYME";
            this.yabYME.UseVisualStyleBackColor = false;
            this.yabYME.Click += new System.EventHandler(this.yabYME_Click);
            // 
            // anaPanel
            // 
            this.anaPanel.Controls.Add(this.ucHesap1);
            this.anaPanel.Controls.Add(this.ucHakkinda1);
            this.anaPanel.Controls.Add(this.ucMusteriler1);
            this.anaPanel.Controls.Add(this.ucOdalar1);
            this.anaPanel.Controls.Add(this.ucYME1);
            resources.ApplyResources(this.anaPanel, "anaPanel");
            this.anaPanel.Name = "anaPanel";
            // 
            // ucHesap1
            // 
            this.ucHesap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.ucHesap1, "ucHesap1");
            this.ucHesap1.Name = "ucHesap1";
            // 
            // ucHakkinda1
            // 
            this.ucHakkinda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.ucHakkinda1, "ucHakkinda1");
            this.ucHakkinda1.Name = "ucHakkinda1";
            // 
            // ucMusteriler1
            // 
            this.ucMusteriler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.ucMusteriler1, "ucMusteriler1");
            this.ucMusteriler1.Name = "ucMusteriler1";
            this.ucMusteriler1.Load += new System.EventHandler(this.ucMusteriler1_Load);
            // 
            // ucOdalar1
            // 
            this.ucOdalar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.ucOdalar1, "ucOdalar1");
            this.ucOdalar1.Name = "ucOdalar1";
            // 
            // ucYME1
            // 
            this.ucYME1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.ucYME1, "ucYME1");
            this.ucYME1.Name = "ucYME1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbKullanici
            // 
            resources.ApplyResources(this.lbKullanici, "lbKullanici");
            this.lbKullanici.ForeColor = System.Drawing.Color.White;
            this.lbKullanici.Name = "lbKullanici";
            // 
            // lbSoyad
            // 
            resources.ApplyResources(this.lbSoyad, "lbSoyad");
            this.lbSoyad.ForeColor = System.Drawing.Color.White;
            this.lbSoyad.Name = "lbSoyad";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTab.ResumeLayout(false);
            this.panelTab.PerformLayout();
            this.anaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button yabYME;
        private System.Windows.Forms.Panel anaPanel;
        private ucYME ucYME1;
        private System.Windows.Forms.Button yabOdalar;
        private ucOdalar ucOdalar1;
        private System.Windows.Forms.Button yabMusteriler;
        private ucMusteriler ucMusteriler1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yabHakkinda;
        private ucHakkinda ucHakkinda1;
        private System.Windows.Forms.Button yabHesabım;
        private ucHesap ucHesap1;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.Label lbKullanici;
    }
}