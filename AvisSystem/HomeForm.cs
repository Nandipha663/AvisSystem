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
            label1.Text = DateTime.Now.ToShortTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();

            manageEmployeesToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = false;

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental AddRentalRentalForm = new AddRentalRental();
            AddRentalRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental UpdateRentalRentalForm = new UpdateRentalRental();
            UpdateRentalRentalForm.Show();
            this.Hide();
        }

        private void manageRentalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void manageInspectionRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
