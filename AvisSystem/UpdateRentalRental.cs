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
    public partial class UpdateRentalRental : Form
    {
        public UpdateRentalRental()
        {
            InitializeComponent();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
                        manageCustomers.ShowDialog();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingReservation = new AddBookingReservation();
            addBookingReservation.ShowDialog();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservation = new UpdateReservation();
            updateReservation.ShowDialog();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
                        addVehicle.ShowDialog();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehicles = new UpdateVehicles();
            updateVehicles.ShowDialog();
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
            AddPayment addPayment = new AddPayment();
                addPayment.ShowDialog();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment addPayment = new UpdatePayment();
            addPayment.ShowDialog();
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaim = new AddClaim();
                        addClaim.ShowDialog();
        }

        private void viewUpdateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim addClaim = new UpdateClaim();
            addClaim.ShowDialog();
        }

        private void branchesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.ShowDialog();
        }

        private void manageInspectionRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewUpdateInspectionRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInspection manageInspection = new ManageInspection();
                        manageInspection.ShowDialog();
        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection addInspection = new AddInspection();
            addInspection.ShowDialog();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRental = new AddRentalRental();
                        addRentalRental.ShowDialog();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalRental = new UpdateRentalRental();
                        updateRentalRental.ShowDialog();
        }
    }
}
