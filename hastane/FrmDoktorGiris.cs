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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Doktor TC veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void FrmDoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
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

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
            btngiris.BackColor = Color.FromArgb(180, 190, 253);
        }
    }
}
