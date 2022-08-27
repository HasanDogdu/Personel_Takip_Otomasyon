namespace PersonelTakip
{
    partial class frmPersonel_Gider
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtToplamMaas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Kalite_Kontrol = new System.Windows.Forms.RadioButton();
            this.İnsan_Kaynaklari = new System.Windows.Forms.RadioButton();
            this.Muhasebe = new System.Windows.Forms.RadioButton();
            this.Bilgi_islem = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnsonToplam = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtToplamMaas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Kalite_Kontrol);
            this.groupBox1.Controls.Add(this.İnsan_Kaynaklari);
            this.groupBox1.Controls.Add(this.Muhasebe);
            this.groupBox1.Controls.Add(this.Bilgi_islem);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departmanlar";
            // 
            // txtToplamMaas
            // 
            this.txtToplamMaas.Location = new System.Drawing.Point(109, 180);
            this.txtToplamMaas.Name = "txtToplamMaas";
            this.txtToplamMaas.Size = new System.Drawing.Size(100, 20);
            this.txtToplamMaas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Maaş :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Maaşı hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kalite_Kontrol
            // 
            this.Kalite_Kontrol.AutoSize = true;
            this.Kalite_Kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kalite_Kontrol.Location = new System.Drawing.Point(6, 99);
            this.Kalite_Kontrol.Name = "Kalite_Kontrol";
            this.Kalite_Kontrol.Size = new System.Drawing.Size(112, 19);
            this.Kalite_Kontrol.TabIndex = 0;
            this.Kalite_Kontrol.TabStop = true;
            this.Kalite_Kontrol.Text = "Kalite Kontrol";
            this.Kalite_Kontrol.UseVisualStyleBackColor = true;
            // 
            // İnsan_Kaynaklari
            // 
            this.İnsan_Kaynaklari.AutoSize = true;
            this.İnsan_Kaynaklari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İnsan_Kaynaklari.Location = new System.Drawing.Point(6, 76);
            this.İnsan_Kaynaklari.Name = "İnsan_Kaynaklari";
            this.İnsan_Kaynaklari.Size = new System.Drawing.Size(131, 19);
            this.İnsan_Kaynaklari.TabIndex = 0;
            this.İnsan_Kaynaklari.TabStop = true;
            this.İnsan_Kaynaklari.Text = "İnsan Kaynakları";
            this.İnsan_Kaynaklari.UseVisualStyleBackColor = true;
            // 
            // Muhasebe
            // 
            this.Muhasebe.AutoSize = true;
            this.Muhasebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Muhasebe.Location = new System.Drawing.Point(6, 53);
            this.Muhasebe.Name = "Muhasebe";
            this.Muhasebe.Size = new System.Drawing.Size(92, 19);
            this.Muhasebe.TabIndex = 0;
            this.Muhasebe.TabStop = true;
            this.Muhasebe.Text = "Muhasebe";
            this.Muhasebe.UseVisualStyleBackColor = true;
            // 
            // Bilgi_islem
            // 
            this.Bilgi_islem.AutoSize = true;
            this.Bilgi_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilgi_islem.Location = new System.Drawing.Point(6, 30);
            this.Bilgi_islem.Name = "Bilgi_islem";
            this.Bilgi_islem.Size = new System.Drawing.Size(93, 19);
            this.Bilgi_islem.TabIndex = 0;
            this.Bilgi_islem.TabStop = true;
            this.Bilgi_islem.Text = "Bilgi İşlem";
            this.Bilgi_islem.UseVisualStyleBackColor = true;
            this.Bilgi_islem.CheckedChanged += new System.EventHandler(this.Bilgi_islem_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departmanlar Toplam Maaş Gideri :";
            // 
            // txtEnsonToplam
            // 
            this.txtEnsonToplam.Location = new System.Drawing.Point(83, 307);
            this.txtEnsonToplam.Multiline = true;
            this.txtEnsonToplam.Name = "txtEnsonToplam";
            this.txtEnsonToplam.Size = new System.Drawing.Size(234, 28);
            this.txtEnsonToplam.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 222);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(2, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Topla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPersonel_Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEnsonToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonel_Gider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonel_Gider";
            this.Load += new System.EventHandler(this.frmPersonel_Gider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtToplamMaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Kalite_Kontrol;
        private System.Windows.Forms.RadioButton İnsan_Kaynaklari;
        private System.Windows.Forms.RadioButton Muhasebe;
        private System.Windows.Forms.RadioButton Bilgi_islem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnsonToplam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}