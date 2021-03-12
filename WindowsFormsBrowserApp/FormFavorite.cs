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
    public partial class FavoriteForm : MetroFramework.Forms.MetroForm
    {
        public string FavoritName { get; set; }
        public FavoriteForm()
        {
            InitializeComponent();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            if (this.metroTextBoxFavoriteNameAdd.Text!=null)
            {
                FavoritName = metroTextBoxFavoriteNameAdd.Text;
            }
            this.Close();
        }
    }
}
