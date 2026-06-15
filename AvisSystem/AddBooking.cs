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
    public partial class AddBookingReservation : Form
    {

        // Add this flag at the class level
        private bool isFormLoading = true;

        public AddBookingReservation()
        {
            InitializeComponent();
            label9.Click += panel1_Click;
            label11.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isFormLoading = true;  // Prevent events during clearing

            textBox9.Clear();
            textBox10.Clear();
            textBox1.Clear();
            //textBox5.Clear();

            // Use -1 instead of 0 to clear selection
            comboBox1.SelectedIndex = -1;
            //comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            // Reset date pickers
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;

            // Reset vehicle filter
            this.vEHICLEBindingSource.Filter = "1 = 0";

            isFormLoading = false;
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            // Set flag to true when loading starts
            isFormLoading = true;

            // TODO: This line of code loads data into the 'avisDS.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.avisDS.BRANCH);
            // TODO: This line of code loads data into the 'avisDS.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.avisDS.VEHICLE);
            // TODO: This line of code loads data into the 'avisDS.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.avisDS.CUSTOMER);
            fileToolStripMenuItem.Enabled = true;
            addBookingToolStripMenuItem2.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;


            // Step 1: Configure comboboxes (this calls your ConfigureBranchComboBoxes method)
            ConfigureBranchComboBoxes();

            // Step 2: Initially show NO vehicles until a branch is selected
            this.vEHICLEBindingSource.Filter = "1 = 0";

            // Make CustomerID textbox read-only
            textBox10.ReadOnly = true;

            // Set flag to false when loading is complete
            isFormLoading = false;

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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();


        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AddVehicle newAddVehicle = new AddVehicle();
                this.Hide();
                newAddVehicle.Show();
        }

        private void viewUpdateVehicleStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cUSTOMERTableAdapter.FillByFullName(avisDS.CUSTOMER, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //vEHICLETableAdapter.FillByMake(avisDS.VEHICLE,textBox5.Text);
            // Don't search while form is loading
            if (isFormLoading) return;

            // Only search if a pickup branch is selected
            if (comboBox4.SelectedIndex == -1 || comboBox4.SelectedValue == null)
            {
                return;
            }

            string selectedBranchName = comboBox4.Text;

            // Validate branch name
            if (string.IsNullOrEmpty(selectedBranchName) || selectedBranchName == "System.Data.DataRowView")
            {
                return;
            }

            /*string searchTerm = textBox5.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // No search term - show all available vehicles at the branch
                this.vEHICLEBindingSource.Filter = $"BranchName = '{selectedBranchName}' AND Status = 'Available'";
            }
            else
            {
                // Search within the branch's available vehicles by Make or Model
                this.vEHICLEBindingSource.Filter = $"BranchName = '{selectedBranchName}' AND Status = 'Available' AND (Make LIKE '%{searchTerm}%' OR Model LIKE '%{searchTerm}%')";
            }*/
        }

private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                // Validate branch selection
                if (comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a pickup branch first.", "No Branch Selected",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validate vehicle status
                string vehicleStatus = dataGridView2.CurrentRow.Cells[6].Value?.ToString() ?? "";
                if (vehicleStatus != "Available")
                {
                    MessageBox.Show($"This vehicle is {vehicleStatus}. Only available vehicles can be selected.",
                                   "Vehicle Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else
                {
                    textBox9.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    textBox9.BackColor = Color.LightGreen;
                }

                    // Get dates
                    DateTime pickupDate = dateTimePicker2.Value.Date;  // Use .Date to ignore time
                DateTime returnDate = dateTimePicker3.Value.Date;  // Use .Date to ignore time

                // Validate dates
                if (pickupDate > returnDate)
                {
                    MessageBox.Show("Return date cannot be before pickup date.", "Invalid Dates",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate days
                int numberOfDays = (returnDate - pickupDate).Days;

                // Same day = 1 day
                if (numberOfDays == 0)
                {
                    numberOfDays = 1;
                }

                // Get daily rate (make sure column index is correct)
                decimal dailyRate = 0;
                if (dataGridView2.CurrentRow.Cells[8].Value != null &&
                    dataGridView2.CurrentRow.Cells[8].Value != DBNull.Value)
                {
                    dailyRate = Convert.ToDecimal(dataGridView2.CurrentRow.Cells[8].Value);
                }
                else
                {
                    // Fallback rate if cell is empty
                    dailyRate = 500.00m;
                }

                // Calculate total
                decimal totalPrice = dailyRate * numberOfDays;

                // Display results
                textBox3.Text = totalPrice.ToString("N2");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // GET EMPLOYEE DETAILS FROM SESSION
            int employeeID = UserSession.EmployeeID;
            string employeeName = UserSession.FullName;
            string employeePosition = UserSession.Position;

            // Check if user is logged in
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to create a booking.",
                               "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // bookingTableAdapter1.InsertBooking(Convert.ToInt32(textBox10.Text), textBox9.Text.ToString(),dateTimePicker1.Value,dateTimePicker2.Value,dateTimePicker3.Value,employeeName, employeePosition,comboBox4.Text.ToString(),comboBox3.Text.ToString(),comboBox1.Text.ToString(),Convert.ToDecimal(textBox3.Text),employeeID);

            bookingTableAdapter1.InsertBooking(
    Convert.ToInt32(textBox10.Text),     // CustomerID
    textBox9.Text,                       // VehicleVinNo (no ToString needed)
    dateTimePicker1.Value,               // Booking Date
    dateTimePicker2.Value,               // PickUp Date
    dateTimePicker3.Value,               // Return Date
    employeeName,                        // CreatedByEmployeeName
    employeePosition,                    // CreatedByPosition
    comboBox4.Text,                      // PickUp Branch (no ToString needed)
    comboBox3.Text,                      // DropOff Branch (no ToString needed)
    comboBox1.Text,                      // BranchID (FIXED)
    Convert.ToDecimal(textBox3.Text),    // TotalAmount
    employeeID                           // CreatedByEmployeeID
);

            string vehicleVin = textBox9.Text; // Get the selected vehicle VIN
            // Find the Vehicle form and set the pending highlight
            foreach (Form form in Application.OpenForms)
            {
                if (form is UpdateVehicles vehicleForm)
                {
                    vehicleForm.SetPendingHighlight(vehicleVin);
                    break;
                }
            }

            // Update vehicle status to Unavailable
           
            vEHICLETableAdapter.UpdateStatus(vehicleVin);

            MessageBox.Show("Booking Added Successfully");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }






        // Add this method to configure branch comboboxes with filtering
        private void ConfigureBranchComboBoxes()
        {

            // Temporarily remove data source to prevent auto-selection
            comboBox4.DataSource = null;
            comboBox3.DataSource = null;
            comboBox1.DataSource = null;

            // Create filtered views for pickup branches (only where pickUpAvailable = 'Yes')
            DataView pickupBranchesView = new DataView(this.avisDS.BRANCH);
            pickupBranchesView.RowFilter = "pickUpAvailable = 'Yes'";

            // Create filtered views for dropoff branches (only where dropOffAvailable = 'Yes')
            DataView dropoffBranchesView = new DataView(this.avisDS.BRANCH);
            dropoffBranchesView.RowFilter = "dropOffAvailable = 'Yes'";

            // Main BranchID combobox - all branches
            comboBox1.DataSource = this.avisDS.BRANCH;
            comboBox1.DisplayMember = "branchName";
            comboBox1.ValueMember = "BranchID";
            comboBox1.SelectedIndex = -1;

            // PickUp Branch combobox - ONLY branches that allow pickup
            comboBox4.DataSource = pickupBranchesView;
            comboBox4.DisplayMember = "branchName";
            comboBox4.ValueMember = "BranchID";
            comboBox4.SelectedIndex = -1;

            // DropOff Branch combobox - ONLY branches that allow dropoff
            comboBox3.DataSource = dropoffBranchesView;
            comboBox3.DisplayMember = "branchName";
            comboBox3.ValueMember = "BranchID";
            comboBox3.SelectedIndex = -1;
        }

        // Add this method to filter vehicles by selected branch
        private void FilterVehiclesBySelectedBranch()
        {
            // Skip if form is still loading
            if (isFormLoading) return;

            // Check if a branch is selected in comboBox4
            if (comboBox4.SelectedIndex != -1 && comboBox4.SelectedValue != null)
            {
                // Get the selected branch name safely
                string selectedBranchName = comboBox4.Text;

                // Verify we got a valid branch name (not DataRowView)
                if (string.IsNullOrEmpty(selectedBranchName) || selectedBranchName == "System.Data.DataRowView")
                {
                    return;
                }

                // Filter vehicles by branch name and availability
                this.vEHICLEBindingSource.Filter = $"BranchName = '{selectedBranchName}' AND Status = 'Available'";

                textBox9.Clear();

                if (this.vEHICLEBindingSource.Count == 0)
                {
                    MessageBox.Show($"No available vehicles at '{selectedBranchName}'.\nPlease select another branch.",
                                   "No Vehicles Available",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
            }
            else
            {
                this.vEHICLEBindingSource.Filter = "1 = 0";
            }
        }

        // Add this to clear filters when resetting the form
        private void ClearVehicleFilters()
        {
            this.vEHICLEBindingSource.Filter = null;
            //textBox5.Clear();
            textBox9.Clear();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Skip event handling while the form is loading
            if (isFormLoading) return;

            // Skip if no item is selected or if the selected value is null
            if (comboBox4.SelectedIndex == -1 || comboBox4.SelectedValue == null) return;

            // Filter vehicles based on selected pickup branch
            FilterVehiclesBySelectedBranch();

            // Clear the vehicle search box when branch changes
            //textBox5.Clear();
        }
    }
}
