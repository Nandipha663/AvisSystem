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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void adNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            newAddClaim.Show();
            this.Hide();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            newAddVehicle.Show();
            this.Hide();
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

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            newAddCustomer.Show();
            this.Hide();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();;
            newAddCustomer.Show();
            this.Hide();
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

        private void viToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            newUpdateClaim.Show();
            this.Hide();
        }

        private void viewBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void signUpNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "🔍 Search Employee...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search Employee...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        public void LoadEmployees()
        {
            eMPLOYEETableAdapter.Fill(avisDS.EMPLOYEE);
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = eMPLOYEEBindingSource;

            LoadEmployees();

            // TODO: This line of code loads data into the 'avisDS.EMPLOYEE' table. You can move, or remove it, as needed.
            //this.eMPLOYEETableAdapter.Fill(this.avisDS.EMPLOYEE);
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            viewUpdateEmployeeToolStripMenuItem.Enabled = false;
        }

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                                  "Are you sure you want to delete this customer?",
                                  "Confirm Delete",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question
                                  );

            if (result == DialogResult.Yes)
            {
                int employee = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                eMPLOYEETableAdapter.DeleteEmployee(employee);

                MessageBox.Show("Customer deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                eMPLOYEETableAdapter.Fill(avisDS.EMPLOYEE);
            }
            else
            {
                MessageBox.Show("Customer deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = true;

            if (comboBox1.Text == "Status")
            {
                //load status values form employee table
                comboBox2.Items.Add("Active");
                comboBox2.Items.Add("On Leave");
                comboBox2.Items.Add("Resigned");
                comboBox2.Items.Add("Retired");
            }
            else if (comboBox1.Text == "Branch")
            {
               //load branchID from branch table
               /*for (int i = 0;i < branchIDDataGridView.Rows.Count - 1 < i++){
                    string branchIDs = branchIDDataGridView.Rows[i].Cells[0].Value.ToString();
                    comboBox2.Items.Add(branchIDs);
                }*/
            }
            else if (comboBox1.Text == "Position")
            {
                //load employee positions
                comboBox2.Items.Add("Manager");
                comboBox2.Items.Add("Consultant");
                comboBox2.Items.Add("Inventory Auditor");
                comboBox2.Items.Add("Administrator");
                comboBox2.Items.Add("Fleet Manager");
                comboBox2.Items.Add("Accountant");

            }
            else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Select filter type and value");
                return;
            }

            string column = "";
            string value = comboBox2.Text.Trim();

            if (comboBox1.Text == "Status")
                column = "EmploymentStatus";

            else if (comboBox1.Text == "Branch")
                column = "BranchID";

            else if (comboBox1.Text == "Position")
                column = "Position";

            if (column == "")
                return;

            if (column == "BranchID")
                eMPLOYEEBindingSource.Filter = $"{column} = {value}";
            else
                eMPLOYEEBindingSource.Filter = $"{column} = '{value}'";
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedEmpl = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = selectedEmpl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            eMPLOYEETableAdapter.Fill(avisDS.EMPLOYEE);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Remove filter
            eMPLOYEEBindingSource.RemoveFilter();

            // Reset ComboBoxes
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;

            // Optional message
            MessageBox.Show("Filters reset successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            try
            {
                this.Validate();
                eMPLOYEEBindingSource.EndEdit();
                eMPLOYEETableAdapter.Update(avisDS.EMPLOYEE);

                eMPLOYEETableAdapter.Fill(avisDS.EMPLOYEE);
                MessageBox.Show($"Employee Updated:\nID: {id}\nName: {name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            eMPLOYEETableAdapter.FillByFullName(avisDS.EMPLOYEE, textBox1.Text);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }
    }
}
