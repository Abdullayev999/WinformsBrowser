using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBrowserApp
{
    public partial class Browser : MetroFramework.Forms.MetroForm
    {
        public List<WebBrowser> Web { get; set; }
        public string HomeUri { get; set; }
        public string SearchUri { get; set; }
        public List<Tuple<string,string>> HistoryList { get; set; }
        Dictionary<string, string> FavoritList { get; set; }

        private readonly string HistoryPath;
        private readonly string FavoritPath;
        private readonly string SearchingPath;
        private readonly string HomePagePath;
        public Browser()
        {
            InitializeComponent();
            HistoryPath = "history.json";
            FavoritPath = "favorit.json";
            SearchingPath = "searching.txt";
            HomePagePath = "homepage.txt";

            Web = new List<WebBrowser>();
            Web.Add(webBrowser);                   
        }

        private void metroButtonSettings_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm(HomeUri , SearchUri);
            settingForm.ShowDialog();

            if (settingForm.HomePage != null) HomeUri = settingForm.HomePage;
            if (settingForm.comboBoxSearchPage.SelectedIndex != -1) SearchUri = settingForm.SearchPage;
            if (settingForm.IsClear)
            {
                listBoxHistory.Items.Clear();
                HistoryList.Clear();
            }
        }



        private void metroButtonHistory_Click(object sender, EventArgs e)
        {   
            if (splitContainerBasic.Panel2Collapsed)
            {
                splitContainerBasic.Panel2Collapsed = false;
                splitContainerSecondary.Panel1Collapsed = false;
                splitContainerSecondary.Panel2Collapsed = true;
            }
            else
            {
                splitContainerBasic.Panel2Collapsed = true;
                splitContainerSecondary.Panel1Collapsed = false;
                splitContainerSecondary.Panel2Collapsed = true;
            }
        }

        private void metroButtonFavorite_Click(object sender, EventArgs e)
        {
            if (splitContainerBasic.Panel2Collapsed)
            {
                splitContainerBasic.Panel2Collapsed = false;
                splitContainerSecondary.Panel2Collapsed = false;
                splitContainerSecondary.Panel1Collapsed = true;
            } 
            else
            {
                splitContainerBasic.Panel2Collapsed = true;
                splitContainerSecondary.Panel2Collapsed = true;                
                splitContainerSecondary.Panel1Collapsed = true;
            }
        }


        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //-----------------Vizualnaya cast dlya krasoti---------------------------
            metroProgressBar1.Value = 0;
            do
            {
                System.Threading.Thread.Sleep(40);
                metroProgressBar1.Value += metroProgressBar1.Step;    
                
            } while (metroProgressBar1.Value != metroProgressBar1.Maximum);
            //----------------------------------------------------------------

            
            WebBrowser webBrowser = sender as WebBrowser;
            metroTextBoxUri.Text = webBrowser.Url.ToString();

            Tuple<string, string> tuple = new Tuple<string, string>(DateTime.Now.ToString("dd MMMM yyyy HH:mm"), webBrowser.Url.ToString());

            HistoryList.Insert(0,tuple);
            listBoxHistory.Items.Insert(0,$"{tuple.Item1} |  {tuple.Item2}");
        }

        private void metroButtonHome_Click(object sender, EventArgs e)
        {
            GoSite(HomeUri);
        }

        private void metroTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {      
                try
                {
                    GoSite(metroTextBoxUri.Text.ToString());
                    int count = tabControl.SelectedIndex;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Uri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GoSite(string uri)
        {
            try
            {
                int count = tabControl.SelectedIndex;
                var page = tabControl.Controls[count] as TabPage;
                var web = page.Controls[0] as WebBrowser;

                if (uri.StartsWith("http://www.") || uri.StartsWith("https://www."))
                {
                    web.Url = new Uri(uri);
                }
                else
                {
                    web.Url = new Uri("http://www." + uri);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Uri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    GoSite(SearchUri + metroTextBoxSearch.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error Uri",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void metroButtonRemove_Click(object sender, EventArgs e)
        {
            var selectIndex = listBoxHistory.SelectedIndex;

            if (selectIndex!=-1)
            {
                listBoxHistory.Items.RemoveAt(selectIndex);
                HistoryList.RemoveAt(selectIndex);
            }
            else
            {
                MessageBox.Show("You not select Uri", "Error Uri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButtonGo_Click(object sender, EventArgs e)
        {
            var selectIndex = listBoxHistory.SelectedIndex;

            if (selectIndex != -1) GoSite(HistoryList[selectIndex].Item2);
            else
            {
                MessageBox.Show("You not select Uri", "Error Uri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void metroButtonAddFavorite_Click(object sender, EventArgs e)
        {
            var favorite = new FavoriteForm();
            favorite.ShowDialog();
            if (favorite.FavoritName!=null)
            {
                if (!FavoritList.ContainsKey(favorite.FavoritName))
                {
                    FavoritList[favorite.FavoritName] = metroTextBoxUri.Text;
                    listBoxFavorit.Items.Add(favorite.FavoritName);
                }
                else MessageBox.Show("A favorite with this name exists","Errot" , MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }           
        }

        private void metroButtonAddPage_Click(object sender, EventArgs e)
        {
            int count = tabControl.Controls.Count;
            TabPage page = new TabPage($"New tab ({count})");
            WebBrowser web = new WebBrowser();
            Web.Add(web);
            web.Url = new Uri(HomeUri);
            web.Dock = DockStyle.Fill;
            web.Navigated += webBrowser_Navigated;
            page.Controls.Add(web);
            tabControl.Controls.Add(page);
        }

        private void metroButtonRemovePage_Click(object sender, EventArgs e)
        {
            int count = tabControl.Controls.Count;

            if (count > 1)
            {
                int indexRemove = tabControl.SelectedIndex;
                tabControl.Controls.RemoveAt(indexRemove);
            }
            else
            {
                var result = MessageBox.Show("You want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) this.Close();
                
            }
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            Web[index].GoBack();
        }

        private void metroButtonNext_Click(object sender, EventArgs e)
        {            
            int index = tabControl.SelectedIndex;           
            Web[index].GoForward();
        }

        private void listBoxFavorit_DoubleClick(object sender, EventArgs e)
        {
           var item = listBoxFavorit.SelectedItem as string;
           
           if (item!=null)  GoSite(FavoritList[item]);
            
        }

        private void metroButtonRemoveFavorite_Click(object sender, EventArgs e)
        {
            var item = listBoxFavorit.SelectedItem as string;
            if (item != null)
            {
                FavoritList.Remove(item);
                listBoxFavorit.Items.Remove(item);
            }else
            {
                MessageBox.Show("You not select Favorit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                LoadHistory();
                LoadFavorit();

                if (File.Exists(SearchingPath))  SearchUri = File.ReadAllText(SearchingPath);                
                else  SearchUri = "http://www.google.com/search?q=";
                
                if (File.Exists(HomePagePath)) HomeUri = File.ReadAllText(HomePagePath);                
                else  HomeUri = "http://www.google.com/";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        public void LoadHistory()
        {
            if (File.Exists(HistoryPath))
            {
                var jsonHistoryList = File.ReadAllText(HistoryPath);

                HistoryList = JsonSerializer.Deserialize<List<Tuple<string, string>>>(jsonHistoryList);

                foreach (var item in HistoryList)
                {
                    listBoxHistory.Items.Add($"{item.Item1}  |  {item.Item2}");
                }
            }
            else
            {
                HistoryList = new List<Tuple<string, string>>();
            }
        }

        public void LoadFavorit()
        {
            if (File.Exists(FavoritPath))
            {
                var jsonFavoritList = File.ReadAllText(FavoritPath);

                FavoritList = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFavoritList);

                foreach (var item in FavoritList)
                {
                    listBoxFavorit.Items.Add(item.Key);
                }
            }
            else
            {
                FavoritList = new Dictionary<string, string>();
            }
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var jsonHistoryList = JsonSerializer.Serialize(HistoryList);
                File.WriteAllText(HistoryPath, jsonHistoryList);

                var jsonFavoritList = JsonSerializer.Serialize(FavoritList);
                File.WriteAllText(FavoritPath, jsonFavoritList);

                File.WriteAllText(HomePagePath, HomeUri);
                File.WriteAllText(SearchingPath, SearchUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Save",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
