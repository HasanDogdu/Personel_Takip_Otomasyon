using PersonelTakip;
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
    public partial class frmGiris : Form
    {
        Veritabani veritabani= new Veritabani();
        
        public frmGiris()
        {
            InitializeComponent();
        }



        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=89.252.181.210\\MSSQLSERVER2014;Initial Catalog=mekacom_HasanDogdu;Persist Security Info=True;User ID=mekacom_HasanDogdu;Password=J0r!5y8w4");

        public void GirisYap()
        {
            if (txtKullanici_Adi.Text != "" && txtSifre.Text != "")
            {
                sqlConnection.Open();
                SqlCommand giris = new SqlCommand();
                veritabani.BaglantiKur();
                giris.Connection = sqlConnection;
                giris.CommandText = "select * from Anasayfa where Kullanici_Adi='" + txtKullanici_Adi.Text + "'AND Sifre='" + txtSifre.Text + "'";
                SqlDataReader dr = giris.ExecuteReader();
                
                if (dr.Read())
                {
                    this.Hide();
                    frmAnasayfa anasayfa = new frmAnasayfa();

                    anasayfa.ShowDialog();
                    sqlConnection.Close();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve Şifre Hatalı/Eksik !");
            }
            veritabani.sqlConnection.Close();
            
        }
private void btnGiris_Click(object sender, EventArgs e)
        {

            GirisYap();



        }
    }
}
