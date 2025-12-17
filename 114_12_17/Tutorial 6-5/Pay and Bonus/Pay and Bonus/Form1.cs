using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 退休金提撥比率常數，設定為 5%
        /// </summary>
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// InputIsValid 方法用於驗證並轉換使用者輸入的資料。
        /// 此方法將轉換後的結果存儲在按參考傳遞的參數中。
        /// 如果轉換成功，方法返回 true；否則返回 false。
        /// </summary>
        /// <param name="input">使用者輸入的字串值</param>
        /// <param name="value">轉換後的十進制值</param>
        /// <returns>如果轉換成功返回 true，否則返回 false</returns>
        private bool InputIsValid(string input, out decimal value)
        {
            return decimal.TryParse(input, out value) && value >= 0;
        }

        /// <summary>
        /// 計算按鈕點擊事件處理程序。
        /// 此方法從文本框中獲取毛額薪資和獎金金額，
        /// 根據提撥比率計算退休金提撥額，並在標籤中顯示結果。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay;   
            decimal bonus;
            decimal contribution;

            if(InputIsValid(out grossPay,out bonus))
            {
                // 計算退休金提撥額
                contribution = (grossPay + bonus) * CONTRIB_RATE;
                // 顯示結果，格式化為貨幣形式
                contributionLabel.Text = contribution.ToString("C");
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入有效的數值（非負數）。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {
            grossPay = 0;
            bonus = 0;
            bool isGrossPayValid = decimal.TryParse(grossPayTextBox.Text, out grossPay) && grossPay >= 0;
            bool isBonusValid = decimal.TryParse(bonusTextBox.Text, out bonus) && bonus >= 0;

            if (!isGrossPayValid)
            {
                MessageBox.Show("毛額薪資輸入無效。請輸入有效的數值（非負數）。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!isBonusValid)
            {
                MessageBox.Show("獎金金額輸入無效。請輸入有效的數值（非負數）。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 離開按鈕點擊事件處理程序。
        /// 此方法關閉表單，結束應用程式。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
