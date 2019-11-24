using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Rezervasyon
{
    public partial class Dashboard : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");
        
        private void topla()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
        }
        public Dashboard()
        {

            InitializeComponent();
            ucYME1.Show();
            this.Refresh();
            ucOdalar1.Hide();
            ucMusteriler1.Hide();
            ucHakkinda1.Hide();
            ucHesap1.Hide();
            topla();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ucYME1_Load(object sender, EventArgs e)
        {
            
        }

        private void panelUst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yabYME_Click(object sender, EventArgs e)
        {
            ucYME1.Show();
            this.Refresh();
            ucOdalar1.Hide();
            ucMusteriler1.Hide();
            ucHakkinda1.Hide();
            ucHesap1.Hide();
            topla();

        }

        private void yabOdalar_Click(object sender, EventArgs e)
        {
            ucOdalar1.Show();
            this.Refresh();
            ucYME1.Hide();
            ucHakkinda1.Hide();
            topla();
            ucHesap1.Hide();
            ucMusteriler1.Hide();

        }

        private void yabMusteriler_Click(object sender, EventArgs e)
        {
            ucMusteriler1.Show();
            this.Refresh();
            ucYME1.Hide();
            ucOdalar1.Hide();
            ucHakkinda1.Hide();
            topla();
            ucHesap1.Hide();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            topla();
        }

        private void ucMusteriler1_Load(object sender, EventArgs e)
        {
        }

        private void panelTab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yabHakkinda_Click(object sender, EventArgs e)
        {
            ucHakkinda1.Show();
            ucYME1.Hide();
            ucMusteriler1.Hide();
            ucOdalar1.Hide();
            ucHesap1.Hide();
            topla();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Giris2 where KullaniciAdi='" + ucGirisYap.kullanici.ToString() + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            

            while (oku.Read())
            {

               
                    lbKullanici.Text = oku["Isim"].ToString();
                    lbSoyad.Text = oku["Soyisim"].ToString();

                
            }
            baglanti.Close();


        }

        private void yabHesabım_Click(object sender, EventArgs e)
        {
            ucHesap1.Show();
            ucHakkinda1.Hide();
            ucYME1.Hide();
            ucMusteriler1.Hide();
            ucOdalar1.Hide();
            topla();
        }
    }
}
