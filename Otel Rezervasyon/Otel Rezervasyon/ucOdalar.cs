using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Otel_Rezervasyon
{
    public partial class ucOdalar : UserControl
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");

        public ucOdalar()
        {
            InitializeComponent();
        }
        private void yenile()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                label1.Text = oku["Odano"].ToString();
                if (label1.Text == "101")
                {
                    oda1.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda1.BackColor = Color.Firebrick;
                    oda1.Enabled = false;
                }


                if (label1.Text == "102")
                {
                    oda2.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda2.BackColor = Color.Firebrick;
                    oda2.Enabled = false;
                }



                if (label1.Text == "103")
                {
                    oda3.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda3.BackColor = Color.Firebrick;
                    oda3.Enabled = false;
                }

                if (label1.Text == "104")
                {
                    oda4.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda4.BackColor = Color.Firebrick;
                    oda4.Enabled = false;
                }

                if (label1.Text == "105")
                {
                    oda5.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda5.BackColor = Color.Firebrick;
                    oda5.Enabled = false;
                }

                if (label1.Text == "106")
                {
                    oda6.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda6.BackColor = Color.Firebrick;
                    oda6.Enabled = false;
                }

                if (label1.Text == "107")
                {
                    oda7.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda7.BackColor = Color.Firebrick;
                    oda7.Enabled = false;
                }

                if (label1.Text == "108")
                {
                    oda8.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda8.BackColor = Color.Firebrick;
                    oda8.Enabled = false;
                }

                if (label1.Text == "109")
                {
                    oda9.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda9.BackColor = Color.Firebrick;
                    oda9.Enabled = false;
                }

                if (label1.Text == "110")
                {
                    oda10.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda10.BackColor = Color.Firebrick;
                    oda10.Enabled = false;
                }

                if (label1.Text == "111")
                {
                    oda11.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda11.BackColor = Color.Firebrick;
                    oda11.Enabled = false;
                }

                if (label1.Text == "112")
                {
                    oda12.Text = oku["Adi"].ToString() + "\n" + oku["Soyadi"].ToString();
                    oda12.BackColor = Color.Firebrick;
                    oda12.Enabled = false;
                }

            }
            baglanti.Close();
        }
        private void ucOdalar_Load(object sender, EventArgs e)
        {

            yenile();


        }

        private void ucOdalar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            yenile();
        }
    }
}
