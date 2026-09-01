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
         
        public AddRentalRental(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public AddRentalRental()
        {
            InitializeComponent();
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

            if (RentalGridView.Columns.Contains("RentalStatus"))
            {
                string status = row.Cells["RentalStatus"].Value?.ToString();
                if (status == "Inactive")
                {
                    MessageBox.Show("This customer is inactive. Please select an active customer.",
                                    "Inactive Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (RentalGridView.Columns.Contains("RentalID"))
                textBox9.Text = row.Cells["RentalID"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("BookingID"))
                textBox6.Text = row.Cells["BookingID"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("CustomerName"))
                textBox5.Text = row.Cells["CustomerName"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("VehicleMakeModel"))
                textBox2.Text = row.Cells["VehicleMakeModel"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("VehicleVinNo"))
                textBox1.Text = row.Cells["VehicleVinNo"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("Odometer"))
                textBox8.Text = row.Cells["Odometer"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("RentalStatus"))
                textBox4.Text = row.Cells["RentalStatus"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("EmployeeID"))
                textBox7.Text = row.Cells["EmployeeID"].Value?.ToString() ?? "";
            if (RentalGridView.Columns.Contains("EmployeeName"))
                textBox3.Text = row.Cells["EmployeeName"].Value?.ToString() ?? "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
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

                string query = @"INSERT INTO [RENTAL]
([BookingID], [CustomerID], [CustomerName], [VehicleVinNo], [EmployeeID],
 [EmployeeName], [PickupDate], [StartDate], [ExpectedReturnDate],
 [RentalStatus], [DepositAmount], [VehicleMakeModel])
VALUES
(@BookingID, @CustomerID, @CustomerName, @VehicleVinNo, @EmployeeID,
 @EmployeeName, @PickupDate, @StartDate, @ExpectedReturnDate,
 @RentalStatus, @DepositAmount, @VehicleMakeModel);";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // BookingID
                    int bookingId;
                    if (int.TryParse(textBox6.Text, out bookingId))
                        cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    else
                        cmd.Parameters.AddWithValue("@BookingID", DBNull.Value);

                    // CustomerID - no explicit control identified; try parse textBox? otherwise DBNull
                    int customerId;
                    if (int.TryParse(textBox9.Text, out customerId))
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    else
                        cmd.Parameters.AddWithValue("@CustomerID", DBNull.Value);

                    // CustomerName
                    cmd.Parameters.AddWithValue("@CustomerName", (object)textBox5.Text ?? DBNull.Value);

                    // VehicleVinNo
                    cmd.Parameters.AddWithValue("@VehicleVinNo", (object)textBox1.Text ?? DBNull.Value);

                    // EmployeeID
                    int employeeId;
                    if (int.TryParse(textBox8.Text, out employeeId))
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    else
                        cmd.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

                    // EmployeeName
                    cmd.Parameters.AddWithValue("@EmployeeName", (object)textBox2.Text ?? DBNull.Value);

                    // PickupDate and StartDate (combined date + time)
                    DateTime pickupDateTime = dateTimePicker1.Value.Date + dateTimePicker4.Value.TimeOfDay;
                    cmd.Parameters.AddWithValue("@PickupDate", pickupDateTime);
                    cmd.Parameters.AddWithValue("@StartDate", pickupDateTime);

                    // ExpectedReturnDate (combined)
                    DateTime returnDateTime = dateTimePicker2.Value.Date + dateTimePicker3.Value.TimeOfDay;
                    cmd.Parameters.AddWithValue("@ExpectedReturnDate", returnDateTime);

                    // RentalStatus
                    cmd.Parameters.AddWithValue("@RentalStatus", (object)textBox4.Text ?? DBNull.Value);

                   
                    // VehicleMakeModel
                    cmd.Parameters.AddWithValue("@VehicleMakeModel", (object)textBox2.Text ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid
                    rENTALTableAdapter.Fill(avisDS.RENTAL);
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
            // dateTimePicker1.Value = Convert.ToDateTime(RentalGridView.CurrentRow.Cells[6].Value);
            // dateTimePicker4.Value = Convert.ToDateTime(RentalGridView.CurrentRow.Cells[6].Value);
            //  dateTimePicker2.Value = Convert.ToDateTime(RentalGridView.CurrentRow.Cells[8].Value);
            // dateTimePicker3.Value = Convert.ToDateTime(RentalGridView.CurrentRow.Cells[8].Value);

        }
    }
}







