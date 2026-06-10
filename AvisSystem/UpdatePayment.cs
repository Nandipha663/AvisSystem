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
    public partial class UpdatePayment : Form
    {
        public UpdatePayment()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void UpdatePayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.PAYMENT' table. You can move, or remove it, as needed.
            this.pAYMENTTableAdapter.Fill(this.avisDS.PAYMENT);
            fileToolStripMenuItem.Enabled = true;
            viewUpdatePaymentToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();

        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            this.Hide();
            newAddRental.Show();
        }

        private void viewUpdateRentalStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            this.Hide();
            newUpdateRental.Show();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void manageRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "🔍 Search Payments...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search Payments...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void addNewClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            this.Hide();
            newAddClaim.Show();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateClaim newUpdateClaim = new UpdateClaim();
            this.Hide();
            newUpdateClaim.Show();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddBranch newAddBranch = new AddBranch();
            this.Hide();
            newAddBranch.Show();
        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Payment Type")
                {
                    if (string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a payment type first.");
                        return;
                    }

                    pAYMENTBindingSource.Filter =
                        $"PaymentType = '{comboBox2.Text}'";
                }

                else if (comboBox1.Text == "Payment Status")
                {
                    if (string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a payment status first.");
                        return;
                    }

                    pAYMENTBindingSource.Filter =
                        $"PaymentStatus = '{comboBox2.Text}'";
                }

                else if (comboBox1.Text == "Date")
                {
                    if (dateTimePicker1.CustomFormat == " ")
                    {
                        MessageBox.Show("Please select a date first.");
                        return;
                    }

                    DateTime date = dateTimePicker1.Value.Date;

                    pAYMENTBindingSource.Filter =
                        $"PaymentDate >= #{date:yyyy-MM-dd}# AND PaymentDate < #{date.AddDays(1):yyyy-MM-dd}#";
                }

                else
                {
                    MessageBox.Show("Please select a filter category first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                textBox1.Text == "🔍 Search Payment...")
            {
                pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
                return;
            }

            pAYMENTTableAdapter.FillByBookingID(avisDS.PAYMENT, textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Payment Type")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("EFT");
                comboBox2.Items.Add("Cash");
                comboBox2.Items.Add("Debit Card");
                comboBox2.Items.Add("Credit Card");
            }
            else if (comboBox1.Text == "Payment Status")
            {

                comboBox2.Enabled = true;
                comboBox2.Items.Add("Complete");
                comboBox2.Items.Add("Incomplete");
                comboBox2.Items.Add("Pending");
                comboBox2.Items.Add("Confirmed");
                comboBox2.Items.Add("Cancelled");

            } else if (comboBox1.Text == "Date")
            {
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                pAYMENTBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;

                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[3].Value;

                if (value != null)
                {
                    textBox2.Text = value.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                this.Validate();
                pAYMENTBindingSource.EndEdit();
                pAYMENTTableAdapter.Update(avisDS.PAYMENT);

                pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
                MessageBox.Show($"Vehicle Return Updated with:\nBooking ID: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text  = "🔍 Search Payment...";
            textBox2.Clear();

            // Reset ComboBoxes
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

            pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
        }
    }
}
