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

        private void viewUpdateCustomerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ManageCustomers ManageCustomers = new ManageCustomers();
            ManageCustomers.Show();
           this.Hide();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation AddReservation = new AddBookingReservation();
            AddReservation.Show();
            this.Hide();
        }

        private void viewUpdateReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation UpdateReservation = new UpdateReservation();
            this.Hide();
            UpdateReservation.Show();
        }

        private void addNewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental AddRental = new AddRental();
            this.Hide();
            AddRental.Show();
        }

        private void viewUpdateRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental UpdateRental = new UpdateRental();
            this.Hide();
           UpdateRental.Show();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle AddVehicle = new AddVehicle();
            this.Hide();
            AddVehicle.Show();
        }

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment AddPayment = new AddPayment();
            this.Hide();
            AddPayment.Show();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment UpdatePayment = new UpdatePayment();
            this.Hide();
            UpdatePayment.Show();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HomeForm HomeForm = new HomeForm();
            this.Hide();
            HomeForm.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim AddClaim = new AddClaim();
            this.Hide();
            AddClaim.Show();
        }

        private void updateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim UpdateClaim = new UpdateClaim();
            this.Hide();
            UpdateClaim.Show();

        }

        private void updateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
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

        private void viewInspectionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInspection manageInspection = new ManageInspection();
            this.Hide();
            manageInspection.Show();
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
    }
}
