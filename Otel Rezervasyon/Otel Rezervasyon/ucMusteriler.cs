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
    public partial class ucMusteriler : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RIV97KL\\SQLEXPRESS;Initial Catalog=OtelRezervasyon2;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCno"].ToString());
                ekle.SubItems.Add(oku["Odano"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Giristarihi"].ToString());
                ekle.SubItems.Add(oku["Cikistarihi"].ToString());

                listView1.Items.Add(ekle); 
            }
            baglanti.Close();
        }
        public ucMusteriler()
        {
            InitializeComponent();
        }

        private void ucMusteriler_Load(object sender, EventArgs e)
        {
            verilerigoster();
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

        private void ara_Enter(object sender, EventArgs e)
        {
            if (ara.Text == "İsme Göre Ara")
            {
                ara.Text = "";
                ara.ForeColor = Color.Black;

            }
        }

        private void ara_Leave(object sender, EventArgs e)
        {
            if (ara.Text=="")
            {
                ara.Text = "İsme Göre Ara";
                ara.ForeColor = Color.Silver;
            }
        }
        int id = 0;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            soyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            telNo.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            tcNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            odaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            ucret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            girisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            cikisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            timer1.Start();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void ucret_TextChanged(object sender, EventArgs e)
        {

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
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ad.Text != "Ad" && soyad.Text != "Soyad" && telNo.Text != "(500) 000-0000" && mail.Text != "someone@example.com" && tcNo.Text != "T.C Kimlik Numarası" && odaNo.Text != "Oda No" && ucret.Text != "Ücret" && girisTarihi.Text != "" && cikisTarihi.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                temizle();
            }
            else
            {
                MessageBox.Show("Kayıt Yerleri Boş Bırakılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ad.Text != "Ad" && soyad.Text != "Soyad" && telNo.Text != "(500) 000-0000" && mail.Text != "someone@example.com" && tcNo.Text != "T.C Kimlik Numarası" && odaNo.Text != "Oda No" && ucret.Text != "Ücret" && girisTarihi.Text != "" && cikisTarihi.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + ad.Text + "',Soyadi='" + soyad.Text + "',Telefon='" + telNo.Text + "',Mail='" + mail.Text + "',TCno='" + tcNo.Text + "',Odano='" + odaNo.Text + "',Ucret='" + ucret.Text + "',Giristarihi='" + girisTarihi.Value.ToString("yyyy-MM-dd") + "',Cikistarihi='" + cikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                temizle();
            }
            else
            {
                MessageBox.Show("Kayıt Yerleri Boş Bırakılamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temizle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + ara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCno"].ToString());
                ekle.SubItems.Add(oku["Odano"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Giristarihi"].ToString());
                ekle.SubItems.Add(oku["Cikistarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void odaNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
