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
    public partial class ucYG : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");

        public ucYG()
        {
            InitializeComponent();
        }

        private void yoneticiID_Enter(object sender, EventArgs e)
        {
            if(yoneticiID.Text=="Yönetici ID")
            {
                yoneticiID.Text = "";
                yoneticiID.ForeColor = Color.Black;
            }
        }

        private void yoneticiID_Leave(object sender, EventArgs e)
        {
            if (yoneticiID.Text == "")
            {
                yoneticiID.Text = "Yönetici ID";
                yoneticiID.ForeColor = Color.Silver;
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from YGiris where KullaniciID=@kullaniciAdi AND Sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("kullaniciAdi", yoneticiID.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    YoneticiAnaSayfa yas = new YoneticiAnaSayfa();
                    this.ParentForm.Hide();
                    yas.Show();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            
        }
    }
}
