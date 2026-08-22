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
    public partial class AddRentalRental : Form
    {
        public AddRentalRental()
        {
            InitializeComponent();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); 
         }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            HomeForm homeForm = new HomeForm();
            homeForm.Show();

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.ShowDialog();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingForm = new AddBookingReservation();
            addBookingForm.ShowDialog();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          UpdateReservation updateReservationForm = new UpdateReservation();
            updateReservationForm.ShowDialog();
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();
            addVehicleForm.ShowDialog();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehiclesForm = new UpdateVehicles();
            updateVehiclesForm.ShowDialog();
        }

        private void manageReturnedVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addRental = new AddRental();
            addRental.ShowDialog();
        }

        private void viewUpdateVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental updateRental = new UpdateRental();
            updateRental.ShowDialog();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment addPaymentForm = new AddPayment();
                        addPaymentForm.ShowDialog();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment addPaymentForm = new UpdatePayment();
            addPaymentForm.ShowDialog();
        }

        private void manageClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaim = new AddClaim();
            addClaim.ShowDialog();
        }

        private void viewUpdateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim updateClaim = new UpdateClaim();
            updateClaim.ShowDialog();
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection addInspectionRecord = new AddInspection();
            addInspectionRecord.ShowDialog();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRental = new AddRentalRental();
                        addRentalRental.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
