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
    public partial class AvisMenuForm : Form
    {
        public AvisMenuForm()
        {
            InitializeComponent();
        }

        private void AvisMenuForm_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setUpForm(Form form) {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //make the new form a child of the main form and show it
            form.MdiParent = this;

            //make form size of parent
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            LoginForm loginform = new LoginForm();
            setUpForm(loginform);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            setUpForm(homeform);
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReservation newAddReservation = new AddReservation();
            this.Hide();
            newAddReservation.Show();
           
        }

        private void viewScheduledReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();
        }

        private void addRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            this.Hide();
            newAddRental.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            this.Hide();
            newUpdateRental.Show();
        }

        private void viewVehiclesStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();   
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            this.Hide();
            newAddVehicle.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            this.Hide();
            newAddPayment.Show();
        }

        private void viewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            this.Hide();
            newUpdatePayment.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }
    }
}
