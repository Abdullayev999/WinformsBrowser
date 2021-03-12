
namespace WindowsFormsBrowserApp
{
    partial class Browser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxUri = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonNext = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonHome = new MetroFramework.Controls.MetroButton();
            this.metroButtonHistory = new MetroFramework.Controls.MetroButton();
            this.metroButtonFavorite = new MetroFramework.Controls.MetroButton();
            this.metroButtonSettings = new MetroFramework.Controls.MetroButton();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.splitContainerBasic = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonRemovePage = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddPage = new MetroFramework.Controls.MetroButton();
            this.splitContainerSecondary = new System.Windows.Forms.SplitContainer();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonRemove = new MetroFramework.Controls.MetroButton();
            this.metroButtonGo = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxFavorit = new System.Windows.Forms.ListBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonAddFavorite = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonRemoveFavorite = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasic)).BeginInit();
            this.splitContainerBasic.Panel1.SuspendLayout();
            this.splitContainerBasic.Panel2.SuspendLayout();
            this.splitContainerBasic.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecondary)).BeginInit();
            this.splitContainerSecondary.Panel1.SuspendLayout();
            this.splitContainerSecondary.Panel2.SuspendLayout();
            this.splitContainerSecondary.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTextBoxUri);
            this.metroPanel1.Controls.Add(this.metroButtonNext);
            this.metroPanel1.Controls.Add(this.metroTextBoxSearch);
            this.metroPanel1.Controls.Add(this.metroButtonHome);
            this.metroPanel1.Controls.Add(this.metroButtonHistory);
            this.metroPanel1.Controls.Add(this.metroButtonFavorite);
            this.metroPanel1.Controls.Add(this.metroButtonSettings);
            this.metroPanel1.Controls.Add(this.metroButtonBack);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(847, 36);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxUri
            // 
            // 
            // 
            // 
            this.metroTextBoxUri.CustomButton.Image = null;
            this.metroTextBoxUri.CustomButton.Location = new System.Drawing.Point(329, 2);
            this.metroTextBoxUri.CustomButton.Name = "";
            this.metroTextBoxUri.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBoxUri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUri.CustomButton.TabIndex = 1;
            this.metroTextBoxUri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUri.CustomButton.UseSelectable = true;
            this.metroTextBoxUri.CustomButton.Visible = false;
            this.metroTextBoxUri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxUri.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxUri.Lines = new string[0];
            this.metroTextBoxUri.Location = new System.Drawing.Point(110, 0);
            this.metroTextBoxUri.MaxLength = 32767;
            this.metroTextBoxUri.Name = "metroTextBoxUri";
            this.metroTextBoxUri.PasswordChar = '\0';
            this.metroTextBoxUri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUri.SelectedText = "";
            this.metroTextBoxUri.SelectionLength = 0;
            this.metroTextBoxUri.SelectionStart = 0;
            this.metroTextBoxUri.ShortcutsEnabled = true;
            this.metroTextBoxUri.Size = new System.Drawing.Size(363, 36);
            this.metroTextBoxUri.TabIndex = 11;
            this.metroTextBoxUri.UseSelectable = true;
            this.metroTextBoxUri.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUri.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxUri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox2_KeyDown);
            // 
            // metroButtonNext
            // 
            this.metroButtonNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonNext.Location = new System.Drawing.Point(55, 0);
            this.metroButtonNext.Name = "metroButtonNext";
            this.metroButtonNext.Size = new System.Drawing.Size(55, 36);
            this.metroButtonNext.TabIndex = 10;
            this.metroButtonNext.Text = "▶";
            this.metroButtonNext.UseSelectable = true;
            this.metroButtonNext.Click += new System.EventHandler(this.metroButtonNext_Click);
            // 
            // metroTextBoxSearch
            // 
            // 
            // 
            // 
            this.metroTextBoxSearch.CustomButton.Image = null;
            this.metroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.metroTextBoxSearch.CustomButton.Name = "";
            this.metroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearch.CustomButton.TabIndex = 1;
            this.metroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.CustomButton.UseSelectable = true;
            this.metroTextBoxSearch.CustomButton.Visible = false;
            this.metroTextBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTextBoxSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(473, 0);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.SelectionLength = 0;
            this.metroTextBoxSearch.SelectionStart = 0;
            this.metroTextBoxSearch.ShortcutsEnabled = true;
            this.metroTextBoxSearch.Size = new System.Drawing.Size(154, 36);
            this.metroTextBoxSearch.TabIndex = 8;
            this.metroTextBoxSearch.UseSelectable = true;
            this.metroTextBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBoxSearch_KeyDown);
            // 
            // metroButtonHome
            // 
            this.metroButtonHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButtonHome.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonHome.Location = new System.Drawing.Point(627, 0);
            this.metroButtonHome.Name = "metroButtonHome";
            this.metroButtonHome.Size = new System.Drawing.Size(55, 36);
            this.metroButtonHome.TabIndex = 7;
            this.metroButtonHome.Text = "🏠";
            this.metroButtonHome.UseSelectable = true;
            this.metroButtonHome.Click += new System.EventHandler(this.metroButtonHome_Click);
            // 
            // metroButtonHistory
            // 
            this.metroButtonHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButtonHistory.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonHistory.Location = new System.Drawing.Point(682, 0);
            this.metroButtonHistory.Name = "metroButtonHistory";
            this.metroButtonHistory.Size = new System.Drawing.Size(55, 36);
            this.metroButtonHistory.TabIndex = 6;
            this.metroButtonHistory.Text = "🗺";
            this.metroButtonHistory.UseSelectable = true;
            this.metroButtonHistory.Click += new System.EventHandler(this.metroButtonHistory_Click);
            // 
            // metroButtonFavorite
            // 
            this.metroButtonFavorite.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButtonFavorite.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonFavorite.Location = new System.Drawing.Point(737, 0);
            this.metroButtonFavorite.Name = "metroButtonFavorite";
            this.metroButtonFavorite.Size = new System.Drawing.Size(55, 36);
            this.metroButtonFavorite.TabIndex = 5;
            this.metroButtonFavorite.Text = "⭐";
            this.metroButtonFavorite.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonFavorite.UseSelectable = true;
            this.metroButtonFavorite.Click += new System.EventHandler(this.metroButtonFavorite_Click);
            // 
            // metroButtonSettings
            // 
            this.metroButtonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButtonSettings.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonSettings.Location = new System.Drawing.Point(792, 0);
            this.metroButtonSettings.Name = "metroButtonSettings";
            this.metroButtonSettings.Size = new System.Drawing.Size(55, 36);
            this.metroButtonSettings.TabIndex = 4;
            this.metroButtonSettings.Text = "⚙";
            this.metroButtonSettings.UseSelectable = true;
            this.metroButtonSettings.Click += new System.EventHandler(this.metroButtonSettings_Click);
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonBack.Location = new System.Drawing.Point(0, 0);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(55, 36);
            this.metroButtonBack.TabIndex = 3;
            this.metroButtonBack.Text = "◀";
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroProgressBar1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 543);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(847, 18);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(137, 18);
            this.metroProgressBar1.TabIndex = 3;
            // 
            // splitContainerBasic
            // 
            this.splitContainerBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBasic.Location = new System.Drawing.Point(20, 96);
            this.splitContainerBasic.Name = "splitContainerBasic";
            // 
            // splitContainerBasic.Panel1
            // 
            this.splitContainerBasic.Panel1.Controls.Add(this.tabControl);
            this.splitContainerBasic.Panel1.Controls.Add(this.metroPanel5);
            // 
            // splitContainerBasic.Panel2
            // 
            this.splitContainerBasic.Panel2.Controls.Add(this.splitContainerSecondary);
            this.splitContainerBasic.Panel2Collapsed = true;
            this.splitContainerBasic.Size = new System.Drawing.Size(847, 447);
            this.splitContainerBasic.SplitterDistance = 560;
            this.splitContainerBasic.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(847, 427);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(833, 392);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroButtonRemovePage);
            this.metroPanel5.Controls.Add(this.metroButtonAddPage);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(847, 20);
            this.metroPanel5.TabIndex = 0;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroButtonRemovePage
            // 
            this.metroButtonRemovePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonRemovePage.Location = new System.Drawing.Point(36, 0);
            this.metroButtonRemovePage.Name = "metroButtonRemovePage";
            this.metroButtonRemovePage.Size = new System.Drawing.Size(36, 20);
            this.metroButtonRemovePage.TabIndex = 5;
            this.metroButtonRemovePage.Text = "➖";
            this.metroButtonRemovePage.UseSelectable = true;
            this.metroButtonRemovePage.Click += new System.EventHandler(this.metroButtonRemovePage_Click);
            // 
            // metroButtonAddPage
            // 
            this.metroButtonAddPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonAddPage.Location = new System.Drawing.Point(0, 0);
            this.metroButtonAddPage.Name = "metroButtonAddPage";
            this.metroButtonAddPage.Size = new System.Drawing.Size(36, 20);
            this.metroButtonAddPage.TabIndex = 4;
            this.metroButtonAddPage.Text = "➕";
            this.metroButtonAddPage.UseSelectable = true;
            this.metroButtonAddPage.Click += new System.EventHandler(this.metroButtonAddPage_Click);
            // 
            // splitContainerSecondary
            // 
            this.splitContainerSecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSecondary.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSecondary.Name = "splitContainerSecondary";
            // 
            // splitContainerSecondary.Panel1
            // 
            this.splitContainerSecondary.Panel1.Controls.Add(this.listBoxHistory);
            this.splitContainerSecondary.Panel1.Controls.Add(this.metroPanel6);
            // 
            // splitContainerSecondary.Panel2
            // 
            this.splitContainerSecondary.Panel2.Controls.Add(this.panel1);
            this.splitContainerSecondary.Size = new System.Drawing.Size(283, 447);
            this.splitContainerSecondary.SplitterDistance = 135;
            this.splitContainerSecondary.TabIndex = 0;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 16;
            this.listBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(135, 411);
            this.listBoxHistory.TabIndex = 2;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.metroButtonRemove);
            this.metroPanel6.Controls.Add(this.metroButtonGo);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 411);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(135, 36);
            this.metroPanel6.TabIndex = 0;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // metroButtonRemove
            // 
            this.metroButtonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonRemove.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonRemove.Location = new System.Drawing.Point(71, 0);
            this.metroButtonRemove.Name = "metroButtonRemove";
            this.metroButtonRemove.Size = new System.Drawing.Size(64, 36);
            this.metroButtonRemove.TabIndex = 4;
            this.metroButtonRemove.Text = "🗑 Remove ";
            this.metroButtonRemove.UseSelectable = true;
            this.metroButtonRemove.Click += new System.EventHandler(this.metroButtonRemove_Click);
            // 
            // metroButtonGo
            // 
            this.metroButtonGo.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonGo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonGo.Location = new System.Drawing.Point(0, 0);
            this.metroButtonGo.Name = "metroButtonGo";
            this.metroButtonGo.Size = new System.Drawing.Size(71, 36);
            this.metroButtonGo.TabIndex = 3;
            this.metroButtonGo.Text = "🎯 Go";
            this.metroButtonGo.UseSelectable = true;
            this.metroButtonGo.Click += new System.EventHandler(this.metroButtonGo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxFavorit);
            this.panel1.Controls.Add(this.metroPanel4);
            this.panel1.Controls.Add(this.metroPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 447);
            this.panel1.TabIndex = 0;
            // 
            // listBoxFavorit
            // 
            this.listBoxFavorit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFavorit.FormattingEnabled = true;
            this.listBoxFavorit.ItemHeight = 16;
            this.listBoxFavorit.Location = new System.Drawing.Point(0, 34);
            this.listBoxFavorit.Name = "listBoxFavorit";
            this.listBoxFavorit.Size = new System.Drawing.Size(144, 377);
            this.listBoxFavorit.TabIndex = 2;
            this.listBoxFavorit.DoubleClick += new System.EventHandler(this.listBoxFavorit_DoubleClick);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroButtonAddFavorite);
            this.metroPanel4.Controls.Add(this.metroButton3);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(144, 34);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroButtonAddFavorite
            // 
            this.metroButtonAddFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonAddFavorite.Location = new System.Drawing.Point(31, 0);
            this.metroButtonAddFavorite.Name = "metroButtonAddFavorite";
            this.metroButtonAddFavorite.Size = new System.Drawing.Size(113, 34);
            this.metroButtonAddFavorite.TabIndex = 4;
            this.metroButtonAddFavorite.Text = "Add Favorite";
            this.metroButtonAddFavorite.UseSelectable = true;
            this.metroButtonAddFavorite.Click += new System.EventHandler(this.metroButtonAddFavorite_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::WindowsFormsBrowserApp.Properties.Resources._20_Favorit_2_512;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButton3.Enabled = false;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Location = new System.Drawing.Point(0, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(31, 34);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "⬅";
            this.metroButton3.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroButtonRemoveFavorite);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 411);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(144, 36);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroButtonRemoveFavorite
            // 
            this.metroButtonRemoveFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonRemoveFavorite.Location = new System.Drawing.Point(14, 7);
            this.metroButtonRemoveFavorite.Name = "metroButtonRemoveFavorite";
            this.metroButtonRemoveFavorite.Size = new System.Drawing.Size(118, 23);
            this.metroButtonRemoveFavorite.TabIndex = 2;
            this.metroButtonRemoveFavorite.Text = "Remove Favorite";
            this.metroButtonRemoveFavorite.UseSelectable = true;
            this.metroButtonRemoveFavorite.Click += new System.EventHandler(this.metroButtonRemoveFavorite_Click);
            // 
            // Browser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(887, 581);
            this.Controls.Add(this.splitContainerBasic);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Browser";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browser_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.splitContainerBasic.Panel1.ResumeLayout(false);
            this.splitContainerBasic.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasic)).EndInit();
            this.splitContainerBasic.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.splitContainerSecondary.Panel1.ResumeLayout(false);
            this.splitContainerSecondary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecondary)).EndInit();
            this.splitContainerSecondary.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroButton metroButtonHome;
        private MetroFramework.Controls.MetroButton metroButtonHistory;
        private MetroFramework.Controls.MetroButton metroButtonFavorite;
        private MetroFramework.Controls.MetroButton metroButtonSettings;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private MetroFramework.Controls.MetroButton metroButtonNext;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUri;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.SplitContainer splitContainerBasic;
        private System.Windows.Forms.SplitContainer splitContainerSecondary;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton metroButtonRemoveFavorite;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.ListBox listBoxFavorit;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton metroButtonAddFavorite;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton metroButtonRemovePage;
        private MetroFramework.Controls.MetroButton metroButtonAddPage;
        private System.Windows.Forms.ListBox listBoxHistory;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroButton metroButtonGo;
        private MetroFramework.Controls.MetroButton metroButtonRemove;
    }
}

