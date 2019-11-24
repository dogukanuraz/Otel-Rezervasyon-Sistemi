namespace Otel_Rezervasyon
{
    partial class YoneticiAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiAnaSayfa));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelTab = new System.Windows.Forms.Panel();
            this.yabCikis = new System.Windows.Forms.Button();
            this.panelUst = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OtelRezervasyon2DataSet = new Otel_Rezervasyon.OtelRezervasyon2DataSet();
            this.MusteriEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MusteriEkleTableAdapter = new Otel_Rezervasyon.OtelRezervasyon2DataSetTableAdapters.MusteriEkleTableAdapter();
            this.gradientPanel3 = new Otel_Rezervasyon.GradientPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTab.SuspendLayout();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyon2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriEkleBindingSource)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTab.Controls.Add(this.yabCikis);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTab.Location = new System.Drawing.Point(0, 32);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(150, 463);
            this.panelTab.TabIndex = 7;
            // 
            // yabCikis
            // 
            this.yabCikis.AutoSize = true;
            this.yabCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.yabCikis.FlatAppearance.BorderSize = 0;
            this.yabCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yabCikis.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.yabCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(235)))));
            this.yabCikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yabCikis.Location = new System.Drawing.Point(0, 416);
            this.yabCikis.Name = "yabCikis";
            this.yabCikis.Size = new System.Drawing.Size(150, 44);
            this.yabCikis.TabIndex = 6;
            this.yabCikis.Text = "Çıkış";
            this.yabCikis.UseVisualStyleBackColor = false;
            this.yabCikis.Click += new System.EventHandler(this.yabCikis_Click);
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelUst.Controls.Add(this.pictureBox2);
            this.panelUst.Controls.Add(this.pictureBox1);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(807, 32);
            this.panelUst.TabIndex = 6;
            this.panelUst.TabStop = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(775, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(866, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OtelRezervasyon2DataSet
            // 
            this.OtelRezervasyon2DataSet.DataSetName = "OtelRezervasyon2DataSet";
            this.OtelRezervasyon2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MusteriEkleBindingSource
            // 
            this.MusteriEkleBindingSource.DataMember = "MusteriEkle";
            this.MusteriEkleBindingSource.DataSource = this.OtelRezervasyon2DataSet;
            // 
            // MusteriEkleTableAdapter
            // 
            this.MusteriEkleTableAdapter.ClearBeforeFill = true;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel3.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel3.Controls.Add(this.reportViewer1);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel3.Location = new System.Drawing.Point(150, 32);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(657, 463);
            this.gradientPanel3.TabIndex = 9;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MusteriEkleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Rezervasyon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(657, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // YoneticiAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 495);
            this.Controls.Add(this.gradientPanel3);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoneticiAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiAnaSayfa";
            this.Load += new System.EventHandler(this.YoneticiAnaSayfa_Load);
            this.panelTab.ResumeLayout(false);
            this.panelTab.PerformLayout();
            this.panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyon2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriEkleBindingSource)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button yabCikis;
        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private GradientPanel gradientPanel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MusteriEkleBindingSource;
        private OtelRezervasyon2DataSet OtelRezervasyon2DataSet;
        private OtelRezervasyon2DataSetTableAdapters.MusteriEkleTableAdapter MusteriEkleTableAdapter;
    }
}