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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            ucGirisYap1.Show();
            ucKayitOl1.Hide();

            
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Move(object sender, EventArgs e)
        {

        }

        private void tabGirisYap_Click(object sender, EventArgs e)
        {
            ucGirisYap1.Show();
            ucKayitOl1.Hide();
            ucYG1.Hide();
        }

        private void tabKayitOl_Click(object sender, EventArgs e)
        {
            ucKayitOl1.Show();
            ucGirisYap1.Hide();
            ucYG1.Hide();
        }

        private void ucKayitOl1_Load(object sender, EventArgs e)
        {

        }

        private void ucGirisYap1_Load(object sender, EventArgs e)
        {

        }

        private void panelTab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabYG_Click(object sender, EventArgs e)
        {
            ucYG1.Show();
            ucKayitOl1.Hide();
            ucGirisYap1.Hide();
        }

        private void ucYG1_Load(object sender, EventArgs e)
        {

        }
    }
}
