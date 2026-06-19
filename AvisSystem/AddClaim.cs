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
    public partial class AddClaim : Form
    {
        // Guard flag to prevent event triggers during a systematic form reset
        private bool isFormLoading = true;

        public AddClaim()
        {
            InitializeComponent();
            label8.Click += panel1_Click;
            label9.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;

            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            textBox5.TextChanged += textBox5_TextChanged;

        }

        private void manageBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            newAddReservation.Show();
            this.Hide();
        }

        private void viewUpdateBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            newUpdateReservation.Show();
            this.Hide();
        }

        private void addNewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            newAddRental.Show();
            this.Hide();
        }

        private void viewUpdateRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            newUpdateRental.Show();
            this.Hide();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            newAddVehicle.Show();
            this.Hide();
        }

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            newUpdateVehicles.Show();
            this.Hide();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            newAddPayment.Show();
            this.Hide();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            newUpdatePayment.Show();
            this.Hide();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewUpdateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            newUpdateClaim.Show();
            this.Hide();
        }

        private void AddClaim_Load(object sender, EventArgs e)
        {
            isFormLoading = true;

            // Load master claims reference collection from the database
            this.cLAIMTableAdapter.Fill(this.avisDS.CLAIM);

            // Populate your DataGridView using the updated joined VEHICLE_RETURN main query
            this.vEHICLE_RETURNTableAdapter.Fill(this.avisDS.VEHICLE_RETURN);

            // Establish standard menu item navigation states
            addNewClaimToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.Items.Add(""); // Add an empty option at index 0
            comboBox1.Items.Add("Tyre & Rim Damage");
            comboBox1.Items.Add("Bodywork");
            comboBox1.Items.Add("Windscreen & Glass");
            comboBox1.Items.Add("Theft & Hijacking");
            comboBox1.Items.Add("Collision");

            comboBox1.SelectedIndex = -1;

            // Initialize claim status choice dropdown states
            var statuses = this.avisDS.CLAIM
                               .AsEnumerable()
                               .Select(row => row["ClaimStatus"].ToString())
                               .Distinct()
                               .ToList();

            if (!statuses.Contains("Open"))
            {
                statuses.Insert(0, "Open");
            }

            comboBox2.DataSource = null;
            comboBox2.DataSource = statuses;

            // FIX: Setting SelectedIndex to -1 forces a DataSource ComboBox to be empty on load
            comboBox2.SelectedIndex = -1;

            isFormLoading = false;
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         ClearForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                MessageBox.Show("Please select an existing return record from the grid first.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please specify an active Claim Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = Convert.ToInt32(textBox4.Text.Trim());
            string claimStatus = comboBox2.SelectedItem.ToString();
            string claimType = comboBox1.SelectedItem.ToString();

            try
            {
                int nextClaimID = GetNextCLAIMID();
                string claimDescription = textBox1.Text.Trim();
                DateTime claimDate = dateTimePicker1.Value;

                this.cLAIMTableAdapter.Fill(this.avisDS.CLAIM);

                AvisDS.CLAIMRow newRow = this.avisDS.CLAIM.NewCLAIMRow();

                newRow.BookingID = bookingID;
                newRow.ClaimStatus = claimStatus;
                newRow.ClaimDescription = claimDescription;
                newRow.ClaimType = claimType;
                newRow.ClaimDate = claimDate;
                newRow.LastUpdated = DateTime.Now;


                this.avisDS.CLAIM.AddCLAIMRow(newRow);
                this.cLAIMTableAdapter.Update(this.avisDS.CLAIM);

                MessageBox.Show("Claim filed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while executing database update operations:\n" + ex.Message,
                                "SQL Write Fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            isFormLoading = true;
            // Clear standard input text boxes
            textBox1.Clear();
            textBox5.Clear();

            // Clear tracking variables and auto-populated read-only outputs
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox3.Clear();
            textBox8.Clear();

            dateTimePicker1.Value = DateTime.Today;

            // Refresh the main vehicle return table view dataset
            this.vEHICLE_RETURNTableAdapter.Fill(this.avisDS.VEHICLE_RETURN);

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            // Reset data-bound Claim Statuses ComboBox back to completely empty
            comboBox2.SelectedIndex = -1;
            dataGridView1.ClearSelection();

            isFormLoading = false;
        }
        private int GetNextCLAIMID()
        {
            if (this.avisDS.CLAIM.Rows.Count == 0)
                return 1;

            // Find the maximum ClaimID and add 1
            int maxId = this.avisDS.CLAIM
                .AsEnumerable()
                .Select(row => row.Field<int>("ClaimID"))
                .DefaultIfEmpty(0)
                .Max();

            return maxId + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            manageEmp.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;

            string searchString = textBox5.Text.Trim();

            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    // NOW WORKS PERFECTLY: Call the search query on your main VEHICLE RETURN adapter
                    this.vEHICLE_RETURNTableAdapter.FillByCustName(this.avisDS.VEHICLE_RETURN, searchString);
                }
                else
                {
                    // Fall back to complete catalog load if the search box is cleared out
                    this.vEHICLE_RETURNTableAdapter.Fill(this.avisDS.VEHICLE_RETURN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Search Error: " + ex.Message, "Warning Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0) // Prevents error crashes if header rows are clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Map your columns safely from the grid layout into your form text boxes
                if (row.Cells[1].Value != DBNull.Value)
                    textBox4.Text = row.Cells[1].Value.ToString();

                if (row.Cells[0].Value != DBNull.Value)
                    textBox3.Text = row.Cells[0].Value.ToString();

                if (row.Cells[2].Value != DBNull.Value)
                    textBox2.Text = row.Cells[2].Value.ToString();

                if (row.Cells[4].Value != DBNull.Value)
                    textBox7.Text = row.Cells[4].Value.ToString();

                if (row.Cells[5].Value != DBNull.Value)
                    textBox6.Text = row.Cells[5].Value.ToString();

                if (row.Cells[9].Value != DBNull.Value)
                    textBox8.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
