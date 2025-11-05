using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 1200000m;
            const int MIN_YEARS = 2;

            decimal salary;
            int years;

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                if (salary >= MIN_SALARY && years >= MIN_YEARS)
                {
                    decisionLabel.Text = "您符合貸款資格。";
                }
                else
                {
                    decisionLabel.Text = "您不符合貸款資格。";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
            }
            catch (OverflowException)
            {
                MessageBox.Show("輸入的數值過大或過小。", "輸入錯誤");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
