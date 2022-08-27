namespace PersonelTakip
{
    partial class frmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnPersonel_ekle = new System.Windows.Forms.Button();
            this.btnPersonel_Gider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd_Soyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPersonel_Sil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKullanici_Ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.Location = new System.Drawing.Point(583, 12);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(109, 55);
            this.btnDepartman.TabIndex = 0;
            this.btnDepartman.Text = "Personel İzin Kayıtları";
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnPersonel_ekle
            // 
            this.btnPersonel_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPersonel_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel_ekle.Location = new System.Drawing.Point(-1, 294);
            this.btnPersonel_ekle.Name = "btnPersonel_ekle";
            this.btnPersonel_ekle.Size = new System.Drawing.Size(84, 38);
            this.btnPersonel_ekle.TabIndex = 0;
            this.btnPersonel_ekle.Text = "Personel Ekle";
            this.btnPersonel_ekle.UseVisualStyleBackColor = false;
            this.btnPersonel_ekle.Click += new System.EventHandler(this.btnPersonel_ekle_Click);
            // 
            // btnPersonel_Gider
            // 
            this.btnPersonel_Gider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPersonel_Gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel_Gider.Location = new System.Drawing.Point(309, 8);
            this.btnPersonel_Gider.Name = "btnPersonel_Gider";
            this.btnPersonel_Gider.Size = new System.Drawing.Size(109, 55);
            this.btnPersonel_Gider.TabIndex = 0;
            this.btnPersonel_Gider.Text = "Personel Gider Tablosu";
            this.btnPersonel_Gider.UseVisualStyleBackColor = false;
            this.btnPersonel_Gider.Click += new System.EventHandler(this.btnPersonel_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(194, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 224);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(88, 143);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 2;
            // 
            // txtAd_Soyad
            // 
            this.txtAd_Soyad.Location = new System.Drawing.Point(88, 117);
            this.txtAd_Soyad.Name = "txtAd_Soyad";
            this.txtAd_Soyad.Size = new System.Drawing.Size(100, 20);
            this.txtAd_Soyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(88, 199);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(88, 173);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 2;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(88, 225);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(100, 20);
            this.txtDepartman.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(-4, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departman :";
            // 
            // btnPersonel_Sil
            // 
            this.btnPersonel_Sil.BackColor = System.Drawing.Color.Red;
            this.btnPersonel_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel_Sil.ForeColor = System.Drawing.Color.White;
            this.btnPersonel_Sil.Location = new System.Drawing.Point(104, 294);
            this.btnPersonel_Sil.Name = "btnPersonel_Sil";
            this.btnPersonel_Sil.Size = new System.Drawing.Size(84, 38);
            this.btnPersonel_Sil.TabIndex = 4;
            this.btnPersonel_Sil.Text = "Personel Sil";
            this.btnPersonel_Sil.UseVisualStyleBackColor = false;
            this.btnPersonel_Sil.Click += new System.EventHandler(this.btnPersonel_Sil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(51, 340);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 44);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKullanici_Ekle
            // 
            this.btnKullanici_Ekle.BackColor = System.Drawing.Color.Lime;
            this.btnKullanici_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanici_Ekle.Location = new System.Drawing.Point(41, 8);
            this.btnKullanici_Ekle.Name = "btnKullanici_Ekle";
            this.btnKullanici_Ekle.Size = new System.Drawing.Size(107, 51);
            this.btnKullanici_Ekle.TabIndex = 6;
            this.btnKullanici_Ekle.Text = "Kullanıcı Ekle";
            this.btnKullanici_Ekle.UseVisualStyleBackColor = false;
            this.btnKullanici_Ekle.Click += new System.EventHandler(this.btnKullanici_Ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maaş :";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(88, 253);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 20);
            this.txtMaas.TabIndex = 8;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 385);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKullanici_Ekle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnPersonel_Sil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAd_Soyad);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPersonel_Gider);
            this.Controls.Add(this.btnPersonel_ekle);
            this.Controls.Add(this.btnDepartman);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndex";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPersonel_ekle;
        private System.Windows.Forms.Button btnPersonel_Gider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd_Soyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPersonel_Sil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKullanici_Ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaas;
    }
}