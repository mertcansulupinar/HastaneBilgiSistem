using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane
{
    class sqlbaglantisi
    {
        BaglantiSinifi bgl1 = new BaglantiSinifi();
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(bgl1.Adres);
            baglan.Open();
            return baglan;
        }

    }
}
