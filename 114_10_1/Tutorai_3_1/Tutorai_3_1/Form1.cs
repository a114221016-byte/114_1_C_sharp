using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorai_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void showdatebutton_Click(object sender, EventArgs e)
        {
            string dayofweek = dayofweekTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearTextBox.Text;
            string dayofmonth = dayofmonthTextBox.Text;

            string output = "中華民國" + year + "年" + month + "月" + dayofmonth + "日" + "星期" + dayofweek;

            DateTimeOffset.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dayofweek.Text = "";
            month.Text = "";
            dayofmonth.Text = "";
            dayofyear.Text = "";

        }
    }
}
