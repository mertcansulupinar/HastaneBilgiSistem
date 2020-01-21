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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNO;

            SqlCommand komut = new SqlCommand("select * from TBL_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("select  BransAd from TBL_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            /*

//Connection oluşturup açıyoruz.


OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:ProjectsCalisma.accdb");


            c.Open();


            //Öncelikli olarak biz combobox a bişeyler yazmaya başladığımızda içinde arama yapılacak yapıdan bir nesne oluşturuyoruz.


            AutoCompleteStringCollection aCsC = new AutoCompleteStringCollection();


            DataTable dt = new DataTable();


            string sql = "Select urunAdi From Urunler";


            OleDbDataAdapter da = new OleDbDataAdapter(sql, c);


            da.Fill(dt);


            //Bu for döngüsü ile datatable deki verilerimizi,içinde arama yapacağımız koleksiyona teker teker ekliyoruz.


            for (int i = 0; i < dt.Rows.Count; i++)


            {


                aCsC.Add(dt.Rows[0].ToString());


            }


            //cb combobox ımızın ismi.comboboxımızın hangi koleksiyonu kullanacağını belirtiyoruz.


            cb.AutoCompleteCustomSource = aCsC;


            //combobox ımızı datatable ile dolduruyoruz.


            cb.DataSource = dt;





            c.Close();
            */


        }



        private void Btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
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
