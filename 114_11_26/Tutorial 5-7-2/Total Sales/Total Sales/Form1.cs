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
        /// <summary>
        /// 建構子：初始化表單及其各項控制項。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// calculateButton_Click 事件處理程序：
        /// 當使用者點擊「讀取銷售資料並計算總額」按鈕時觸發此方法。
        /// 此方法應負責：
        /// 1. 從檔案或資料來源讀取銷售資料。
        /// 2. 解析並加總所有銷售金額。
        /// 3. 將計算結果顯示於 totalLabel 控制項。
        /// 目前為空實作，請根據實際需求補充邏輯。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal total = 0m;
            decimal currentSales = 0m;
            string line;

            try
            {
                // 修正路徑字串，使用 @ 字元避免逸出序列錯誤
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
    }
}
