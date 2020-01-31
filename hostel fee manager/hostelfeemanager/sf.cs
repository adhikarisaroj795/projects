using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelfeemanager
{
    public partial class sf : Form
    {
        public sf()
        {
            InitializeComponent();
        }

        private void listbtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(this.Location.X, this.Location.Y);
            f1.Location = this.Location;
            f1.Show(this);
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Tag = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X, this.Location.Y);
            f2.Location = this.Location;
            f2.Show(this);
            Hide();
        }

        private void sighn_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=JORAS;Initial Catalog=hostelms;Integrated Security=True");

        private void sf_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM HS";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("empty table");
            }
            dataGridView1.DataSource = dt;
        }

        private void sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Tag = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Location.X, this.Location.Y);
            f2.Location = this.Location;
            f2.Show();
            Hide();
        }
    }
}
