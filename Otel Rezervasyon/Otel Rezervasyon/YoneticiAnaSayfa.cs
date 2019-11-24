using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class YoneticiAnaSayfa : Form
    {
        public YoneticiAnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YoneticiAnaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'OtelRezervasyon2DataSet.MusteriEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.MusteriEkleTableAdapter.Fill(this.OtelRezervasyon2DataSet.MusteriEkle);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void yabCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris grs = new Giris();
            grs.Show();
        }
    }
}
