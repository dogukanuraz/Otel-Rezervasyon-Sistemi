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
    public partial class ucHesap : UserControl
    {
        public ucHesap()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text != "Kullanıcı Adı" && ad.Text != "İsim" && soyad.Text != "Soyisim" && imail.Text != "someone@example.com" && sifre.Text != "Şifre")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Giris2 set KullaniciAdi='" + kullaniciAdi.Text + "',Isim='" + ad.Text + "',Soyisim='" + soyad.Text + "',Mail='" + imail.Text + "',Sifre='" + sifre.Text+"' ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kayıt Yerleri Boş Bırakılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucHesap_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            baglanti.Close();
            
        }

       
    }
}
