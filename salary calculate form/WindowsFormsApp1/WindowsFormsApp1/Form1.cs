using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string basic=txtbasic.Text;
            string allowance=txtallowance.Text;

            double basicsal=Convert.ToDouble(txtbasic.Text);
            double allow = Convert.ToDouble(txtallowance.Text);

            double epf;
            double totalsalary;

            epf = basicsal * 10 / 100;
            totalsalary = basicsal + allow - epf;

            lbltotal.Text = ("total salary is"+" "+totalsalary.ToString());

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbasic.Text = " ";
            txtallowance.Text = "";
            lbltotal.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
