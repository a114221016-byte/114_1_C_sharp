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

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetFileName 方法會從使用者取得檔案名稱，
        // 並將其指派給作為引數傳入的變數。

        // GetCountries 方法接受一個檔案名稱作為
        // 引數。此方法會開啟指定的檔案，並在
        // countriesListBox 控制項中顯示其內容。
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;
            GetFileName(out fileName);
            GetCountries(fileName);
        }

        private void GetFileName(out string fileName)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            else
            {
                fileName = string.Empty;
            }
        }
        private void GetCountries(string fileName)
        {
            string country;
            countriesListBox.Items.Clear();
            if (fileName != string.Empty)
            {
                StreamReader inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("未選取檔案。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

    }
}
