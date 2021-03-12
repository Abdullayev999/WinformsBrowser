
namespace WindowsFormsBrowserApp
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxHomeUri = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSearchPage = new System.Windows.Forms.ComboBox();
            this.metroButtonAllHistoryRemove = new MetroFramework.Controls.MetroButton();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(174, 30);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "🏠 Home Page :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(24, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(183, 29);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "🔍 Search Page :";
            // 
            // metroTextBoxHomeUri
            // 
            this.metroTextBoxHomeUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxHomeUri.CustomButton.Image = null;
            this.metroTextBoxHomeUri.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.metroTextBoxHomeUri.CustomButton.Name = "";
            this.metroTextBoxHomeUri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxHomeUri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxHomeUri.CustomButton.TabIndex = 1;
            this.metroTextBoxHomeUri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxHomeUri.CustomButton.UseSelectable = true;
            this.metroTextBoxHomeUri.CustomButton.Visible = false;
            this.metroTextBoxHomeUri.Lines = new string[0];
            this.metroTextBoxHomeUri.Location = new System.Drawing.Point(33, 122);
            this.metroTextBoxHomeUri.MaxLength = 32767;
            this.metroTextBoxHomeUri.Name = "metroTextBoxHomeUri";
            this.metroTextBoxHomeUri.PasswordChar = '\0';
            this.metroTextBoxHomeUri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxHomeUri.SelectedText = "";
            this.metroTextBoxHomeUri.SelectionLength = 0;
            this.metroTextBoxHomeUri.SelectionStart = 0;
            this.metroTextBoxHomeUri.ShortcutsEnabled = true;
            this.metroTextBoxHomeUri.Size = new System.Drawing.Size(270, 23);
            this.metroTextBoxHomeUri.TabIndex = 2;
            this.metroTextBoxHomeUri.UseSelectable = true;
            this.metroTextBoxHomeUri.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxHomeUri.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxSearchPage
            // 
            this.comboBoxSearchPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchPage.FormattingEnabled = true;
            this.comboBoxSearchPage.Items.AddRange(new object[] {
            "Google",
            "Yandex",
            "Bing"});
            this.comboBoxSearchPage.Location = new System.Drawing.Point(33, 209);
            this.comboBoxSearchPage.Name = "comboBoxSearchPage";
            this.comboBoxSearchPage.Size = new System.Drawing.Size(270, 24);
            this.comboBoxSearchPage.TabIndex = 3;
            // 
            // metroButtonAllHistoryRemove
            // 
            this.metroButtonAllHistoryRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonAllHistoryRemove.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAllHistoryRemove.Location = new System.Drawing.Point(217, 265);
            this.metroButtonAllHistoryRemove.Name = "metroButtonAllHistoryRemove";
            this.metroButtonAllHistoryRemove.Size = new System.Drawing.Size(86, 33);
            this.metroButtonAllHistoryRemove.TabIndex = 4;
            this.metroButtonAllHistoryRemove.Text = "🗑";
            this.metroButtonAllHistoryRemove.UseSelectable = true;
            this.metroButtonAllHistoryRemove.Click += new System.EventHandler(this.metroButtonAllHistoryRemove_Click);
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonOk.Location = new System.Drawing.Point(33, 337);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(270, 33);
            this.metroButtonOk.TabIndex = 5;
            this.metroButtonOk.Text = "Ok";
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(33, 268);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(178, 30);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "🗺 All History : ";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 402);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButtonOk);
            this.Controls.Add(this.metroButtonAllHistoryRemove);
            this.Controls.Add(this.comboBoxSearchPage);
            this.Controls.Add(this.metroTextBoxHomeUri);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(515, 420);
            this.MinimumSize = new System.Drawing.Size(339, 397);
            this.Name = "SettingForm";
            this.Text = "⚙  Settings  ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxHomeUri;
        private MetroFramework.Controls.MetroButton metroButtonAllHistoryRemove;
        private MetroFramework.Controls.MetroButton metroButtonOk;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public System.Windows.Forms.ComboBox comboBoxSearchPage;
    }
}