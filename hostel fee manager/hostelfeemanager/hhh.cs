using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelfeemanager
{
    public partial class hhh : UserControl
    {
        public hhh()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=JORAS;Initial Catalog=hostelms;Integrated Security=True");
        private void hhh_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM HS";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
