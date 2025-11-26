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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        // 將 count 欄位移除 readonly 修飾詞，讓它可以在方法中遞增。
        private int count = 1; // 成員變數，計數朋友的數量
                               // 在 Form1 類別中新增 saveFile 欄位
        private SaveFileDialog saveFile = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

        

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFile.FileName);
                outputFile.WriteLine(count + ":" + nameTextBox.Text);
                outputFile.Close();
                count++; // 遞增朋友數量
            }
            else
            {
                MessageBox.Show("未選擇檔案，無法寫入資料。");
            }

            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }
           

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
