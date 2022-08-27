using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class frmPersonel_Gider : Form
    {
        public frmPersonel_Gider()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=89.252.181.210\\MSSQLSERVER2014;Initial Catalog=mekacom_HasanDogdu;Persist Security Info=True;User ID=mekacom_HasanDogdu;Password=J0r!5y8w4");
        DataSet daSet = new DataSet();
        private void Kayit_Göster()
        {
            sqlConnection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Personel_Liste", sqlConnection);
            adtr.Fill(daSet, "Personel_Liste");
            dataGridView1.DataSource = daSet.Tables["Personel_Liste"];
            sqlConnection.Close();

        }
        private void frmPersonel_Gider_Load(object sender, EventArgs e)
        {
            Kayit_Göster();
        }
        int sayitopla = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Bilgi_islem_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand topla = new SqlCommand("select Maas from Personel_Liste", sqlConnection);
            SqlDataReader veriOku = topla.ExecuteReader();
            while (veriOku.Read())
            {
                sayitopla += Convert.ToInt16(veriOku["Maas"]);
            }
            txtEnsonToplam.Text = sayitopla.ToString();
            topla.Dispose();
            veriOku.Close();
        }
    }
}
