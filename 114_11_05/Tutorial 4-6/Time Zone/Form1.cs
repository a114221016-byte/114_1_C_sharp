using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
           string city;

            // Get the selected city.
            if(cityListBox.SelectedItem != null)
            {
                city = cityListBox.SelectedItem.ToString();
                // Display the time zone.
                switch (city)
                {
                    case "丹佛":
                        timeZoneLabel.Text = "山地時區 (UTC-7)";
                        break;
                    case "檀香山":
                        timeZoneLabel.Text = "夏威夷-阿留申時區 (UTC-10)";
                        break;
                    case "明尼阿波利斯":
                        timeZoneLabel.Text = "中部時區 (UTC-6)";
                        break;
                    case "紐約":
                        timeZoneLabel.Text = "東部時區 (UTC-5)";
                        break;
                    case "舊金山":
                        timeZoneLabel.Text = "太平洋時區 (UTC-8)";
                        break;
                   
                }
            }
            else
            {
                // No city was selected.
                MessageBox.Show("請選擇一個城市。", "錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
