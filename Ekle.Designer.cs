namespace VTYS_Proje1
{
    partial class Ekle
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
            this.button_kayit = new System.Windows.Forms.Button();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_yas = new System.Windows.Forms.TextBox();
            this.textBox_cinsiyet = new System.Windows.Forms.TextBox();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ekle_cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_kayit);
            this.groupBox1.Controls.Add(this.textBox_ad);
            this.groupBox1.Controls.Add(this.textBox_soyad);
            this.groupBox1.Controls.Add(this.textBox_yas);
            this.groupBox1.Controls.Add(this.textBox_cinsiyet);
            this.groupBox1.Controls.Add(this.textBox_tc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kriterler";
            // 
            // button_kayit
            // 
            this.button_kayit.Location = new System.Drawing.Point(720, 132);
            this.button_kayit.Name = "button_kayit";
            this.button_kayit.Size = new System.Drawing.Size(151, 71);
            this.button_kayit.TabIndex = 16;
            this.button_kayit.Text = "HASTA KAYIT";
            this.button_kayit.UseVisualStyleBackColor = true;
            this.button_kayit.Click += new System.EventHandler(this.Button_kayit_Click);
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(153, 64);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 22);
            this.textBox_ad.TabIndex = 15;
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(153, 103);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(100, 22);
            this.textBox_soyad.TabIndex = 14;
            // 
            // textBox_yas
            // 
            this.textBox_yas.Location = new System.Drawing.Point(153, 142);
            this.textBox_yas.Name = "textBox_yas";
            this.textBox_yas.Size = new System.Drawing.Size(100, 22);
            this.textBox_yas.TabIndex = 13;
            // 
            // textBox_cinsiyet
            // 
            this.textBox_cinsiyet.Location = new System.Drawing.Point(153, 181);
            this.textBox_cinsiyet.Name = "textBox_cinsiyet";
            this.textBox_cinsiyet.Size = new System.Drawing.Size(100, 22);
            this.textBox_cinsiyet.TabIndex = 12;
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(153, 29);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(100, 22);
            this.textBox_tc.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Kayıtları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_ekle_cikis
            // 
            this.button_ekle_cikis.Location = new System.Drawing.Point(399, 480);
            this.button_ekle_cikis.Name = "button_ekle_cikis";
            this.button_ekle_cikis.Size = new System.Drawing.Size(115, 33);
            this.button_ekle_cikis.TabIndex = 2;
            this.button_ekle_cikis.Text = "ÇIKIŞ";
            this.button_ekle_cikis.UseVisualStyleBackColor = true;
            this.button_ekle_cikis.Click += new System.EventHandler(this.Button_ekle_cikis_Click);
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 522);
            this.Controls.Add(this.button_ekle_cikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_yas;
        private System.Windows.Forms.TextBox textBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_kayit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ekle_cikis;
    }
}