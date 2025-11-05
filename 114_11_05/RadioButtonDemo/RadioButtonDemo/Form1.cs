using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void milkteaButton2_CheckedChanged(object sender, EventArgs e)
        {
            String message = "點餐內容:";
            String drink = "";
            if (milkteaButton2.Checked)
            {
                drink = "奶茶";
            }
            else if (radioButton1.Checked)
            {
                drink = "咖啡";
            }
            else if (blackTeaButton3.Checked)
            {
                drink = "紅茶";
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button01_Click(object sender, EventArgs e)
        {

        }
    }
}
