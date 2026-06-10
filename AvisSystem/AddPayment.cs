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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            addPaymentToolStripMenuItem.Enabled = false;
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

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ManageCustomers newManageCustomers = new ManageCustomers();
                this.Hide();
                newManageCustomers.Show();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AddVehicle newAddVehicle = new AddVehicle();
                this.Hide();
                newAddVehicle.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();    
            this.Hide();
            newAddReservation.Show();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservations = new UpdateReservation();
            this.Hide();
            newUpdateReservations.Show();

        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            this.Hide();
            newAddRental.Show();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            this.Hide();
            newUpdateRental.Show();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            this.Hide();
            newUpdatePayment.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            //comboBox1.Text = "";
            maskedTextBox2.Clear();
            dateTimePicker1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm newHomeForm = new HomeForm();
            this.Hide();
            newHomeForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        AvisSystem.AvisDSTableAdapters.PAYMENTTableAdapter vehicleTA = new AvisSystem.AvisDSTableAdapters.PAYMENTTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vehicleTA.AddNewPayment(textBox2.Text, Convert.ToInt32(comboBox2.SelectedValue), comboBox2.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToDecimal(maskedTextBox2.Text), comboBox3.SelectedValue.ToString(), textBox1.Text.ToString());
                MessageBox.Show("transaction recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Refill Payment table
                UpdatePayment pay = Application.OpenForms["UpdatePayment"] as UpdatePayment;

                if (pay != null)
                {
                    pay.LoadPayments(); // refresh open form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while recording a transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void signUpEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            this.Hide();
            signUp.Show();
        }

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            this.Hide();
            manageEmp.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
