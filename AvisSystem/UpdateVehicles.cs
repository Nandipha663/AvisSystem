using AvisSystem.AvisDSTableAdapters;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisSystem
{

   
    public partial class UpdateVehicles : Form
    {
        public string HighlightVehicleVIN { get; set; }


        public UpdateVehicles()
        {
            InitializeComponent();
        }



        private void HighlightMostRecentVehicleUpdate()
        {
            DateTime latestTime = DateTime.MinValue;
            DataGridViewRow latestRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["LastUpdated"].Value != DBNull.Value)
                {
                    DateTime updateTime =
                        Convert.ToDateTime(row.Cells["LastUpdated"].Value);

                    if (updateTime > latestTime)
                    {
                        latestTime = updateTime;
                        latestRow = row;
                    }
                }
            }

            if (latestRow != null)
            {
                dataGridView1.ClearSelection();

                latestRow.Selected = true;
                latestRow.DefaultCellStyle.BackColor = Color.LightGreen;

                dataGridView1.FirstDisplayedScrollingRowIndex =
                    latestRow.Index;
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void LoadVehicles()
        {
            vEHICLETableAdapter.Fill(avisDS.VEHICLE);
            label15.Click += panel1_Click;
            label16.Click += panel1_Click;
            pictureBox3.Click += panel1_Click;
        }

        private void UpdateVehicles_Load(object sender, EventArgs e)
        {

            LoadVehicles();
            // TODO: This line of code loads data into the 'avisDS.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.avisDS.VEHICLE);

            HighlightMostRecentVehicleUpdate();

            fileToolStripMenuItem.Enabled = true;
            //viewUpdateVehicleToolStripMenuItem.Enabled = false;
            viewUpdateVehicleStatusToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
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

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            newAddPayment.Show();
            this.Hide();
        }

        private void viewUpdateVehicleStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles vehicle = new UpdateVehicles();
            vehicle.Show();
            this.Hide();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            newAddCustomer.Show();
            this.Hide();
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            newManageCustomers.Show();
            this.Hide();
        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            newAddReservation.Show();
            this.Hide();
        }

        private void viewUpdateCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();   
            newUpdateReservation.Show();
            this.Hide();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            newAddVehicle.Show();
            this.Hide();
        }

        private void addVehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRental rental = new AddRental();
            rental.Show();
            this.Hide();
        }

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRental newUpdateVehicles = new UpdateRental();
            newUpdateVehicles.Show();
            this.Hide();
        }

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            newUpdatePayment.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "🔍 Search Vehicles...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search Vehicles...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void addNewClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            newAddClaim.Show();
            this.Hide();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            newUpdateClaim.Show();
            this.Hide();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vEHICLETableAdapter.FillByVVN(avisDS.VEHICLE, textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = true;

            if (comboBox1.Text == "Status")
            {
                //load status values form employee table
                comboBox2.Items.Add("Available");
                comboBox2.Items.Add("Unavailable");
                comboBox2.Items.Add("Out Of Service");
                comboBox2.Items.Add("Maintenance");
                comboBox2.Items.Add("Rented");
                comboBox2.Items.Add("Reserved");
            }
            else if (comboBox1.Text == "Make")
            {
                comboBox2.Items.Add("Toyota");
                comboBox2.Items.Add("Suzuki");
                comboBox2.Items.Add("Kia");
                comboBox2.Items.Add("Haval");
                comboBox2.Items.Add("Chery");
                comboBox2.Items.Add("Hyundai");
                comboBox2.Items.Add("Range Rover");
                comboBox2.Items.Add("Land Rover");
                comboBox2.Items.Add("Peugeot");
                comboBox2.Items.Add("Audi");
                comboBox2.Items.Add("BMW");
                comboBox2.Items.Add("Mercedes-Benz");
                comboBox2.Items.Add("Porsche");
                comboBox2.Items.Add("Volkswagen");
            }
            else if (comboBox1.Text == "Category")
            {
                //load vehicle categories
                comboBox2.Items.Add("SUV");
                comboBox2.Items.Add("Van");
                comboBox2.Items.Add("Hatchback");
                comboBox2.Items.Add("Sedan");
                comboBox2.Items.Add("Compact");
                comboBox2.Items.Add("Premium");
                comboBox2.Items.Add("Luxury");

            }
            else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Select filter type and value");
                return;
            }

            string column = "";
            string value = comboBox2.Text.Trim();

            if (comboBox1.Text == "Status")
                column = "Status";

            else if (comboBox1.Text == "Make")
                column = "Make";

            else if (comboBox1.Text == "Category")
                column = "Category";

            if (column == "")
                return;

            if (column == "BranchID")
                vEHICLEBindingSource.Filter = $"{column} = {value}";
            else
                vEHICLEBindingSource.Filter = $"{column} = '{value}'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                vEHICLEBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;

                // Optional message
                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (textBox1.Text == "🔍 Search Vehicles..."   || textBox1.Text != "🔍 Search Vehicles...")
            {
                label5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                label9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                label11.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                try
                {
                    byte[] imgBytes = (byte[])dataGridView1.CurrentRow.Cells[7].Value;

                    MemoryStream ms = new MemoryStream(imgBytes);

                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch
                {
                    MessageBox.Show("Image could not be loaded.");
                }

                //pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[7].Value.ToString());



                string status = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                label2.Text = status;

                if (status == "Available")
                {
                    label2.ForeColor = Color.Green;
                }
                else if (status == "Reserved" || status == "Rented")
                {
                    label2.ForeColor = Color.Red;
                }
                else if (status == "Maintenance")
                {
                    label2.ForeColor = Color.Orange;
                }
                else if (status == "Out of Service")
                {
                    label2.ForeColor = Color.DarkRed;
                }
            }

           /* label5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label11.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            try
            {
                byte[] imgBytes = (byte[])dataGridView1.CurrentRow.Cells[7].Value;

                MemoryStream ms = new MemoryStream(imgBytes);

                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Image could not be loaded.");
            }

            //pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[7].Value.ToString());



            string status = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            label2.Text = status;

            if (status == "Available")
            {
                label2.ForeColor = Color.Green;
            }
            else if (status == "Reserved" || status == "Rented")
            {
                label2.ForeColor = Color.Red;
            }
            else if (status == "Maintenance")
            {
                label2.ForeColor = Color.Orange;
            }
            else if (status == "Out of Service")
            {
                label2.ForeColor = Color.DarkRed;
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "status";
            label2.ForeColor = Color.Black;
            label5.Text = "(ID)";
            label7.Text = "(Make)";
            label9.Text = "(Model)";
            label11.Text = "(Year)";
            textBox1.Clear();
            pictureBox1.Image = null;

            vEHICLETableAdapter.Fill(avisDS.VEHICLE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                  "Are you sure you want to delete this vehicle?",
                                  "Confirm Delete",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question
                                  );

            if (result == DialogResult.Yes)
            {
                string vehicle = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vEHICLETableAdapter.DeleteVehicle(vehicle);

                MessageBox.Show("Vehicle deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vEHICLETableAdapter.Fill(avisDS.VEHICLE);
            }
            else
            {
                MessageBox.Show("Vehicle deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                this.Validate();
                vEHICLEBindingSource.EndEdit();
                //vEHICLETableAdapter.Update(avisDS.VEHICLE);

                vEHICLETableAdapter.Fill(avisDS.VEHICLE);
                MessageBox.Show($"Vehicle Updated:\nVVN {id}");
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();

                op.Title = "Select Vehicle Image";

                op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(op.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Could not load image.");
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Just reload from database
            this.vEHICLETableAdapter.Fill(this.avisDS.VEHICLE);
            dataGridView1.Refresh();

            MessageBox.Show("Data refreshed!", "Refresh",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
