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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PersonelTakip
{
    public partial class frmKullaniciEkle : Form
    {
        Veritabani veritabani = new Veritabani();
        public frmKullaniciEkle()

        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=89.252.181.210\\MSSQLSERVER2014;Initial Catalog=mekacom_HasanDogdu;Persist Security Info=True;User ID=mekacom_HasanDogdu;Password=J0r!5y8w4");
        DataSet daSet = new DataSet();
        private void Kayit_Göster()
        {
            sqlConnection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Anasayfa", sqlConnection);
            adtr.Fill(daSet,"Anasayfa");
            dataGridView1.DataSource = daSet.Tables["Anasayfa"];
            sqlConnection.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into Anasayfa(Kullanici_Adi,Sifre) values(@Kullanici_Adi,@Sifre)", sqlConnection);
            cmd.Parameters.AddWithValue("@Kullanici_Adi", txtKullanici_Adi.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["Anasayfa"].Clear();
            Kayit_Göster();
            MessageBox.Show("Kullanıcı Kaydı Eklendi !");
            txtKullanici_Adi.Clear();
            txtSifre.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete from Anasayfa where Kullanici_Adi='" + dataGridView1.CurrentRow.Cells["Kullanici_Adi"].Value.ToString() + "'", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["Anasayfa"].Clear();
            Kayit_Göster();
            MessageBox.Show("Kayıt Silindi !");
            txtKullanici_Adi.Clear();
            txtSifre.Clear();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullanici_Adi.Text = dataGridView1.CurrentRow.Cells["Kullanici_Adi"].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells["Sifre"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            Kayit_Göster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update Anasayfa set Sifre=@Sifre where Kullanici_Adi=@Kullanici_Adi", sqlConnection);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@Kullanici_Adi", txtKullanici_Adi.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["Anasayfa"].Clear();
            Kayit_Göster();
            MessageBox.Show("Güncelleme başarılı !");
            txtKullanici_Adi.Clear();
            txtSifre.Clear();
        }
    }
}
