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
    public partial class ucYME : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");
        public ucYME()
        {
            InitializeComponent();
            
        }
        private void ad_Enter(object sender, EventArgs e)
        {
            if (ad.Text == "Ad")
            {
                ad.Text = "";
                ad.ForeColor = Color.Black;
            }
        }

        private void ad_Leave(object sender, EventArgs e)
        {
            if (ad.Text == "")
            {
                ad.Text = "Ad";
                ad.ForeColor = Color.Silver;
            }
        }

        private void soyad_Enter(object sender, EventArgs e)
        {
            if (soyad.Text == "Soyad")
            {
                soyad.Text = "";
                soyad.ForeColor = Color.Black;
            }
        }

        private void soyad_Leave(object sender, EventArgs e)
        {
            if (soyad.Text == "")
            {
                soyad.Text = "Soyad";
                soyad.ForeColor = Color.Silver;
            }
        }

        private void telNo_Enter(object sender, EventArgs e)
        {
            if (telNo.Text == "(500) 000-0000")
            {
                telNo.Text = "";
                telNo.ForeColor = Color.Black;
            }
        }

        private void telNo_Leave(object sender, EventArgs e)
        {
            if (telNo.Text == "(   )    -")
            {
                telNo.Text = "(500) 000-0000";
                telNo.ForeColor = Color.Silver;
            }
        }

        private void cikisTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mail_Enter(object sender, EventArgs e)
        {
            if (mail.Text == "someone@example.com")
            {
                mail.Text = "";
                mail.ForeColor = Color.Black;
            }
        }

        private void mail_Leave(object sender, EventArgs e)
        {
            if (mail.Text == "")
            {
                mail.Text = "someone@example.com";
                mail.ForeColor = Color.Silver;
            }
        }

        private void tcNo_Enter(object sender, EventArgs e)
        {
            if (tcNo.Text == "T.C Kimlik Numarası")
            {
                tcNo.Text = "";
                tcNo.ForeColor = Color.Black;
            }
        }

        private void tcNo_Leave(object sender, EventArgs e)
        {
            if (tcNo.Text == "")
            {
                tcNo.Text = "T.C Kimlik Numarası";
                tcNo.ForeColor = Color.Silver;
            }
        }

        private void odaNo_Click(object sender, EventArgs e)
        {

        }

        private void odaNo_Enter(object sender, EventArgs e)
        {
            if (odaNo.Text == "Oda No")
            {
                odaNo.Text = "";
                odaNo.ForeColor = Color.Black;
            }
        }

        private void odaNo_Leave(object sender, EventArgs e)
        {
            if (odaNo.Text == "")
            {
                odaNo.Text = "Oda No";
                odaNo.ForeColor = Color.Silver;
            }
        }

        

        private void ucret_Enter(object sender, EventArgs e)
        {
            if (ucret.Text == "Ücret")
            {
                ucret.Text = "";
                ucret.ForeColor = Color.Black;
            }
        }

        private void ucret_Leave(object sender, EventArgs e)
        {
            if (ucret.Text == "")
            {
                ucret.Text = "Ücret";
                ucret.ForeColor = Color.Silver;
            }
        }

        private void oda1_Click(object sender, EventArgs e)
        {
            odaNo.Text = "101";
        }

        private void oda2_Click(object sender, EventArgs e)
        {
            odaNo.Text = "102";
        }

        private void oda3_Click(object sender, EventArgs e)
        {
            odaNo.Text = "103";
        }

        private void oda4_Click(object sender, EventArgs e)
        {
            odaNo.Text = "104";
        }

        private void oda5_Click(object sender, EventArgs e)
        {
            odaNo.Text = "105";
        }

        private void oda6_Click(object sender, EventArgs e)
        {
            odaNo.Text = "106";
        }

        private void oda7_Click(object sender, EventArgs e)
        {
            odaNo.Text = "107";
        }

        private void oda8_Click(object sender, EventArgs e)
        {
            odaNo.Text = "108";
        }

        private void oda9_Click(object sender, EventArgs e)
        {
            odaNo.Text = "109";
        }

        private void oda10_Click(object sender, EventArgs e)
        {
            odaNo.Text = "110";
        }

        private void oda11_Click(object sender, EventArgs e)
        {
            odaNo.Text = "111";
        }

        private void oda12_Click(object sender, EventArgs e)
        {
            odaNo.Text = "112";
        }

        private void ucret_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcNo_Enter_1(object sender, EventArgs e)
        {
            if (tcNo.Text == "T.C Kimlik Numarası")
            {
                tcNo.Text = "";
                tcNo.ForeColor = Color.Black;
            }
        }

        private void tcNo_Leave_1(object sender, EventArgs e)
        {
            if (tcNo.Text == "")
            {
                tcNo.Text = "T.C Kimlik Numarası";
                tcNo.ForeColor = Color.Silver;
            }
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
        private void ucYME_Load(object sender, EventArgs e)
        {
            yenile();
        }

        

        private void tema_Opening(object sender, CancelEventArgs e)
        {

        }

        private void aTema_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Wheat;
            label1.BackColor = Color.Wheat;
            label2.BackColor = Color.Wheat;
        }

        private void kTema_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 44);
        }
        private void temizle()
        {
            ad.Text = "Ad";
            soyad.Text = "Soyad";
            telNo.Text = "(500) 000-0000";
            mail.Text = "someone@example.com";
            tcNo.Text = "T.C Kimlik Numarası";
            odaNo.Text = "Oda No";
            ucret.Text = "Ücret";
            girisTarihi.Text = "";
            cikisTarihi.Text = "";


        }

        private void btnYME_Click(object sender, EventArgs e)
        {
            if (ad.Text=="Ad" || soyad.Text=="Soyad" || telNo.Text== "(500) 000-0000" || mail.Text== "someone@example.com" || tcNo.Text == "T.C Kimlik Numarası" || odaNo.Text == "Oda No" ||ucret.Text == "Ücret" || girisTarihi.Text == "" ||cikisTarihi.Text == "")
            {
                MessageBox.Show("Kayıt Yerleri Boş Bırakılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Telefon,Mail,TCno,Odano,Ucret,Giristarihi,Cikistarihi) values('" + ad.Text + "','" + soyad.Text + "','" + telNo.Text + "','" + mail.Text + "','" + tcNo.Text + "','" + odaNo.Text + "','" + ucret.Text + "','" + girisTarihi.Value.ToString("yyyy-MM-dd") + "','" + cikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
                sqlKomut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı");
                temizle();
                yenile();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            yenile();
        }
        //dattimepicker arkaplan rengi başlangıç

        //dattimepicker arkaplan rengi bitiş
    }
}
