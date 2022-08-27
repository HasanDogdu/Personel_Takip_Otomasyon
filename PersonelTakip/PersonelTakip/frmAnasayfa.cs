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
    public partial class frmAnasayfa : Form

    {
        Veritabani veritabani = new Veritabani();
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=89.252.181.210\\MSSQLSERVER2014;Initial Catalog=mekacom_HasanDogdu;Persist Security Info=True;User ID=mekacom_HasanDogdu;Password=J0r!5y8w4");
        DataSet daSet = new DataSet();
        private void Kayit_Göster()
        {
            sqlConnection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Personel_Liste",sqlConnection);
            adtr.Fill(daSet, "Personel_Liste");
            dataGridView1.DataSource = daSet.Tables["Personel_Liste"];
            sqlConnection.Close();

        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            frmPersonel_İzin departmanlar = new frmPersonel_İzin();
            departmanlar.ShowDialog();

        }

        private void btnPersonel_ekle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into Personel_Liste(Ad_Soyad,Tc,Mail,Telefon,Departman,Maas) values(@Ad_Soyad,@Tc,@Mail,@Telefon,@Departman,@Maas)", sqlConnection);
            cmd.Parameters.AddWithValue("@Ad_Soyad", txtAd_Soyad.Text);
            cmd.Parameters.AddWithValue("@Tc",txtTc.Text);
            cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@Departman", txtDepartman.Text);
            cmd.Parameters.AddWithValue("@Maas", txtMaas.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["Personel_Liste"].Clear();
            Kayit_Göster();
            MessageBox.Show("Personel Kaydı Eklendi !");
            txtAd_Soyad.Clear();
            txtTc.Clear();
            txtMail.Clear();
            txtTelefon.Clear();
            txtDepartman.Clear();
            txtMaas.Clear();

        }

        private void btnPersonel_listele_Click(object sender, EventArgs e)
        {
            frmPersonel_Gider personel_Gider = new frmPersonel_Gider();
            personel_Gider.ShowDialog();
        }

        private void btnDepartman_Ekle_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd_Soyad.Text = dataGridView1.CurrentRow.Cells["Ad_Soyad"].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            txtMail.Text= dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
           txtTelefon.Text= dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
         txtDepartman.Text = dataGridView1.CurrentRow.Cells["Departman"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            Kayit_Göster();
        }

        private void btnPersonel_Sil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete from Personel_Liste where Tc='" + dataGridView1.CurrentRow.Cells["Tc"].Value.ToString() + "'", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["Personel_Liste"].Clear();
            Kayit_Göster();
            MessageBox.Show("Kayıt Silindi !");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update Personel_Liste set Ad_Soyad=@Ad_Soyad,Mail=@Mail,Telefon=@Telefon,Departman=@Departman,Maas=@Maas where Tc=@Tc", sqlConnection);
            cmd.Parameters.AddWithValue("@Ad_Soyad", txtAd_Soyad.Text);
            cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@Departman", txtDepartman.Text);
            cmd.Parameters.AddWithValue("@Maas", txtMaas.Text);
            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            daSet.Tables["Personel_Liste"].Clear();
            Kayit_Göster();
            MessageBox.Show("Güncelleme başarılı !");
            txtTc.Clear();
            txtAd_Soyad.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtDepartman.Clear();
            txtMaas.Clear();
        }

        private void btnKullanici_Ekle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle kullaniciEkle = new frmKullaniciEkle();
            kullaniciEkle.ShowDialog();
        }
    }
}
