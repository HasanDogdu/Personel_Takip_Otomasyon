using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip

{
    public class Veritabani
    {
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=89.252.181.210\MSSQLSERVER2014;Initial Catalog=mekacom_HasanDogdu;Persist Security Info=True;User ID=mekacom_HasanDogdu;Password=J0r!5y8w4");
        public void BaglantiKur()

        {
            if (sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
    }
}
