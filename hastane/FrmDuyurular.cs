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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Duyurular order by Duyuruid DESC", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //sayfanın her 5 saniyede yenilenmesi

            timer1.Interval = 5000;
            timer1.Enabled = true;

            //duyurular Datagridview tasarım
            dataGridView1.Columns[0].HeaderText = "Duyuru No";
            dataGridView1.Columns[1].HeaderText = "Duyurular";
            DatagridviewSetting(dataGridView1);

        }
        //Datagrid tasarımı
        public void DatagridviewSetting(DataGridView datagridview)
        {
            datagridview.BorderStyle = BorderStyle.FixedSingle;
            datagridview.BackgroundColor = Color.AntiqueWhite;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 210);
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            datagridview.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.RowHeadersVisible = false;
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void btnyenile_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Enabled = true;

            FrmDuyurular_Load(sender, e);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            btnyenile.PerformClick();
        }
    }
}
