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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TCnumara;
            

            //Ad Soyad

            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from TBL_Sekreterler where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Branslar order by BransAd ASC", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad)as'Doktorlar',DoktorBrans from TBL_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("select BransAd from TBL_Branslar order by BransAd ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //datagridview tasarım
            dataGridView1.Columns[0].HeaderText = "Branş No";
            dataGridView1.Columns[1].HeaderText = "Branş Adı";
            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView1);
            fr.DatagridviewSetting(dataGridView2);


        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TBL_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", dateTimePicker1.Text);
            komutkaydet.Parameters.AddWithValue("@r2",msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            
            if(dateTimePicker1.Text == "" || msksaat.Text == "" || cmbbrans.Text == "" || cmbdoktor.Text == "")
            {
                MessageBox.Show("Yukarıdaki Tarih,Saat,Branş ve Doktor bilgisini eksiksiz giriniz lütfen!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komutkaydet.ExecuteNonQuery();
                MessageBox.Show("Randevu Başarıyla Oluşturuldu","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
            
        }

        private void Cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TBL_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void Btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchtxtduyuru.Text);

            if (rchtxtduyuru.Text == "")
            {
                MessageBox.Show("Lütfen boş duyuru oluşturmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Duyuru Oluşturuldu");
                FrmDuyurular fr = new FrmDuyurular();
                fr.btnyenile_Click(sender, e);
            }

            bgl.baglanti().Close();
            
        }

        private void Btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void Btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans brp = new FrmBrans();
            brp.Show();
        }

        private void Btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
        
        private void FrmSekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult cikis = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        public void btnsayfayiyenile_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay_Load(sender, e);
        }

        private void FrmSekreterDetay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnsayfayiyenile_Click(sender, e);
            }
        }
    }
}
