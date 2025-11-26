using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    /// <summary>
    /// Form1 主表單：
    /// 此表單用於顯示銷售總額的計算應用程式。
    /// 提供「讀取銷售資料並計算總額」與「結束」兩個按鈕供使用者操作。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                decimal total = 0m;
                decimal currentSales = 0m;
                string line;

                // 檔案選擇邏輯
              
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    salesListBox.Items.Clear();

                }
                else
                {
                    // 預設路徑
                    filePath = @"C:\Users\m303\Desktop\114_1_C_sharp\114_11_26\Sales.txt";
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("No file selected and default file not found.");
                        return;
                    }
                }

                inputFile = File.OpenText(filePath);
                listBox1.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] parts = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 2)
                    {
                        string month = parts[0];
                        string saleValue = parts[1];

                        if (decimal.TryParse(saleValue, out currentSales))
                        {
                            listBox1.Items.Add($"Month: {month}, Sales: {currentSales:C}");
                            total += currentSales;
                        }
                        else
                        {
                            MessageBox.Show("Invalid sales value: " + saleValue);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid data format: " + line);
                        
                    }
                }
                inputFile.Close();
                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
                MessageBox.Show("No file selected.");
            }
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_sharp\114_11_26\Sales.txt");
                listBox1.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    string[] parts = line.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
                    // 修正 Split 語法，加入正確的 StringSplitOptions 參數
                   
                    if (parts.Length>=2)
                    {
                        string month = parts[0];
                        string saleValue = parts[1];

                        if (decimal.TryParse(saleValue, out currentSales))
                        {
                            salesListBox.Items.Add(month+ ": " + currentSales.ToString("C"));
                            total += currentSales;
                        MessageBox.Show("Invalid sales value: " + saleValue);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid data format: " + line);
                    }
                }
                inputFile.Close();
                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        /// <summary>
        /// exitButton_Click 事件處理程序：
        /// 當使用者點擊「結束」按鈕時觸發此方法。
        /// 負責關閉此表單視窗，結束應用程式執行。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，終止應用程式
            this.Close();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
