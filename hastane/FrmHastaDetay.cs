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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from TBL_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("select  BransAd from TBL_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //datagridview tasarım
            dataGridView1.Columns[0].HeaderText = "Randevu No";
            dataGridView1.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[2].HeaderText = "Randevu Saat";
            dataGridView1.Columns[3].HeaderText = "Randevu Branşı";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Randevu Durumu";
            dataGridView1.Columns[6].HeaderText = "Hasta TC";
            dataGridView1.Columns[7].HeaderText = "Hasta Şikayet";

            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView1);
            fr.DatagridviewSetting(dataGridView2);

            

        }

        private void Cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from TBL_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void Cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Randevular where RandevuBrans='" + cmbbrans.Text + "'" + "and RandevuDoktor='" + cmbdoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            dataGridView2.Columns[0].HeaderText = "Randevu No";
            dataGridView2.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView2.Columns[2].HeaderText = "Randevu Saat";
            dataGridView2.Columns[3].HeaderText = "Randevu Branşı";
            dataGridView2.Columns[4].HeaderText = "Doktor";
            dataGridView2.Columns[5].HeaderText = "Randevu Durumu";
            dataGridView2.Columns[6].HeaderText = "Hasta TC";
            dataGridView2.Columns[7].HeaderText = "Hasta Şikayet";

            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView2);


        }

        private void Lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenleme fr = new FrmBilgiDüzenleme();
            fr.TCno = lbltc.Text;
            fr.Show();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", rchtxtsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);

            if (txtid.Text == "" || lbltc.Text == "" || cmbbrans.Text == "" || cmbdoktor.Text == "" || rchtxtsikayet.Text == "")
            {
                MessageBox.Show("Yukarıdaki kısımları eksiksiz giriniz lütfen!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            bgl.baglanti().Close();

        }

        private void FrmHastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }
    }
}
