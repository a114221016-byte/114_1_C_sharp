using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 生成按鈕點擊事件
        /// 當使用者按下「生成號碼」按鈕時，此方法會被觸發
        /// 用於生成並顯示彩票號碼
        /// </summary>
        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5; // 彩票號碼數量
            int[] lotteryNumbers = new int[SIZE];
            Label[] labels = new Label[SIZE] { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            Random rand = new Random();

            // 生成五個隨機彩票號碼
            for (int i = 0; i < SIZE; i++)
            {
                lotteryNumbers[i] = rand.Next(1, 50); // 生成1到49之間的隨機數
            }
            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();
            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString();
            }
        }

        /// <summary>
        /// 離開按鈕點擊事件
        /// 當使用者按下「離開」按鈕時，此方法會被觸發
        /// 用於關閉應用程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}
