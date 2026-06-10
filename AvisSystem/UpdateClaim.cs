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
        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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

            this.claimTableAdapter1.Fill(this.avisDS1.CLAIM);
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
            DataTable emptyClaimTable = this.avisDS1.CLAIM.Clone();
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

            if (this.avisDS1.CLAIM.Rows.Count == 0)
            {
                this.claimTableAdapter1.Fill(this.avisDS1.CLAIM);
            }
            string selected = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
                return;

            if (selected.Equals("ClaimStatus", StringComparison.OrdinalIgnoreCase))
            {
                var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (DataRow r in avisDS1.CLAIM.Rows)
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
                foreach (DataRow r in avisDS1.CLAIM.Rows)
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
            claimTableAdapter1.FillByClaimType(this.avisDS1.CLAIM, textBox1.Text);
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text != "🔍 Search for a claim...")
            {
                try
                {
                    string txt = textBox1.Text.Replace("'", "''");
                    this.cLAIMBindingSource.Filter = $"ClaimType LIKE '%{txt}%'";
                }
                catch
                {
                    this.cLAIMBindingSource.Filter = null;
                    this.claimTableAdapter1.Fill(this.avisDS1.CLAIM);
                }
            }
            else
            {
                this.cLAIMBindingSource.Filter = null;
                this.claimTableAdapter1.Fill(this.avisDS1.CLAIM);
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
            this.Hide();
            newAddClaim.Show();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            this.Hide();
            newAddBranch.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }

        private void viewUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void viewUpdateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();
        }

        private void addNewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            this.Hide();
            newAddRental.Show();
        }

        private void viewUpdateRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            this.Hide();
            newUpdateRental.Show();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            this.Hide();
            newAddVehicle.Show();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            this.Hide();
            newAddPayment.Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            this.Hide();
            newUpdatePayment.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> filterList = new List<string>();

                if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text != "🔍 Search for a claim...")
                {
                    string searchText = textBox1.Text.Replace("'", "''");
                    filterList.Add($"ClaimType LIKE '%{searchText}%'");
                }

                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    string columnName = comboBox1.SelectedItem.ToString().Trim();
                    string selectedValue = comboBox2.SelectedItem.ToString().Replace("'", "''");

                    if (columnName == "ClaimDate")
                    {
                        if (DateTime.TryParse(selectedValue, out DateTime parsedDate))
                        {
                            filterList.Add($"[{columnName}] = #{parsedDate:MM/dd/yyyy}#");
                        }
                        else
                        {
                            filterList.Add($"[{columnName}] = '{selectedValue}'");
                        }
                    }
                    else
                    {
                        filterList.Add($"[{columnName}] = '{selectedValue}'");
                    }
                }
                if (filterList.Count > 0)
                {
                    this.cLAIMBindingSource.Filter = string.Join(" AND ", filterList);
                }
                else
                {
                    this.cLAIMBindingSource.RemoveFilter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                object cellValue = dataGridView1.CurrentRow.Cells[5].Value;
                if (cellValue != DBNull.Value && cellValue != null)
                {
                    textBox2.Text = cellValue.ToString();
                }
                else
                {
                    textBox2.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to permanently delete the selected claim record?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    cLAIMBindingSource.RemoveCurrent();
                    this.claimTableAdapter1.Update(this.avisDS1.CLAIM);
                }
                catch
                {
                    MessageBox.Show("An error occurred while deleting the record: ", "",
                                     MessageBoxButtons.OK);
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

                    AvisDS.CLAIMRow originalRow = avisDS1.CLAIM.FindByClaimID(claimID);

                    if (originalRow != null)
                    {
                        originalRow.ClaimDescription = editedRow["ClaimDescription"].ToString();
                        originalRow.ClaimDate = Convert.ToDateTime(editedRow["ClaimDate"]);
                        originalRow.ClaimType = editedRow["ClaimType"].ToString();
                        originalRow.ClaimStatus = editedRow["ClaimStatus"].ToString();
                        originalRow.ResponsibleParty = editedRow["ResponsibleParty"].ToString();
                    }
                }
                this.claimTableAdapter1.Update(this.avisDS1.CLAIM);

                MessageBox.Show("Claims are successfully updated!",
                                "", MessageBoxButtons.OK);

                bottomTable.Rows.Clear();

                this.claimTableAdapter1.Fill(this.avisDS1.CLAIM);
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
   
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string claimStatus = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = claimStatus;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
                MessageBox.Show($"An error occurred while adding the claim to the update list: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}



