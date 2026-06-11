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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.avisDS.CUSTOMER);
            fileToolStripMenuItem.Enabled = true;
            viewUpdateCustomerToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            this.Hide();
            newAddPayment.Show();
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "🔍 Search customers...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search customers...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
                {
                    cUSTOMERTableAdapter.FillByActive(avisDS.CUSTOMER);
                }
                else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                {
                    cUSTOMERTableAdapter.FillByInactive(avisDS.CUSTOMER);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    cUSTOMERTableAdapter.FillByLicenceB(avisDS.CUSTOMER);
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
                {
                    cUSTOMERTableAdapter.FillByLicenceC1(avisDS.CUSTOMER);
                }
            }
            catch
            {
                    MessageBox.Show("Please select a filter option from both dropdowns.", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cUSTOMERTableAdapter.FillByFullName(avisDS.CUSTOMER, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DataRow cst;
            cst = avisDS.Update_Customer.NewRow();
            cst["CustomerID"] = dataGridView1.CurrentRow.Cells[0].Value;
            cst["FullName"] = dataGridView1.CurrentRow.Cells[1].Value;
            cst["Address"] = dataGridView1.CurrentRow.Cells[2].Value;
            cst["ContactNumber"] = dataGridView1.CurrentRow.Cells[3].Value;
            cst["EmailAddress"] = dataGridView1.CurrentRow.Cells[4].Value;
            cst["LicenceNumber"] = dataGridView1.CurrentRow.Cells[5].Value;
            cst["Status"] = dataGridView1.CurrentRow.Cells[6].Value;
            cst["LicenceCode"]= dataGridView1.CurrentRow.Cells[7].Value;
            cst["CustomerUsername"]= dataGridView1.CurrentRow.Cells[8].Value;
            cst["CustomerPassword"] = dataGridView1.CurrentRow.Cells[9].Value;
            avisDS.Update_Customer.Rows.Add(cst);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            dataGridView2.Rows.Clear();
        }
    }
}
