
namespace WindowsFormsBrowserApp
{
    partial class FavoriteForm
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
            this.metroTextBoxFavoriteNameAdd = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name : ";
            // 
            // metroTextBoxFavoriteNameAdd
            // 
            // 
            // 
            // 
            this.metroTextBoxFavoriteNameAdd.CustomButton.Image = null;
            this.metroTextBoxFavoriteNameAdd.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.metroTextBoxFavoriteNameAdd.CustomButton.Name = "";
            this.metroTextBoxFavoriteNameAdd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFavoriteNameAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFavoriteNameAdd.CustomButton.TabIndex = 1;
            this.metroTextBoxFavoriteNameAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFavoriteNameAdd.CustomButton.UseSelectable = true;
            this.metroTextBoxFavoriteNameAdd.CustomButton.Visible = false;
            this.metroTextBoxFavoriteNameAdd.Lines = new string[0];
            this.metroTextBoxFavoriteNameAdd.Location = new System.Drawing.Point(125, 86);
            this.metroTextBoxFavoriteNameAdd.MaxLength = 32767;
            this.metroTextBoxFavoriteNameAdd.Name = "metroTextBoxFavoriteNameAdd";
            this.metroTextBoxFavoriteNameAdd.PasswordChar = '\0';
            this.metroTextBoxFavoriteNameAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFavoriteNameAdd.SelectedText = "";
            this.metroTextBoxFavoriteNameAdd.SelectionLength = 0;
            this.metroTextBoxFavoriteNameAdd.SelectionStart = 0;
            this.metroTextBoxFavoriteNameAdd.ShortcutsEnabled = true;
            this.metroTextBoxFavoriteNameAdd.Size = new System.Drawing.Size(215, 23);
            this.metroTextBoxFavoriteNameAdd.TabIndex = 1;
            this.metroTextBoxFavoriteNameAdd.UseSelectable = true;
            this.metroTextBoxFavoriteNameAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFavoriteNameAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonCancel.Location = new System.Drawing.Point(122, 147);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(106, 34);
            this.metroButtonCancel.TabIndex = 2;
            this.metroButtonCancel.Text = "Cancel";
            this.metroButtonCancel.UseSelectable = true;
            this.metroButtonCancel.Click += new System.EventHandler(this.metroButtonCancel_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonAdd.Location = new System.Drawing.Point(234, 147);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(106, 34);
            this.metroButtonAdd.TabIndex = 3;
            this.metroButtonAdd.Text = "Add";
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 210);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroTextBoxFavoriteNameAdd);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavoriteForm";
            this.Text = "⭐ Favorite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFavoriteNameAdd;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
    }
}