using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorREAL
{
    public partial class Form1 : Form
    {
        double firstnum;
        string operation;
        double secondnum;
       
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Numdata(string val)
        {
            if (nholder.Text == "0" || nholder.Text  == "+" || nholder.Text == "-" ||nholder.Text == "*"|| nholder.Text == "/")
            {
                nholder.Text = val;
            }
            else
            {
                nholder.Text = nholder.Text + val;
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            Numdata("1");
        }

        private void n2_Click(object sender, EventArgs e)
        {
            Numdata("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            Numdata("3");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            Numdata("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            Numdata("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            Numdata("6");
        }

        private void n7_Click(object sender, EventArgs e)
        {
            Numdata("7");
        }

        private void n8_Click(object sender, EventArgs e)
        {
            Numdata("8");
        }

        private void n9_Click(object sender, EventArgs e)
        {
            Numdata("9");
        }

        private void n0_Click(object sender, EventArgs e)
        {
            Numdata("0");
        }

        private void nplus_Click(object sender, EventArgs e)
        {
            ndot.Enabled = true;
            
            firstnum = Convert.ToDouble(nholder.Text);
            operation = "+";
            nholder.Text = "+"; 
               

            
        }

        private void nce_Click(object sender, EventArgs e)
        {
            nholder.Text = "";
        }

        private void nmul_Click(object sender, EventArgs e)
        {
            ndot.Enabled = true;
            firstnum = Convert.ToDouble(nholder.Text);
            operation = "*";
            nholder.Text = "*";

        }

        private void equal2_Click(object sender, EventArgs e)
        {

            double result;

            switch (operation)
            {
                 
                case "+":
                    secondnum = Convert.ToDouble(nholder.Text);
                    result = (firstnum + secondnum);
                    nholder.Text = Convert.ToString(result);
                    break;

                case "-":
                    secondnum = Convert.ToDouble(nholder.Text);
                    result = (firstnum - secondnum);
                    nholder.Text = Convert.ToString(result);
                    break;

                case "*":
                    secondnum = Convert.ToDouble(nholder.Text);
                    result = (firstnum * secondnum);
                    nholder.Text = Convert.ToString(result);
                    break;

                case "/":
                    secondnum = Convert.ToDouble(nholder.Text);
                    result = (firstnum / secondnum);
                    nholder.Text = Convert.ToString(result);
                    break;

            }




        }

        private void nminus_Click(object sender, EventArgs e)
        {
            ndot.Enabled = true;
            firstnum = Convert.ToDouble(nholder.Text);
            operation = "-";
            nholder.Text = "-";
        }

        private void ndiv_Click(object sender, EventArgs e)
        {
            ndot.Enabled = true;
            firstnum = Convert.ToDouble(nholder.Text);
            operation = "/";
            nholder.Text = "/";
        }

        private void nback_Click(object sender, EventArgs e)
        {

        }

        private void ndot_Click(object sender, EventArgs e)
        {
            ndot.Enabled = false;
            nholder.Text = nholder.Text + ".";
        }
    }
}
