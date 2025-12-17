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

            decimal[] sales = new decimal[8];
            int index = 0;

            try
                {
                inputFile = File.OpenText("Sales.txt");
                salesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                      salesListBox.Item.Add(currentSales.ToString("C"));
                      sales[index] = currentSales;
                      index++;
                    }
                    else
                    {
                        MessageBox.Show("資料格式錯誤: " + line);
                        break;
                    }
                }
                inputFile.Close();
                
            
            for(int i = 0; i < index; i++)
            {
                total += sales[i];
            }
            // 計算按鈕點擊事件處理：請在此加入讀取與計算邏輯
        totalLabel.Text = total.ToString("C");
        }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
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
