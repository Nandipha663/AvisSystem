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
    public partial class UpdateReservation : Form
    {
        public UpdateReservation()
        {
            InitializeComponent();
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateReservation_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;

            // TODO: This line of code loads data into the 'avisDS.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.avisDS.BOOKING);
            fileToolStripMenuItem.Enabled = true;
            viewUpdateBookingToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bOOKINGTableAdapter.FillByBookingID(avisDS.BOOKING, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                this.Validate();
                bOOKINGBindingSource.EndEdit();
                //bOOKINGTableAdapter.Update(avisDS.BOOKING);

                bOOKINGTableAdapter.Fill(avisDS.BOOKING);
                MessageBox.Show($"Vehicle Return Updated with:\nBooking ID: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void manageReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();
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

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "🔍 Search Reservation...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search Reservation...";
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

        private void button4_Click(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Status")
                {
                    if (string.IsNullOrEmpty(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a filter first.");
                        return;
                    }

                    if (comboBox2.Text == "Reserved")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Reserved'";
                    }
                    else if (comboBox2.Text == "Completed")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Completed'";
                    }
                    else if (comboBox2.Text == "Pending")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Pending'";
                    }
                    else if (comboBox2.Text == "Rented Out")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Rented Out'";
                    }
                    else if (comboBox2.Text == "Cancelled")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Cancelled'";
                    }
                    else if (comboBox2.Text == "Overdue")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Overdue'";
                    }

                }
                else if (comboBox1.Text == "Booking Date")
                {
                    DateTime date = dateTimePicker1.Value.Date;

                    bOOKINGBindingSource.Filter =
                        $"[Booking Date] >= '{date:yyyy-MM-dd}' AND [Booking Date] < '{date.AddDays(1):yyyy-MM-dd}'";
                }
                else if (comboBox1.Text == "Expected Return Date")
                {
                    DateTime date = dateTimePicker2.Value.Date;

                    bOOKINGBindingSource.Filter =
                        $"ExpectedReturnDate >= '{date:yyyy-MM-dd}' AND ExpectedReturnDate < '{date.AddDays(1):yyyy-MM-dd}'";
                }
                else
                {
                    MessageBox.Show("Please select a filter first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                  "Are you sure you want to delete this vehicle return record?",
                                  "Confirm Delete",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question
                                  );

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bOOKINGTableAdapter.DeleteBooking(id);

                MessageBox.Show("Vehicle return record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bOOKINGTableAdapter.Fill(avisDS.BOOKING);
            }
            else
            {
                MessageBox.Show("Vehicle Return record deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search Reservation...";
            textBox1.ForeColor = Color.Gray;
            textBox2.Clear();
            bOOKINGTableAdapter.Fill(avisDS.BOOKING);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Status")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("Reserved");
                comboBox2.Items.Add("Completed");
                comboBox2.Items.Add("Pending");
                comboBox2.Items.Add("Cancelled");
                comboBox2.Items.Add("Overdue");
            }
            else if (comboBox1.Text == "Booking Date")
            {

                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
            else if (comboBox1.Text == "Expected return date")
            {
                comboBox2.Enabled = false;
                dateTimePicker2.Enabled = true;
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
                bOOKINGBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                if (value != null)
                {
                    textBox2.Text = value.ToString();
                }
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
            manageEmp.Show();
            this.Hide();
        }
    }
}
