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
    public partial class ucKayitOl : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");

        public ucKayitOl()
        {
            InitializeComponent();
        }

        private void id_Enter(object sender, EventArgs e)
        {
            if(kullaniciAdi.Text=="Kullanıcı Adı")
            {
                kullaniciAdi.Text = "";
                kullaniciAdi.ForeColor = Color.Black;
            }
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text == "")
            {
                kullaniciAdi.Text = "Kullanıcı Adı";
                kullaniciAdi.ForeColor = Color.Silver;
            }
        }

        private void ad_Enter(object sender, EventArgs e)
        {
            if (ad.Text == "İsim")
            {
                ad.Text = "";
                ad.ForeColor = Color.Black;
            }
        }

        private void ad_Leave(object sender, EventArgs e)
        {
            if (ad.Text == "")
            {
                ad.Text = "İsim";
                ad.ForeColor = Color.Silver;
            }
        }

        private void soyad_Enter(object sender, EventArgs e)
        {
            if (soyad.Text == "Soyisim")
            {
                soyad.Text = "";
                soyad.ForeColor = Color.Black;
            }
        }

        private void soyad_Leave(object sender, EventArgs e)
        {
            if (soyad.Text == "")
            {
                soyad.Text = "Soyisim";
                soyad.ForeColor = Color.Silver;
            }
        }

        

        private void imail_Leave(object sender, EventArgs e)
        {
            if (imail.Text == "")
            {
                imail.Text = "someone@example.com";
                imail.ForeColor = Color.Silver;
            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Şifre")
            {
                sifre.Text = "";
                sifre.ForeColor = Color.Black;
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre";
                sifre.ForeColor = Color.Silver;
            }
        }

        private void imail_Enter(object sender, EventArgs e)
        {
            if (imail.Text == "someone@example.com")
            {
                imail.Text = "";
                imail.ForeColor = Color.Black;
            }
        }

        private void imail_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text!="Kullanıcı Adı" && ad.Text!="İsim" && soyad.Text!="Soyisim" && imail.Text!= "someone@example.com" && sifre.Text!= "Şifre")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Giris2(KullaniciAdi,Sifre,Isim,Soyisim,Mail) values('" + kullaniciAdi.Text + "','" + sifre.Text + "','" + ad.Text + "','" + soyad.Text + "','" + imail.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kayıt Yerleri Boş Bırakılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
