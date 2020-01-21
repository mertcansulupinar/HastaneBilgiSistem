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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {

            //Kayıtlı Doktorları Getirme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBL_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branşları ComboBox a Getirme
            SqlCommand komut2 = new SqlCommand("select BransAd from TBL_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            dataGridView1.Columns[0].HeaderText = "Randevu ID";
            dataGridView1.Columns[1].HeaderText = "Doktor Adı";
            dataGridView1.Columns[2].HeaderText = "Doktor Soyadı";
            dataGridView1.Columns[3].HeaderText = "Doktor Branşı";
            dataGridView1.Columns[4].HeaderText = "Doktor TC";
            dataGridView1.Columns[5].HeaderText = "Doktor Şifre";
            dataGridView1.Columns[0].Visible = false;

            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView1);
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);

            if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == ""||txtsifre.Text=="")
            {
                MessageBox.Show("Yukarıdaki bilgileri eksiksiz giriniz lütfen!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Doktor Başarıyla Eklendi, Şifresi: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtad.Clear();
                txtsoyad.Clear();
                cmbbrans.Text = "";
                msktc.Clear();
                txtsifre.Clear();
                FrmDoktorPaneli_Load(sender, e);
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.btnsayfayiyenile_Click(sender, e);
            }

            bgl.baglanti().Close();
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);

            if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz doktoru seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtad.Clear();
                txtsoyad.Clear();
                cmbbrans.Text = "";
                msktc.Clear();
                txtsifre.Clear();
                FrmDoktorPaneli_Load(sender, e);
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.btnsayfayiyenile_Click(sender, e);
            }

            bgl.baglanti().Close();
           
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);

            if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Yukarıdaki bilgileri eksiksiz giriniz lütfen!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Doktor Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); txtad.Clear();
                txtsoyad.Clear();
                cmbbrans.Text = "";
                msktc.Clear();
                txtsifre.Clear();
                FrmDoktorPaneli_Load(sender, e);
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.btnsayfayiyenile_Click(sender, e);
            }

            bgl.baglanti().Close();
            
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
