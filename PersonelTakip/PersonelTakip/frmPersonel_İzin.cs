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
    public partial class frmPersonel_İzin : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=89.252.181.210\\MSSQLSERVER2014;Initial Catalog=mekacom_HasanDogdu;Persist Security Info=True;User ID=mekacom_HasanDogdu;Password=J0r!5y8w4");
        DataSet daSet = new DataSet();
        private void Kayit_Göster()
        {
            sqlConnection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from İzinler", sqlConnection);
            adtr.Fill(daSet, "İzinler");
            dataGridView1.DataSource = daSet.Tables["İzinler"];
            sqlConnection.Close();

        }
        public frmPersonel_İzin()
        {
            InitializeComponent();
        }

        private void frmPersonel_İzin_Load(object sender, EventArgs e)
        {
            Kayit_Göster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into İzinler(Ad_Soyad,Tc,Telefon,Departman,İzin_Gün_Sayisi,İzin_Baslangic,İzin_Bitis) values (@Ad_Soyad,@Tc,@Telefon,@Departman,@İzin_Gün_Sayisi,@İzin_Baslangic,@İzin_Bitis)", sqlConnection);
            cmd.Parameters.AddWithValue("@Ad_Soyad", txtAd_Soyad.Text);
            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@İzin_Gün_Sayisi", txtİzin_Gün_Sayisi.Text);
            cmd.Parameters.AddWithValue("@Departman", txtDepartman.Text);
            cmd.Parameters.AddWithValue("@İzin_Baslangic", txtİzin_Baslangic.Text);
            cmd.Parameters.AddWithValue("@İzin_Bitis", txtİzin_Bitis.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["İzinler"].Clear();
            Kayit_Göster();
            MessageBox.Show("Personel İzin Kaydı Eklendi !");
            txtAd_Soyad.Clear();
            txtTc.Clear();
            txtİzin_Gün_Sayisi.Clear();
            txtTelefon.Clear();
            txtDepartman.Clear();
            txtİzin_Baslangic.Clear();
            txtİzin_Bitis.Clear();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete from İzinler where Tc='" + dataGridView1.CurrentRow.Cells["Tc"].Value.ToString() + "'", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["İzinler"].Clear();
            Kayit_Göster();
            MessageBox.Show("İzin Kaydı Silindi !");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update İzinler set Ad_Soyad=@Ad_Soyad,Telefon=@Telefon,Departman=@Departman,İzin_Gün_Sayisi=@İzin_Gün_Sayisi,İzin_Baslangic=@İzin_Baslangic,İzin_Bitis=@İzin_Bitis where Tc=@Tc", sqlConnection);
            cmd.Parameters.AddWithValue("@Ad_Soyad", txtAd_Soyad.Text);
            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@İzin_Gün_Sayisi", txtİzin_Gün_Sayisi.Text);
            cmd.Parameters.AddWithValue("@Departman", txtDepartman.Text);
            cmd.Parameters.AddWithValue("@İzin_Baslangic", txtİzin_Baslangic.Text);
            cmd.Parameters.AddWithValue("@İzin_Bitis", txtİzin_Bitis.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["İzinler"].Clear();
            Kayit_Göster();
            MessageBox.Show("Personel İzin Kaydı Güncellendi !");
            txtAd_Soyad.Clear();
            txtTc.Clear();
            txtİzin_Gün_Sayisi.Clear();
            txtTelefon.Clear();
            txtDepartman.Clear();
            txtİzin_Baslangic.Clear();
            txtİzin_Bitis.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd_Soyad.Text = dataGridView1.CurrentRow.Cells["Ad_Soyad"].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            txtİzin_Gün_Sayisi.Text = dataGridView1.CurrentRow.Cells["İzin_Gün_Sayisi"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells["Departman"].Value.ToString();
            txtİzin_Baslangic.Text = dataGridView1.CurrentRow.Cells["İzin_Baslangic"].Value.ToString();
            txtİzin_Bitis.Text = dataGridView1.CurrentRow.Cells["İzin_Bitis"].Value.ToString();
        }
    }
}
