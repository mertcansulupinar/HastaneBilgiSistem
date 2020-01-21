using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane
{
    class BaglantiSinifi
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\connection.txt");
    }
}
