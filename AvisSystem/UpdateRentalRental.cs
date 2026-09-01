using AvisSystem.AvisDSTableAdapters;
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
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
                        manageCustomers.Show();
            this.Hide();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingReservation = new AddBookingReservation();
            addBookingReservation.Show();
            this.Hide();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservation = new UpdateReservation();
            updateReservation.Show();
            this.Hide();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
                        addVehicle.Show();
            this.Hide();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehicles = new UpdateVehicles();
            updateVehicles.Show();
            this.Hide();
        }

        private void addVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addRental = new AddRental();
            addRental.Show();
            this.Hide();
        }

        private void viewUpdateVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental updateRental = new UpdateRental();
                        updateRental.Show();
            this.Hide();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment addPayment = new AddPayment();
                addPayment.Show();
            this.Hide();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment addPayment = new UpdatePayment();
            addPayment.Show();
            this.Hide();
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaim = new AddClaim();
                        addClaim.Show();
            this.Hide();
        }

        private void viewUpdateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim addClaim = new UpdateClaim();
            addClaim.Show();
            this.Hide();
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
            manageEmployee.Show();
            this.Hide();
        }

        private void manageInspectionRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewUpdateInspectionRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInspection manageInspection = new ManageInspection();
                        manageInspection.Show();
            this.Hide();
        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection addInspection = new AddInspection();
            addInspection.Show();
            this.Hide();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRental = new AddRentalRental();
                        addRentalRental.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalRental = new UpdateRentalRental();
                        updateRentalRental.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateRentalRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.avisDS.RENTAL);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search Rentals...";
            textBox1.ForeColor = Color.Gray;
            textBox2.Clear();
            textBox3.Clear();
            rENTALTableAdapter.Fill(avisDS.RENTAL);

        }
    }
}
