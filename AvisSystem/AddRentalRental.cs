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

namespace AvisSystem
{
    public partial class AddRentalRental : Form
    {
        private string connectionString;
        private int? selectedCustomerId = null; 

        public AddRentalRental(string connectionString)
        {
            InitializeComponent();
            
        }

        public AddRentalRental()
        {
            InitializeComponent();
            this.connectionString = Properties.Settings.Default.GroupPmb3ConnectionString; 
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.ShowDialog();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingForm = new AddBookingReservation();
            addBookingForm.ShowDialog();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservationForm = new UpdateReservation();
            updateReservationForm.ShowDialog();
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();
            addVehicleForm.ShowDialog();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehiclesForm = new UpdateVehicles();
            updateVehiclesForm.ShowDialog();
        }

        private void manageReturnedVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addRental = new AddRental();
            addRental.ShowDialog();
        }

        private void viewUpdateVehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental updateRental = new UpdateRental();
            updateRental.ShowDialog();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment addPaymentForm = new AddPayment();
            addPaymentForm.ShowDialog();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment addPaymentForm = new UpdatePayment();
            addPaymentForm.ShowDialog();
        }

        private void manageClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaim = new AddClaim();
            addClaim.ShowDialog();
        }

        private void viewUpdateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim updateClaim = new UpdateClaim();
            updateClaim.ShowDialog();
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection addInspectionRecord = new AddInspection();
            addInspectionRecord.ShowDialog();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRental = new AddRentalRental();
            addRentalRental.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalRentalForm = new UpdateRentalRental();
            updateRentalRentalForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void AddRentalRental_Load(object sender, EventArgs e)
        {

            this.rENTALTableAdapter.Fill(this.avisDS.RENTAL);

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            rENTALTableAdapter.Fill(avisDS.RENTAL);

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            rENTALTableAdapter.FillByCustName(avisDS.RENTAL, textBox3.Text);
        }

        private void RentalGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = RentalGridView.Rows[e.RowIndex];

            if (RentalGridView.Columns.Contains("CustomerID"))
                selectedCustomerId = row.Cells["CustomerID"].Value != null ?
                    Convert.ToInt32(row.Cells["CustomerID"].Value) :
                    (int?)null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    MessageBox.Show("Database connection string is not set.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate required fields before hitting the database
                if (!int.TryParse(textBox6.Text, out int bookingId))
                {
                    MessageBox.Show("Please select a valid Booking (Booking ID is missing or invalid).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedCustomerId == null)
                {
                    MessageBox.Show("Please select a customer from the grid first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = @"INSERT INTO [RENTAL]
                ([BookingID], [CustomerID], [CustomerName], [VehicleVinNo], [EmployeeID],
                [EmployeeName], [PickupDate], [StartDate], [ExpectedReturnDate],
                [RentalStatus], [DepositAmount], [VehicleMakeModel])
                VALUES
                (@BookingID, @CustomerID, @CustomerName, @VehicleVinNo, @EmployeeID,
                @EmployeeName, @PickupDate, @StartDate, @ExpectedReturnDate,
                @RentalStatus, @DepositAmount, @VehicleMakeModel);";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // --- Status-specific checks ---
                    string statusQuery = @"SELECT [RentalStatus] FROM [RENTAL] WHERE [BookingID] = @BookingID;";
                    using (SqlCommand statusCmd = new SqlCommand(statusQuery, conn))
                    {
                        statusCmd.Parameters.AddWithValue("@BookingID", bookingId);
                        using (SqlDataReader reader = statusCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string status = reader["RentalStatus"].ToString();

                                if (status == "Completed")
                                {
                                    MessageBox.Show("This booking has already been completed and cannot be added again.", "Booking Already Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if (status == "Active")
                                {
                                    MessageBox.Show("This booking already has an active rental in progress.", "Booking Already Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                if (status == "Cancelled")
                                {
                                    DialogResult result = MessageBox.Show(
                                    "This booking was previously cancelled. Do you want to create a new rental for it?",
                                    "Previously Cancelled Booking",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                                    if (result != DialogResult.Yes)
                                        return;
                                }
                            }
                        }
                    }

                    // Separate check: warn (but don't block) if a cancelled rental exists for this booking
                    string cancelledQuery = @"SELECT COUNT(*) FROM [RENTAL] WHERE [BookingID] = @BookingID AND [RentalStatus] = 'Cancelled';";
                    using (SqlCommand cancelledCmd = new SqlCommand(cancelledQuery, conn))
                    {
                        cancelledCmd.Parameters.AddWithValue("@BookingID", bookingId);
                        int cancelledCount = (int)cancelledCmd.ExecuteScalar();

                        if (cancelledCount > 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "This booking was previously cancelled. Do you want to create a new rental for it?",
                                "Previously Cancelled Booking",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result != DialogResult.Yes)
                                return;
                        }
                    }

                    // --- Insert (your existing logic, unchanged) ---
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingId);
                        cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId.Value);
                        cmd.Parameters.AddWithValue("@CustomerName",
                            string.IsNullOrEmpty(textBox5.Text) ? (object)DBNull.Value : textBox5.Text);
                        cmd.Parameters.AddWithValue("@VehicleVinNo",
                            string.IsNullOrEmpty(textBox1.Text) ? (object)DBNull.Value : textBox1.Text);
                        if (int.TryParse(textBox7.Text, out int employeeId))
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                        else
                            cmd.Parameters.AddWithValue("@EmployeeID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@EmployeeName",
                            string.IsNullOrEmpty(textBox8.Text) ? (object)DBNull.Value : textBox8.Text);
                        DateTime pickupDateTime = dateTimePicker1.Value.Date + dateTimePicker4.Value.TimeOfDay;
                        cmd.Parameters.AddWithValue("@PickupDate", pickupDateTime);
                        cmd.Parameters.AddWithValue("@StartDate", pickupDateTime);
                        DateTime returnDateTime = dateTimePicker2.Value.Date + dateTimePicker3.Value.TimeOfDay;
                        cmd.Parameters.AddWithValue("@ExpectedReturnDate", returnDateTime);
                        cmd.Parameters.AddWithValue("@RentalStatus", "Active");
                       // cmd.Parameters.AddWithValue("@RentalStatus", 
                           // string.IsNullOrEmpty(textBox4.Text) ? (object)"Active" : textBox4.Text);
                        cmd.Parameters.AddWithValue("@DepositAmount", DBNull.Value);
                        cmd.Parameters.AddWithValue("@VehicleMakeModel",
                            string.IsNullOrEmpty(textBox2.Text) ? (object)DBNull.Value : textBox2.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rental added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Text = "Active";
                        rENTALTableAdapter.Fill(avisDS.RENTAL);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding rental: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RentalGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = RentalGridView.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = RentalGridView.CurrentRow.Cells[11].Value.ToString();
            textBox4.Text = RentalGridView.CurrentRow.Cells[10].Value.ToString();
            textBox5.Text = RentalGridView.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = RentalGridView.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = RentalGridView.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = RentalGridView.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = RentalGridView.CurrentRow.Cells[6].Value.ToString();


            selectedCustomerId = RentalGridView.CurrentRow.Cells[2].Value != null?
            Convert.ToInt32(RentalGridView.CurrentRow.Cells[2].Value):
            (int?)null;
        }

        private void viewRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRental = new AddRentalRental();
            addRentalRental.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Please select a date that is not in the past", "Error");
                dateTimePicker1.Value= DateTime.Now;
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value< dateTimePicker1.Value)
            {
                MessageBox.Show("Return date cannot be before pick up date", "Error");
                dateTimePicker2.Value= DateTime.Now;
            }
        }
    }
}







