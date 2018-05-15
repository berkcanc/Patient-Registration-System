namespace VTYS_Proje1
{
    partial class Sil
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2_sil = new System.Windows.Forms.Button();
            this.button_sil_cikis = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Kayıtları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2_sil
            // 
            this.button2_sil.Location = new System.Drawing.Point(235, 372);
            this.button2_sil.Name = "button2_sil";
            this.button2_sil.Size = new System.Drawing.Size(86, 46);
            this.button2_sil.TabIndex = 2;
            this.button2_sil.Text = "SİL";
            this.button2_sil.UseVisualStyleBackColor = true;
            this.button2_sil.Click += new System.EventHandler(this.Button2_sil_Click);
            // 
            // button_sil_cikis
            // 
            this.button_sil_cikis.Location = new System.Drawing.Point(342, 372);
            this.button_sil_cikis.Name = "button_sil_cikis";
            this.button_sil_cikis.Size = new System.Drawing.Size(91, 46);
            this.button_sil_cikis.TabIndex = 3;
            this.button_sil_cikis.Text = "ÇIKIŞ";
            this.button_sil_cikis.UseVisualStyleBackColor = true;
            this.button_sil_cikis.Click += new System.EventHandler(this.Button_sil_cikis_Click_1);
            // 
            // Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 439);
            this.Controls.Add(this.button_sil_cikis);
            this.Controls.Add(this.button2_sil);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sil";
            this.Load += new System.EventHandler(this.Sil_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_sil;
        private System.Windows.Forms.Button button_sil_cikis;
    }
}