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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            //Branşları Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //datagridview tasarım
            dataGridView1.Columns[0].HeaderText = "Branş No";
            dataGridView1.Columns[1].HeaderText = "Branş Adı";
            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView1);

            //btnekle.BackColor = Color.FromArgb(255, 174, 173);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
           
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbrans.Text);

            if (txtbrans.Text == "")
            {
                MessageBox.Show("Branş adı giriniz lütfen!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Branş Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                txtid.Clear();
                txtbrans.Clear();
                FrmBrans_Load(sender, e);
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.btnsayfayiyenile_Click(sender, e);
            }

            
            bgl.baglanti().Close();
            
            
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from table TBL_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtid.Text);

             if (txtid.Text==""||txtbrans.Text == "")
            {
                MessageBox.Show("Lütfen branş seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Branş Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); txtid.Clear();
                txtid.Clear();
                txtbrans.Clear();
                FrmBrans_Load(sender, e);
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.btnsayfayiyenile_Click(sender, e);
            }

            bgl.baglanti().Close();
            
            
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Branslar set BransAd=@b2 where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtid.Text);
            komut.Parameters.AddWithValue("@b2", txtbrans.Text);

            if (txtid.Text == "" || txtbrans.Text == "")
            {
                MessageBox.Show("Lütfen branş seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Brans Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Clear();
                txtbrans.Clear();
                FrmBrans_Load(sender, e);
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.btnsayfayiyenile_Click(sender, e);
            }

            bgl.baglanti().Close();
            
        }

        private void txtbrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
