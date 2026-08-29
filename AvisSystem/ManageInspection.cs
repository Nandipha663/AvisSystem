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
    public partial class ManageInspection : Form
    {
        public ManageInspection()
        {
            InitializeComponent();
            this.textBox1.Enter += new EventHandler(textBox1_Enter);
            this.textBox1.Leave += new EventHandler(textBox1_Leave);
            this.textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text != "🔍 Search using employee name...")
                {
                    vehicle_InspectionTableAdapter.FillByName(avisDS.Vehicle_Inspection, textBox1.Text);
                }
                else
                {
                    // If search box is empty, show all records
                    this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.Show();
            this.Hide();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomersForm = new ManageCustomers();
            manageCustomersForm.Show();
            this.Hide();
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation addBookingForm = new AddBookingReservation();
            addBookingForm.Show();
            this.Hide();
        }

        private void viewUpdateBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation updateReservationForm = new UpdateReservation();
            updateReservationForm.Show();
            this.Hide();
        }

        private void addNewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addRentalForm = new AddRental();
            addRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental updateRentalForm = new UpdateRental();
            updateRentalForm.Show();
            this.Hide();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();
            addVehicleForm.Show();
            this.Hide();
        }

        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVehiclesForm = new UpdateVehicles();
            updateVehiclesForm.Show();
            this.Hide();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void adNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim addClaimForm = new AddClaim();
            addClaimForm.Show();
            this.Hide();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim updateClaimForm = new UpdateClaim();
            updateClaimForm.Show();
            this.Hide();
        }

        private void viewBranchesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployeeForm = new ManageEmployee();
            manageEmployeeForm.Show();
            this.Hide();
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalForm = new AddRentalRental();
            addRentalForm.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalForm = new UpdateRentalRental();
            updateRentalForm.Show();
            this.Hide();
        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection addInspectionForm = new AddInspection();
            addInspectionForm.Show();
            this.Hide();
        }

        private void ManageInspection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.Vehicle_Inspection' table. You can move, or remove it, as needed.
            this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

            try
            {  // Initialize filter controls
                comboBox1.Items.Clear();
                comboBox1.Items.Add("InspectionType");
                comboBox1.Items.Add("InspectionDateTime");
                comboBox1.SelectedIndex = -1;

                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;

                // Set placeholder for textbox
                textBox1.Text = "🔍 Search using employee name...";
                textBox1.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please select a filter category first.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string filterExpression = "";

                if (comboBox1.Text == "InspectionType")
                {
                    if (string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        MessageBox.Show("Please select an inspection type.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Use proper string escaping for SQL-like filter
                    filterExpression = $"InspectionType = '{comboBox2.Text.Replace("'", "''")}'";
                }
                else if (comboBox1.Text == "InspectionDateTime")
                {
                    DateTime selectedDate = dateTimePicker1.Value.Date;

                    // Filter for the specific date using proper date format
                    filterExpression = $"InspectionDateTime >= #{selectedDate:yyyy-MM-dd}# AND InspectionDateTime < #{selectedDate.AddDays(1):yyyy-MM-dd}#";
                }
                else
                {
                    MessageBox.Show("Please select a valid filter category.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Apply filter
                vehicleInspectionBindingSource.Filter = filterExpression;

                MessageBox.Show("Filter applied successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                vehicleInspectionBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Value = DateTime.Now;

                // Refresh data to show all records
                this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

                MessageBox.Show("Filters reset successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting filters: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear search textbox
                textBox1.Text = "🔍 Search using employee name...";
                textBox1.ForeColor = Color.Gray;

                // Reset filters
                vehicleInspectionBindingSource.RemoveFilter();
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Value = DateTime.Now;

                // Refresh data
                this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

                // Clear selection in DataGridView
                dataGridView1.ClearSelection();

                MessageBox.Show("Search cleared and filters reset.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing search: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get the inspection code from the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int inspectionCode = Convert.ToInt32(selectedRow.Cells["inspectionCodeDataGridViewTextBoxColumn"].Value);

                // Confirm deletion
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to permanently delete inspection record: {inspectionCode}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Delete the record
                    this.vehicle_InspectionTableAdapter.DeleteQuery(inspectionCode);

                    // Refresh the data
                    this.vehicle_InspectionTableAdapter.Fill(this.avisDS.Vehicle_Inspection);

                    // Clear the selected row highlight
                    dataGridView1.ClearSelection();

                    MessageBox.Show($"Inspection record {inspectionCode} deleted successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "🔍 Search using employee name...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search using employee name...";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Clear and reset comboBox2
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;

                // Reset dateTimePicker
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Value = DateTime.Now;

                // Check if an item is selected
                if (comboBox1.SelectedItem != null)
                {
                    string selectedFilter = comboBox1.SelectedItem.ToString();

                    if (selectedFilter == "InspectionType")
                    {
                        comboBox2.Enabled = true;
                        comboBox2.Items.Add("Pickup");
                        comboBox2.Items.Add("Return");
                        comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    else if (selectedFilter == "InspectionDateTime")
                    {
                        dateTimePicker1.Enabled = true;
                        dateTimePicker1.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating filter options: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}






