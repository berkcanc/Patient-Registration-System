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

namespace VTYS_Proje1
{
    public partial class Ekle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7E5I09J;Initial Catalog=Hasta;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Ekle()
        {
            InitializeComponent();
        }

        private void Button_ekle_cikis_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        protected void Listeleme()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Hasta";
            SqlDataAdapter adpr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "Hasta");
            dataGridView1.DataSource = ds.Tables["Hasta"];
            dataGridView1.Columns[0].Visible = false;
            conn.Close();
            
        }
        private void Button_kayit_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Hasta(tc,ad,soyad,yas,cinsiyet) VALUES('" + textBox_tc.Text + "','" + textBox_ad.Text + "','" + textBox_soyad.Text + "','" + int.Parse(textBox_yas.Text) + "','" + textBox_cinsiyet.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                Listeleme();
            }


        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            Listeleme();
        }
    
    }
}
