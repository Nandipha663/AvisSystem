using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace AvisSystem
{
    public partial class UpdateClaim : Form
    {

        public UpdateClaim()
        {
            InitializeComponent();
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search for a claim...";
            textBox1.ForeColor = Color.Gray;

            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;
            DataTable bottomTable = (DataTable)dataGridView2.DataSource;
            bottomTable.Clear();
        }

        private void UpdateClaim_Load(object sender, EventArgs e)
        {
            viewUpdateClaimsToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;

            this.claimTableAdapter1.Fill(this.avisDS.CLAIM);
            dataGridView1.DataSource = cLAIMBindingSource1;
            dataGridView1.Refresh();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("ClaimStatus");
            comboBox1.Items.Add("ClaimDate");
            comboBox1.SelectedIndex = -1;

            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;

            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            dataGridView1.ClearSelection();
            DataTable emptyClaimTable = this.avisDS.CLAIM.Clone();
            dataGridView2.DataSource = emptyClaimTable;

        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                return;
            }
            comboBox2.Enabled = true;
            PopulateValueComboForFilter();
        }
        private void PopulateValueComboForFilter()
        {
            comboBox2.Items.Clear();
            comboBox2.Text = string.Empty;

            if (this.avisDS.CLAIM.Rows.Count == 0)
            {
                this.claimTableAdapter1.Fill(this.avisDS.CLAIM);
            }
            string selected = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
                return;

            if (selected.Equals("ClaimStatus", StringComparison.OrdinalIgnoreCase))
            {
                var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (DataRow r in avisDS.CLAIM.Rows)
                {
                    var val = r["ClaimStatus"];
                    if (val != DBNull.Value)
                    {
                        string s = val.ToString().Trim();
                        if (!string.IsNullOrEmpty(s)) set.Add(s);
                    }
                }
                var ordered = set.OrderBy(x => x).ToArray();
                if (ordered.Length > 0)
                {
                    comboBox2.Items.AddRange(ordered);
                    comboBox2.SelectedIndex = -1;
                }
            }
            else if (selected.Equals("ClaimDate", StringComparison.OrdinalIgnoreCase))
            {
                var set = new HashSet<DateTime>();
                foreach (DataRow r in avisDS.CLAIM.Rows)
                {
                    var val = r["ClaimDate"];
                    if (val != DBNull.Value)
                    {
                        DateTime dt;
                        if (DateTime.TryParse(val.ToString(), out dt))
                        {
                            set.Add(dt.Date);
                        }
                    }
                }
                var ordered = set.OrderByDescending(d => d).Select(d => d.ToString("yyyy-MM-dd")).ToArray();
                if (ordered.Length > 0)
                {
                    comboBox2.Items.AddRange(ordered);
                    comboBox2.SelectedIndex = -1;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            claimTableAdapter1.FillByClaimType(this.avisDS.CLAIM, textBox1.Text);
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text != "🔍 Search for a claim...")
            {
                try
                {
                    string txt = textBox1.Text.Replace("'", "''");
                    this.cLAIMBindingSource1.Filter = $"ClaimType LIKE '%{txt}%'";
                }
                catch
                {
                    this.cLAIMBindingSource1.Filter = null;
                    this.claimTableAdapter1.Fill(this.avisDS.CLAIM);
                }
            }
            else
            {
                this.cLAIMBindingSource.Filter = null;
                this.claimTableAdapter1.Fill(this.avisDS.CLAIM);
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "🔍 Search for a claim...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search for a claim...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }
        private void addNewClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            newAddClaim.Show();
            this.Hide();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            newAddBranch.Show();
            this.Hide();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            newAddCustomer.Show();
            this.Hide();
        }

        private void viewUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            newManageCustomers.Show();
            this.Hide();
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            newUpdatePayment.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "ClaimStatus")
                {
                    if (string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a claim status first.");
                        return;
                    }

                    cLAIMBindingSource1.Filter =
                        $"ClaimStatus = '{comboBox2.Text}'";
                }
                else if (comboBox1.Text == "ClaimDate")
                {
                    if (dateTimePicker1.CustomFormat == " ")
                    {
                        MessageBox.Show("Please select a date first.");
                        return;
                    }

                    DateTime date = dateTimePicker1.Value.Date;

                    cLAIMBindingSource1.Filter =
                        $"ClaimDate >= #{date:yyyy-MM-dd}# AND ClaimDate < #{date.AddDays(1):yyyy-MM-dd}#";
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



        private void button1_Click(object sender, EventArgs e)
        {
            // Get the ClaimID from the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int claimID = Convert.ToInt32(selectedRow.Cells[0].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to permanently delete Claim ID: {claimID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.claimTableAdapter1.DeleteQuery(claimID);

                    this.claimTableAdapter1.Fill(this.avisDS.CLAIM);

                    // Clear the selected row highlight
                    dataGridView1.ClearSelection();

                    // Clear any data in the bottom grid
                    DataTable bottomTable = (DataTable)dataGridView2.DataSource;
                    if (bottomTable != null)
                    {
                        bottomTable.Clear();
                    }

                    MessageBox.Show($"Claim record {claimID} deleted successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the record:\n{ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.EndEdit();

                DataTable bottomTable = (DataTable)dataGridView2.DataSource;

                if (bottomTable == null || bottomTable.Rows.Count == 0)
                {
                    MessageBox.Show("There must be a claim selected to be edited before updating.",
                                    "No Claims Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataRow editedRow in bottomTable.Rows)
                {
                    int claimID = Convert.ToInt32(editedRow["ClaimID"]);

                    AvisDS.CLAIMRow originalRow = avisDS.CLAIM.FindByClaimID(claimID);

                    if (originalRow != null)
                    {
                        originalRow.ClaimDescription = editedRow["ClaimDescription"].ToString();
                        originalRow.ClaimDate = Convert.ToDateTime(editedRow["ClaimDate"]);
                        originalRow.ClaimType = editedRow["ClaimType"].ToString();
                        originalRow.ClaimStatus = editedRow["ClaimStatus"].ToString();
                        originalRow.LastUpdated = Convert.ToDateTime(editedRow["LastUpdated"]);
                    }
                }
                this.claimTableAdapter1.Update(this.avisDS.CLAIM);

                MessageBox.Show("Claims are successfully updated!",
                                "", MessageBoxButtons.OK);

                bottomTable.Rows.Clear();

                this.claimTableAdapter1.Fill(this.avisDS.CLAIM);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the claims: {ex.Message}"
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                cLAIMBindingSource.RemoveFilter();

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (textBox1.Text == "🔍 Search for a claim..." || textBox1.Text != "🔍 Search for a claim...")
            {
                if (e.RowIndex < 0) return;

                try
                {
                    DataRowView selectedRowView = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    AvisDS.CLAIMRow selectedClaim = (AvisDS.CLAIMRow)selectedRowView.Row;

                    DataTable bottomTable = (DataTable)dataGridView2.DataSource;

                    foreach (DataRow row in bottomTable.Rows)
                    {
                        if (Convert.ToInt32(row["ClaimID"]) == selectedClaim.ClaimID)
                        {
                            MessageBox.Show($"Claim ID {selectedClaim.ClaimID} has already been added to the update list below.",
                                            " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    bottomTable.ImportRow(selectedClaim);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the claim to the updated list: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                string claimStatus = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox2.Text = claimStatus;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "ClaimStatus")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("Approved");
                comboBox2.Items.Add("Rejected");
            }
            else if (comboBox1.Text == "ClaimDate")
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}



