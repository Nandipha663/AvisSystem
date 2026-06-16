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
            label8.Click += panel1_Click;
            label9.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
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
            // TODO: This line of code loads data into the 'avisDS.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.avisDS.BOOKING);
            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            addPaymentToolStripMenuItem.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
            this.Hide();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            newAddCustomer.Show();
            this.Hide();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ManageCustomers newManageCustomers = new ManageCustomers();
                newManageCustomers.Show();
                this.Hide();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AddVehicle newAddVehicle = new AddVehicle();
                newAddVehicle.Show();
                this.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            newUpdateVehicles.Show();
            this.Hide();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();    
            newAddReservation.Show();
            this.Hide();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservations = new UpdateReservation();
            newUpdateReservations.Show();
            this.Hide();

        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            newAddRental.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            newUpdateRental.Show();
            this.Hide();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            newUpdatePayment.Show();
            this.Hide();
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            newAddClaim.Show();
            this.Hide();
        }

        private void updateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            newUpdateClaim.Show();
            this.Hide();
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            newAddBranch.Show();
            this.Hide();
        }

        private void updateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            textBox3.Text =""; ;

            //comboBox1.Text = "";
            // maskedTextBox2.Clear();
            textBox4.Clear();
            dateTimePicker1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm newHomeForm = new HomeForm();
            newHomeForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            newAvisMenuForm.Show();
            this.Hide();
        }

        AvisSystem.AvisDSTableAdapters.PAYMENTTableAdapter vehicleTA = new AvisSystem.AvisDSTableAdapters.PAYMENTTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //vehicleTA.AddNewPayment(textBox2.Text, Convert.ToInt32(comboBox2.SelectedValue), comboBox2.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToDecimal(maskedTextBox2.Text), comboBox3.SelectedValue.ToString(), textBox1.Text.ToString());
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
            signUp.Show();
            this.Hide();
        }

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            manageEmp.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            bOOKINGTableAdapter.FillByCustomerName(avisDS.BOOKING, textBox2.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox3.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
