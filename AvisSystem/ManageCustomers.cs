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
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void HighlightNewestCustomer()
        {
            int highestID = 0;
            DataGridViewRow newestRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);

                    if (id > highestID)
                    {
                        highestID = id;
                        newestRow = row;
                    }
                }
            }

            if (newestRow != null)
            {
                dataGridView1.ClearSelection();

                newestRow.Selected = true;
                newestRow.DefaultCellStyle.BackColor = Color.LightGreen;

                dataGridView1.FirstDisplayedScrollingRowIndex =
                    newestRow.Index;
            }
        }
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.avisDS.CUSTOMER);

            HighlightNewestCustomer();
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
            newAddCustomer.Show();
            this.Hide();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental newAddRental = new AddRental();
            newAddRental.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateRental = new UpdateRental();
            newUpdateRental.Show();
            this.Hide();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            newAddVehicle.Show();
            this.Hide();
        }

        private void viewUpdateVehicleStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            newUpdateVehicles.Show();
            this.Hide();


        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            newAddPayment.Show();
            this.Hide();
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "🔍 Search customers...")
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Status")
                {
                    if (string.IsNullOrEmpty(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a filter first.");
                        return;
                    }

                    if (comboBox2.Text == "Active")
                    {
                        cUSTOMERBindingSource.Filter = "Status = 'Active'";
                    }
                    else if (comboBox2.Text == "Inactive")
                    {
                        cUSTOMERBindingSource.Filter = "Status = 'Inactive'";
                    }
                }
                else if (comboBox1.Text == "Licence Code")
                {
                    if (string.IsNullOrEmpty(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a filter first.");
                        return;
                    }

                    if (comboBox2.Text == "B")
                    {
                        cUSTOMERBindingSource.Filter = "LicenceCode = 'B'";
                    }
                    else if (comboBox2.Text == "C1")
                    {
                        cUSTOMERBindingSource.Filter = "LicenceCode = 'C1'";
                    }
                }
                else
                {
                    MessageBox.Show("Please select a filter first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            newAddClaim.Show();
            this.Hide();
        }

        private void updateClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            newUpdateClaim.Show();
            this.Hide();
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            newAddBranch.Show();
            this.Hide();
        }

        private void updateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cUSTOMERTableAdapter.FillByFullName(avisDS.CUSTOMER, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search customers...";
            textBox1.ForeColor = Color.Gray;

            textBox2.Clear();
            cUSTOMERTableAdapter.Fill(avisDS.CUSTOMER);

            // Reset ComboBoxes
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                comboBox2.Items.Add("Inactive");
            }
            
            else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                cUSTOMERBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;

                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                                  "Are you sure you want to delete this vehicle return record?",
                                  "Confirm Delete",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question
                                  );

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    cUSTOMERTableAdapter.DeleteCustomer(id);

                    MessageBox.Show("Customer Vehicle return record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cUSTOMERTableAdapter.Fill(avisDS.CUSTOMER);
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Customer deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                this.Validate();
                cUSTOMERBindingSource.EndEdit();
                cUSTOMERTableAdapter.Update(avisDS.CUSTOMER);

                cUSTOMERTableAdapter.Fill(avisDS.CUSTOMER);
                MessageBox.Show($"Customer information Updated successfully with:\nCustomer name: {name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signUpEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void viewUpdateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
