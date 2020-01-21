using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Btnkayityap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);

            if (txtad.Text == "" || txtsoyad.Text == "" || msktc.Text == "" || msktelefon.Text == ""||txtsifre.Text==""||cmbcinsiyet.Text=="")
            {
                MessageBox.Show("Yukarıdaki bilgileri eksiksiz giriniz lütfen!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            bgl.baglanti().Close();
            

        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {
            btnkayityap.BackColor = Color.FromArgb(180, 190, 253);
        }

        private void btngizle_Click(object sender, EventArgs e)
        {
            if (txtsifre.UseSystemPasswordChar)
            {
                txtsifre.UseSystemPasswordChar = false;
                btngizle.BackgroundImage = global::hastane.Properties.Resources.eye_open;
            }


            else
            {
                txtsifre.UseSystemPasswordChar = true;
                btngizle.BackgroundImage = global::hastane.Properties.Resources.eye_close;
            }
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
