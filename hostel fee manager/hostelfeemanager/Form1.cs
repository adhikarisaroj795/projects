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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        float pointx = 0;
        float pointy = 0;

        float lastx = 0;
        float lasty = 0;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hhh1.Hide();
            con.Open();
            string query = "SELECT * FROM HS where year(dateandtime)=" + DateTime.Now.Year;
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
           
            foreach (DataRow row in dt.Rows)
            {
                //MessageBox.Show(row.ItemArray[1].ToString());
                if(row.ItemArray[1].ToString()== "Baishakh")
                {
                    pnl1.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "jestha")
                {
                    pnl2.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "asar")
                {
                    pnl3.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "shrawan")
                {
                    pnl4.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "bhadra")
                {
                    pnl5.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "aswin")
                {
                    pnl6.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "kartik")
                {
                    pnl7.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "mangsir")
                {
                    pnl8.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "paush")
                {
                    pnl9.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "magh")
                {
                    pnl10.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() == "falgun")
                {
                    pnl11.BackColor = Color.Red;
                }
                if (row.ItemArray[1].ToString() =="chaith")
                {
                    pnl12.BackColor = Color.Red;
                }

            }

        }
        SqlConnection con = new SqlConnection("Data Source=JORAS;Initial Catalog=hostelms;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (mholder.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Amount you paid");

            }
            else
            {





                string checkedValue = "";
                var a = DateTime.Now;

                if (RB1.Checked == true)
                {
                    checkedValue = "Baishakh";
                    pnl1.BackColor = Color.Red;
                }
                if (RB2.Checked == true)
                {
                    checkedValue = "jestha";
                    pnl2.BackColor = Color.Red;
                }
                if (RB3.Checked == true)
                {
                    checkedValue = "asar";
                    pnl3.BackColor = Color.Red;
                }
                if (RB4.Checked == true)
                {
                    checkedValue = "shrawan";
                    pnl4.BackColor = Color.Red;
                }
                if (RB5.Checked == true)
                {
                    checkedValue = "bhadra";
                    pnl5.BackColor = Color.Red;
                }
                if (RB6.Checked == true)
                {
                    checkedValue = "aswin";
                    pnl6.BackColor = Color.Red;
                }
                if (RB7.Checked == true)
                {
                    checkedValue = "kartik";
                    pnl7.BackColor = Color.Red;
                }
                if (RB8.Checked == true)
                {
                    checkedValue = "mangsir";
                    pnl8.BackColor = Color.Red;
                }
                if (RB9.Checked == true)
                {
                    checkedValue = "paush";
                    pnl9.BackColor = Color.Red;
                }
                if (RB10.Checked == true)
                {
                    checkedValue = "magh";
                    pnl10.BackColor = Color.Red;
                }
                if (RB11.Checked == true)
                {
                    checkedValue = "falgun";
                    pnl11.BackColor = Color.Red;
                }
                if (RB12.Checked == true)
                {
                    checkedValue = "chaith";
                    pnl12.BackColor = Color.Red;
                }


                {
                    con.Open();
                    string query = "INSERT INTO HS (Amount,Dateandtime,month) VALUES('" + mholder.Text + "','" + a + "', '" + checkedValue + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("your payment is sucessfully saved");
                    mholder.Text = "";
                    sighn.Invalidate();


                }
            }
           



        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            
            
     

        }

        private void RB1_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB1.Checked = true;

        }

        private void heck()
        {
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;
                }
            }
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB7_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB8_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB9_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB10_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB11_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB12_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RB2_MouseClick(object sender, MouseEventArgs e)
        {
            
            heck();
            RB2.Checked = true;
        }

        private void RB3_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
           
            RB3.Checked = true;
        }

        private void RB4_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB4.Checked = true;
        }

        private void RB5_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB5.Checked = true;
        }

        private void RB6_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB6.Checked = true;
        }

        private void RB7_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB7.Checked = true;
        }

        private void RB8_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB8.Checked = true;
        }

        private void RB9_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB9.Checked = true;
        }

        private void RB10_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB10.Checked = true;
        }

        private void RB11_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB11.Checked = true;
        }

        private void RB12_MouseClick(object sender, MouseEventArgs e)
        {
            heck();
            RB12.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            sf form2 = new sf();
            form2.Tag = this;
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X, this.Location.Y);
            form2.Location = this.Location;
            form2.Show(this);
            Hide();

           /* con.Open();
            string query = "SELECT * FROM HS";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/





        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "Data Source=JORAS;Initial Catalog=hostelms;Integrated Security=True";
            
            try
            {
                
                string Query = "TRUNCATE table HS;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sighn_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = sighn.CreateGraphics();
            G.DrawLine(Pens.Red, pointx, pointy,lastx,lasty);
            lastx = pointx;
            lasty = pointy;
        }

        private void sighn_MouseDown(object sender, MouseEventArgs e)
        {
            lasty = e.Y;
            lastx = e.X;
            
        }

        private void sighn_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                pointx = e.X;
                pointy = e.Y;
                sighn_Paint(this,null);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sighn.Invalidate();
        }

        private void mholder_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
