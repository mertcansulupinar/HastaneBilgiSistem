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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_Randevular order by Randevuid DESC", bgl.baglanti());
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

            FrmDuyurular fr = new FrmDuyurular();
            fr.DatagridviewSetting(dataGridView1);
        }
        
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            


        }
    }
}
