using AvisSystem.AvisDSTableAdapters;
using Newtonsoft.Json.Linq;
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
    public partial class UpdateRental : Form
    {
        public UpdateRental()
        {
            InitializeComponent();
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                //vehicleReturnDetailsTableAdapter.DeleteVehicleReturn(id);

                MessageBox.Show("Vehicle return record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //vehicleReturnDetailsTableAdapter.Fill(avisDS.VenhicleReturnDetails);
            }
            else
            {
                MessageBox.Show("Vehicle Return record deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                this.Validate();
                vEHICLERETURNBindingSource.EndEdit();
              //  vEHICLE_RETURNTableAdapter.Update(avisDS.VEHICLE_RETURN);

                vEHICLE_RETURNTableAdapter.Fill(avisDS.VEHICLE_RETURN);
                MessageBox.Show($"Vehicle Return Updated with:\nBooking ID: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadVehiclesReturn()
        {
            vehicleReturnDetailsTableAdapter.Fill(avisDS.VehicleReturnDetails);
        }

        private void HighlightMostRecentReturnedVehicleUpdate()
        {
            DateTime latestTime = DateTime.MinValue;
            DataGridViewRow latestRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["LastUpdated"].Value != DBNull.Value)
                {
                    DateTime updateTime =
                        Convert.ToDateTime(row.Cells["LastUpdated"].Value);

                    if (updateTime > latestTime)
                    {
                        latestTime = updateTime;
                        latestRow = row;
                    }
                }
            }

            if (latestRow != null)
            {
                dataGridView1.ClearSelection();

                latestRow.Selected = true;
                latestRow.DefaultCellStyle.BackColor = Color.LightGreen;

                dataGridView1.FirstDisplayedScrollingRowIndex =
                    latestRow.Index;
                
            }
        }
        private void UpdateRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.VehicleReturnDetails' table. You can move, or remove it, as needed.
            this.vehicleReturnDetailsTableAdapter.Fill(this.avisDS.VehicleReturnDetails);
            //LoadVehiclesReturn();

            HighlightMostRecentReturnedVehicleUpdate();

            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

            // TODO: This line of code loads data into the 'avisDS.VEHICLE_RETURN' table. You can move, or remove it, as needed.
            //this.vEHICLE_RETURNTableAdapter.Fill(this.avisDS.VEHICLE_RETURN);
            fileToolStripMenuItem.Enabled = true;
            viewUpdateRentalToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
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

        private void addPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            newAddPayment.Show();
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

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            newAddCustomer.Show();
            this.Hide();
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            newManageCustomers.Show();
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
            UpdateReservation newUpdateReservation = new UpdateReservation();
            newUpdateReservation.Show();
            this.Hide();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            newAddVehicle.Show();
            this.Hide();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            newUpdateVehicles.Show();
            this.Hide();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            newUpdatePayment.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "🔍 Search Returned Vehicles...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search Returned Vehicles...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            newAddClaim.Show();
            this.Hide();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            newUpdateClaim.Show();
            this.Hide();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            newAvisMenuForm.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            if (textBox1.Text == "🔍 Search Returned Vehicles...")
                return;
                vehicleReturnDetailsTableAdapter.FillByCustName(avisDS.VehicleReturnDetails, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

            vehicleReturnDetailsTableAdapter.Fill(this.avisDS.VehicleReturnDetails);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Charges")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("Normal Return");
                comboBox2.Items.Add("Damaged / Late Return");
            }else if (comboBox1.Text == "Return Date") {

                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = true; 
            }else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Charges")
                {
                    if (string.IsNullOrEmpty(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a filter first.");
                        return;
                    }

                    if (comboBox2.Text == "Normal Return")
                    {
                        vehicleReturnDetailsBindingSource.Filter = "Charges = 0";
                    }
                    else if (comboBox2.Text == "Damaged / Late Return")
                    {
                        vehicleReturnDetailsBindingSource.Filter = "Charges > 0";
                    }
                }
                else if (comboBox1.Text == "Return Date")
                {
                    DateTime date = dateTimePicker1.Value.Date;

                    vehicleReturnDetailsBindingSource.Filter =
                        $"ReturnDate >= '{date:yyyy-MM-dd}' AND ReturnDate < '{date.AddDays(1):yyyy-MM-dd}'";
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                vehicleReturnDetailsBindingSource.RemoveFilter();

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
            if (textBox1.Text == "🔍 Search Returned Vehicles..."  || textBox1.Text != "🔍 Search Returned Vehicles...")
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
