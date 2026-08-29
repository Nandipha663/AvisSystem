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
    public partial class ManageInspection : Form
    {
        public ManageInspection()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.Show();
            this.Hide();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomersForm = new ManageCustomers();
            manageCustomersForm.Show();
            this.Hide();
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingForm = new AddBookingReservation();
            addBookingForm.Show();
            this.Hide();
        }

        private void viewUpdateBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservationForm = new UpdateReservation();
            updateReservationForm.Show();
            this.Hide();
        }

        private void addNewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addRentalForm = new AddRental();
            addRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         UpdateRental updateRentalForm = new UpdateRental();
            updateRentalForm.Show();
            this.Hide();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();
            addVehicleForm.Show();
            this.Hide();
        }

        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehiclesForm = new UpdateVehicles();
            updateVehiclesForm.Show();
            this.Hide();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddPayment addPaymentForm = new AddPayment();
            addPaymentForm.Show();
            this.Hide();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment updatePaymentForm = new UpdatePayment();
            updatePaymentForm.Show();
            this.Hide();
        }

        private void adNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaimForm = new AddClaim();
            addClaimForm.Show();
            this.Hide();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim updateClaimForm = new UpdateClaim();
            updateClaimForm.Show();
            this.Hide();
        }

        private void viewBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch updateBranchForm = new UpdateBranch();
            updateBranchForm.Show();
            this.Hide();
        }

        private void signUpNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployeeForm = new ManageEmployee();
            manageEmployeeForm.Show();
            this.Hide();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalForm = new AddRentalRental();
            addRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalForm = new UpdateRentalRental();
            updateRentalForm.Show();
            this.Hide();
        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection addInspectionForm = new AddInspection();
            addInspectionForm.Show();
            this.Hide();
        }

        private void ManageInspection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.Vehicle_Inspection' table. You can move, or remove it, as needed.
            this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

        }
    }
}

