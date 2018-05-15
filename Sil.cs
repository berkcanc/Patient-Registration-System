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
    public partial class Sil : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7E5I09J;Initial Catalog=Hasta;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();


        public Sil()
        {
            InitializeComponent();
        }

        private void Button_sil_cikis_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Button_sil_cikis_Click_1(object sender, EventArgs e)
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


        private void Button2_sil_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from Hasta where tc=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                Listeleme();


            }


        }

        private void Sil_Load(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Listeleme();
            
            //SqlDataAdapter adpr = new SqlDataAdapter("select tc from Hasta", conn);
            //DataTable tablo = new DataTable();
            //adpr.Fill(tablo);
            //for (int i = 0; i < tablo.Rows.Count; i++)
            //{
            //    if (textBox_tc_sil.Text == tablo.Rows[i][0].ToString() )
            //    {
            //        //conn.Open();
            //        //cmd.Connection = conn;
            //        //cmd.CommandText = "delete from Hasta where tc=@numara";
            //        //cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //        //cmd.ExecuteNonQuery();
            //        //cmd.Dispose();
            //        //conn.Close();
            //        //Listeleme();
            //    }

            //}
        }
    }
}
