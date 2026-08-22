using AvisSystem.AvisDSTableAdapters;
using Org.BouncyCastle.Tls;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AvisMenuForm avisMenuForm = new AvisMenuForm();
            avisMenuForm.Show();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.avisDS.CUSTOMER);
            addNewCustomerToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ManageCustomers newManageCustomers = new ManageCustomers();
                this.Hide();
                newManageCustomers.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }


        private void viewUpdateCustomerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void viewUpdateReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();
        }

        private void addNewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            this.Hide();
            newAddRental.Show();
        }

        private void viewUpdateRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            this.Hide();
            newUpdateRental.Show();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            this.Hide();
            newAddVehicle.Show();
        }

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            this.Hide();
            newAddPayment.Show();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            this.Hide();
            newUpdatePayment.Show();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm newLoginForm = new LoginForm();
            this.Hide();
            newLoginForm.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HomeForm newHomeForm = new HomeForm();
            this.Hide();
            newHomeForm.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
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
           
        }

        private void updateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            comboBox1.Text= "";
            if (comboBox1.SelectedIndex > -1)
                comboBox1.Text = "";
            
            textBox9.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }


        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            cUSTOMERTableAdapter.FillByFullName(avisDS.CUSTOMER, textBox3.Text);
        }
        private bool CustomerExists()
        {
            var adapter = cUSTOMERTableAdapter;

            int count = Convert.ToInt32(
                adapter.CheckDuplicateCustomer(
                    maskedTextBox1.Text.Trim(),
                    textBox14.Text.Trim(),
                    textBox12.Text.Trim()));

            return count > 0;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (CustomerExists())
            {
                MessageBox.Show(
                    "The License Number, Email Address, or Username already exists.",
                    "Duplicate Entry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Insert customer
            cUSTOMERTableAdapter.InsertCustomer(textBox1.Text, textBox9.Text, textBox4.Text, textBox14.Text, maskedTextBox1.Text, comboBox1.Text, textBox12.Text, textBox13.Text); MessageBox.Show("Customer added successfully!");

            MessageBox.Show("Customer added successfully.");
        }


        private void signUpNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void viewUpdateEmplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            manageEmp.Show();
            this.Hide();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection newAddInspection = new AddInspection();
            this.Hide();
            newAddInspection.Show();
        }

        private void viewInspectionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInspection newManageInspection = new ManageInspection();
            this.Hide();
            newManageInspection.Show();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRental = new AddRentalRental();
            this.Hide();
            addRentalRental.Show();
        }
    }
}
