using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBrowserApp
{
    public partial class SettingForm : MetroFramework.Forms.MetroForm
    {
        public string HomePage { get; set; }
        public string SearchPage { get; set; }
        public bool IsClear { get; set; } = false;
        public SettingForm(string homeUri,string search)
        {
            InitializeComponent();

            SelectComboBox(search);
            HomePage = homeUri;
            metroTextBoxHomeUri.Text = HomePage;
        }
        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            if (metroTextBoxHomeUri.Text != null)
            {
                if (metroTextBoxHomeUri.Text.StartsWith("http://www.") || metroTextBoxHomeUri.Text.StartsWith("https://www."))
                {
                    HomePage = metroTextBoxHomeUri.Text;
                }
                else
                {
                    HomePage = "http://www." + metroTextBoxHomeUri.Text;
                }
            }                       

            var index = comboBoxSearchPage.SelectedIndex;
            switch (index)
            {
                case 1:
                    SearchPage = "http://www.yandex.ru/search/?lr=10253&clid=2256436-306&win=418&text=";
                    break;
                case 2:
                    SearchPage = "http://www.bing.com/search?q=";
                    break;
                case 0:
                default:
                    SearchPage = "http://www.google.com/search?q=";
                    break;

            }

            this.Close();
        }


        public void SelectComboBox(string search)
        {
            if (search == "http://www.google.com/search?q=")
            {
                comboBoxSearchPage.SelectedIndex = 0;
            }
            else if (search == "http://www.yandex.ru/search/?lr=10253&clid=2256436-306&win=418&text=")
            {
                comboBoxSearchPage.SelectedIndex = 1;
            }
            else if (search == "http://www.bing.com/search?q=")
            {
                comboBoxSearchPage.SelectedIndex = 2;
            }
            else
            {
                comboBoxSearchPage.SelectedIndex = -1;
            }
        }

        private void metroButtonAllHistoryRemove_Click(object sender, EventArgs e)
        {
            IsClear = true;
            MessageBox.Show("You have cleared your history","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
