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
    public partial class AddInspection : Form
    {
        public AddInspection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                maskedTextBox1.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();

                dateTimePicker2.Value = DateTime.Now;
            }
            else if(radioButton2.Checked)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                maskedTextBox2.Clear();
                textBox8.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
              //  groupBox2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
             //   groupBox3.Visible = false;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void AddInspection_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewInspectionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInspection manageInspectionForm = new ManageInspection();
            manageInspectionForm.Show();
            this.Hide();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomersForm = new ManageCustomers();
            manageCustomersForm.Show();
            this.Hide();
        }

        private void addBookingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingReservationForm = new AddBookingReservation();
            addBookingReservationForm.Show();
            this.Hide();
        }

        private void viewBookingToolStripItem2_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservationForm = new UpdateReservation();
            updateReservationForm.Show();
            this.Hide();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addRentalForm = new AddRental();
            addRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental updateRentalForm = new UpdateRental();
            updateRentalForm.Show();
            this.Hide();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();
            addVehicleForm.Show();
            this.Hide();
        }

        private void viewUpdateVehicleStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehiclesForm = new UpdateVehicles();
            updateVehiclesForm.Show();
            this.Hide();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaimForm = new AddClaim();
            addClaimForm.Show();
            this.Show();
        }

        private void updateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim updateClaimForm = new UpdateClaim();
            updateClaimForm.Show();
            this.Hide();
        }

        private void updateBranchToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployeeForm = new ManageEmployee();
            manageEmployeeForm.Show();
            this.Hide();
        }

        private void addRentalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalForm = new AddRentalRental();
            addRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalForm = new UpdateRentalRental();
            updateRentalForm.Show();
            this.Hide();
        }
    }
}
