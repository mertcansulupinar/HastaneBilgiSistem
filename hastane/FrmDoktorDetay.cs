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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void Btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TBL_Doktorlar where  DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Randevular where RandevuDoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Randevu No";
            dataGridView1.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[2].HeaderText = "Randevu Saat";
            dataGridView1.Columns[3].HeaderText = "Randevu Branşı";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Randevu Durumu";
            dataGridView1.Columns[6].HeaderText = "Hasta TC";
            dataGridView1.Columns[7].HeaderText = "Hasta Şikayet";
            dataGridView1.Columns[4].Visible = false;

            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView1);
        }

        private void Btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO = lbltc.Text;
            fr.Show();
        }

        private void Btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchtxtrandevudetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void FrmDoktorDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void btngirisegit_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }
    }
}
