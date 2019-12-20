using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Project.UI
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            AdminGame f2 = new AdminGame();
            f2.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AdminGameCategory f2 = new AdminGameCategory();
            f2.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminUser f2 = new AdminUser();
            f2.Show();
        }
    }
}
