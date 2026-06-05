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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
        }

        private void addClaimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            this.Hide();
            newAddClaim.Show();
        }

        private void updateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            this.Hide();
            newUpdateClaim.Show();
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            this.Hide();
            newAddBranch.Show();
        }

        private void updateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }
    }
}
