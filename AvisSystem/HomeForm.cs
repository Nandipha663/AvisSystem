using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisSystem
{
    public partial class HomeForm : Form
    {
        public static HomeForm main;
        public HomeForm()
        {
            InitializeComponent();
            main = this;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();

            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = false;

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
