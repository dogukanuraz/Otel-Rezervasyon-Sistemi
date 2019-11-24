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
    public partial class ucGirisYap : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");
        public static string kullanici = "";
        public ucGirisYap()
        {
            InitializeComponent();
        }
        
        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Enter(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text == "Kullanıcı Adı")
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

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from Giris2 where KullaniciAdi=@kullaniciAdi AND Sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("kullaniciAdi", kullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    kullanici = kullaniciAdi.Text;
                    Dashboard db = new Dashboard();
                    db.Show();
                    this.ParentForm.Hide();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            //Dashboard dash = new Dashboard();
            //dash.Show();
            //this.ParentForm.Hide();
                        
        }
    }
}
