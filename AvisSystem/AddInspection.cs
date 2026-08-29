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
        private string selectedInspectionType = "";
        private int selectedRentalID = 0;
        private string selectedVehicleMakeModel = "";

        public AddInspection()
        {
            InitializeComponent();
            // Add these lines
            this.vehicle_InspectionTableAdapter= new AvisDSTableAdapters.Vehicle_InspectionTableAdapter();
            this.eMPLOYEETableAdapter = new AvisDSTableAdapters.EMPLOYEETableAdapter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
                //  groupBox2.Visible = false;

                selectedInspectionType = "Pickup";

                // Clear Return Inspection fields when switching
                ClearGroupBox2Fields();
            }
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                //   groupBox3.Visible = false;

                selectedInspectionType = "Return";

                // Clear Pickup Inspection fields when switching
                ClearGroupBox3Fields();
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
            // TODO: This line of code loads data into the 'avisDS.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.avisDS.RENTAL);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

            // Attach SelectionChanged event to DataGridView (instead of DoubleClick)
            this.dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that an inspection type is selected
                if (string.IsNullOrEmpty(selectedInspectionType))
                {
                    MessageBox.Show("Please select an inspection type (Pickup or Return).",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate and save based on inspection type
                if (selectedInspectionType == "Pickup")
                {
                    SavePickupInspection();
                }
                else if (selectedInspectionType == "Return")
                {
                    SaveReturnInspection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving inspection: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePickupInspection()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("Please enter Employee Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox12.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                MessageBox.Show("Please enter Branch Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox11.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Please enter Vehicle Information.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox10.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || maskedTextBox1.Text == "   km/h")
            {
                MessageBox.Show("Please enter Odometer Reading.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                return;
            }

            // Parse odometer reading
            string odometerText = maskedTextBox1.Text.Replace("km/h", "").Trim();
            if (!int.TryParse(odometerText, out int odometerReading))
            {
                MessageBox.Show("Please enter a valid Odometer Reading (numbers only).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                return;
            }


            // Fuel Level - accept text/words (no validation needed since it's nvarchar)
            string fuelLevel = string.IsNullOrWhiteSpace(textBox14.Text) ? "Empty" : textBox14.Text;

            // Get damage found
            string damageFound = string.IsNullOrWhiteSpace(textBox15.Text) ? "No" : "Yes";

            // Get employee ID from the EMPLOYEE table
            int employeeID = GetEmployeeID(textBox12.Text);
            if (employeeID == 0)
            {
                MessageBox.Show("Employee not found. Please enter a valid employee name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox12.Focus();
                return;
            }

            // Insert the inspection record
            try
            {
                // Call the Insert method from the Vehicle_InspectionTableAdapter
                this.vehicle_InspectionTableAdapter.Insert(
                    employeeID,                    // EmployeeID
                    0,                             // RentalID (0 for pickup inspection)
                    (decimal)odometerReading,      // OdometerReading
                    "Pickup",                      // InspectionType
                    dateTimePicker2.Value,         // InspectionDateTime
                    fuelLevel.ToString(),          // FuelLevel (as string)
                    damageFound,                   // DamageFound
                    textBox16.Text,                // DamageDescription
                    textBox9.Text,                 // InspectionNotes
                    textBox11.Text,                // BranchName
                    textBox12.Text,                // EmployeeName
                    textBox10.Text                 // VehicleMakeModel
                );

                MessageBox.Show("Pickup Inspection record saved successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the dataset
                this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

                ClearAllFields();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to save Pickup Inspection: {ex.Message}");
            }
        }

        private void SaveReturnInspection()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please enter Employee Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }

            if (selectedRentalID == 0)
            {
                MessageBox.Show("Please select a rental record from the grid first.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please enter Branch Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox8.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBox2.Text) || maskedTextBox2.Text == "   km/h")
            {
                MessageBox.Show("Please enter Odometer Reading.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox2.Focus();
                return;
            }

            // Parse odometer reading
            string odometerText = maskedTextBox2.Text.Replace("km/h", "").Trim();
            if (!int.TryParse(odometerText, out int odometerReading))
            {
                MessageBox.Show("Please enter a valid Odometer Reading (numbers only).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox2.Focus();
                return;
            }


            // Fuel Level - accept text/words (no validation needed since it's nvarchar)
            string fuelLevel = string.IsNullOrWhiteSpace(textBox2.Text) ? "Empty" : textBox2.Text;

            // Get damage found
            string damageFound = string.IsNullOrWhiteSpace(textBox4.Text) ? "No" : "Yes";

            // Get employee ID
            int employeeID = GetEmployeeID(textBox6.Text);
            if (employeeID == 0)
            {
                MessageBox.Show("Employee not found. Please enter a valid employee name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            // Check if VehicleMakeModel was set from selection
            if (string.IsNullOrWhiteSpace(selectedVehicleMakeModel))
            {
                MessageBox.Show("Please select a rental record first to get the vehicle information.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert the inspection record
            try
            {
                // Call the Insert method from the Vehicle_InspectionTableAdapter
                this.vehicle_InspectionTableAdapter.Insert(
                    employeeID,                    // EmployeeID
                    selectedRentalID,              // RentalID
                    (decimal)odometerReading,      // OdometerReading
                    "Return",                      // InspectionType
                    dateTimePicker1.Value,         // InspectionDateTime
                    fuelLevel.ToString(),          // FuelLevel (as string)
                    damageFound,                   // DamageFound
                    textBox1.Text,                 // DamageDescription
                    textBox5.Text,                 // InspectionNotes
                    textBox8.Text,                 // BranchName
                    textBox6.Text,                 // EmployeeName
                    selectedVehicleMakeModel       // VehicleMakeModel (from selected rental)
                );

                MessageBox.Show("Return Inspection record saved successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the dataset
                this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

                ClearAllFields();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to save Return Inspection: {ex.Message}");
            }
        }

        private int GetEmployeeID(string employeeName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(employeeName))
                    return 0;

                // Query the EMPLOYEE table to get the ID by name
                var result = this.eMPLOYEETableAdapter.GetData();

                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        string fullname = row["Fullname"]?.ToString() ?? "";
                        if (fullname.Equals(employeeName, StringComparison.OrdinalIgnoreCase))
                        {
                            return Convert.ToInt32(row["EmployeeID"]);
                        }
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding employee: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    // Search by customer name in RENTAL table
                    rENTALTableAdapter.FillByCustName(avisDS.RENTAL, textBox7.Text);
                }
                else
                {
                    rENTALTableAdapter.Fill(avisDS.RENTAL);
                }
            }
            catch (Exception ex)
            {
                // Silent fail for search
            }
        }

        // SelectionChanged event - fires when a row is selected (single click)
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Only proceed if Return Inspection is selected
                if (!radioButton2.Checked)
                    return;

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    // Get the rental ID
                    selectedRentalID = Convert.ToInt32(row.Cells["rentalIDDataGridViewTextBoxColumn"].Value);

                    // Fill the Rental ID field (readonly)
                    textBox3.Text = selectedRentalID.ToString();

                    // This will be saved to the inspection table
                    selectedVehicleMakeModel = row.Cells["vehicleMakeModelDataGridViewTextBoxColumn"]?.Value?.ToString() ?? "";


                    // Optionally auto-fill other fields from the rental record
                    // Branch Name - user can edit/type this, but we can pre-fill
                    string branchName = row.Cells["branchNameDataGridViewTextBoxColumn"]?.Value?.ToString();
                    if (!string.IsNullOrEmpty(branchName))
                    {
                        textBox8.Text = branchName;
                    }
                    else
                    {
                        // If BranchName column doesn't exist, use CustomerName or VehicleMakeModel
                        textBox8.Text = row.Cells["customerNameDataGridViewTextBoxColumn"]?.Value?.ToString() ?? "";
                    }

                    // Optionally auto-fill Employee Name if needed
                    // textBox6.Text = row.Cells["employeeNameDataGridViewTextBoxColumn"]?.Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                // Silent fail for selection - don't show error on every click
                // Only log or show if it's a critical error
            }

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
        private void ClearGroupBox3Fields()
        {
            textBox12.Clear();  // Employee Name (Pickup)
            textBox11.Clear();  // Branch Name (Pickup)
            textBox10.Clear();  // Vehicle Info (Pickup)
            maskedTextBox1.Clear(); // Odometer Reading (Pickup)
            textBox14.Clear();  // Fuel Level (Pickup)
            textBox15.Clear();  // Damage Found (Pickup)
            textBox16.Clear();  // Damage Description (Pickup)
            textBox9.Clear();   // Inspection Notes (Pickup)
            dateTimePicker2.Value = DateTime.Now;
        }

        private void ClearGroupBox2Fields()
        {
            textBox6.Clear();   // Employee Name (Return)
            textBox8.Clear();   // Branch Name (Return)
            textBox3.Clear();   // Rental ID (Return)
            maskedTextBox2.Clear(); // Odometer Reading (Return)
            textBox2.Clear();   // Fuel Level (Return)
            textBox4.Clear();   // Damage Found (Return)
            textBox1.Clear();   // Damage Description (Return)
            textBox5.Clear();   // Inspection Notes (Return)
            dateTimePicker1.Value = DateTime.Now;
            selectedRentalID = 0;
            selectedVehicleMakeModel = ""; 
        }
        private void ClearAllFields()
        {
            ClearGroupBox3Fields();
            ClearGroupBox2Fields();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            selectedInspectionType = "";
            selectedRentalID = 0;
            selectedVehicleMakeModel = ""; // 
            textBox7.Clear();
            rENTALTableAdapter.Fill(avisDS.RENTAL);
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    // Search by customer name in RENTAL table
                    rENTALTableAdapter.FillByCustName(avisDS.RENTAL, textBox7.Text);
                }
                else
                {
                    rENTALTableAdapter.Fill(avisDS.RENTAL);
                }
            }
            catch (Exception ex)
            {
                // Silent fail for search
            }
        }
    }
}
