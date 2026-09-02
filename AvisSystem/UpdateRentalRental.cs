using AvisSystem.AvisDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; 

namespace AvisSystem
{
    public partial class UpdateRentalRental : Form
    {
        private string connectionString;


        public UpdateRentalRental()
        {
            InitializeComponent();

            // Initialize connectionString from the table adapter (designer sets this), fallback to config.
            connectionString = rENTALTableAdapter?.Connection?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                // Replace "AvisDB" with the actual name of your connection string in App.config / Settings
                //connectionString = ConfigurationManager.ConnectionStrings["AvisDB"]?.ConnectionString;
            }
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
        { comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a rental first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var drv = dataGridView1.CurrentRow?.DataBoundItem as DataRowView;
            if (drv == null) { MessageBox.Show("Select a row."); return; }

            int rentalID = Convert.ToInt32(drv["RentalID"]);
            string currentStatus = drv["RentalStatus"]?.ToString();
            string vin = drv["VehicleVinNo"]?.ToString();

               // Use the combo that actually contains status
            string newStatus = comboBox3.SelectedItem?.ToString();

            if (currentStatus == "Completed")
            {
                MessageBox.Show("This rental has already been completed.", "Update Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (currentStatus == "Cancelled")
            {
                MessageBox.Show("This rental has already been cancelled.", "Update Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (currentStatus != "Confirmed")
            {
                MessageBox.Show("Only rentals with a status of 'Confirmed' can be updated.",
                    "Update Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to change this rental's status to '{newStatus}'?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Update the rental status
                    string updateRentalQuery = @"UPDATE RENTAL 
                                          SET RentalStatus = @RentalStatus 
                                          WHERE RentalID = @RentalID";

                    using (SqlCommand cmd = new SqlCommand(updateRentalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RentalStatus", newStatus);
                        cmd.Parameters.AddWithValue("@RentalID", rentalID);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Make the vehicle available at the correct branch
                    string branch;
                    if (newStatus == "Cancelled")
                        branch = dataGridView1.CurrentRow.Cells["PickupBranch"].Value.ToString();
                    else // "Completed"
                        branch = dataGridView1.CurrentRow.Cells["ReturnBranch"].Value.ToString();

                    string updateVehicleQuery = @"UPDATE VEHICLE 
                                           SET VehicleStatus = 'Available', 
                                               Branch = @Branch 
                                           WHERE VehicleVinNo = @VIN";

                    using (SqlCommand cmd = new SqlCommand(updateVehicleQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Branch", branch);
                        cmd.Parameters.AddWithValue("@VIN", vin);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Rental {rentalID} has been updated to '{newStatus}'.",
                    "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the grid
                rENTALTableAdapter.Fill(avisDS.RENTAL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rental: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
