using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Text.RegularExpressions;

namespace AvisSystem
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;
            addVehicleToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
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

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
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

        private void viewUpdateVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();
        }

        private void processPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox8.Clear();
            pictureBox1.Image = null;

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void signUpEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            this.Hide();
            signUp.Show();
        }

        private void viewUpdateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            this.Hide();
            manageEmp.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //take values from the branch id table to this combobox
            /*for (int i =0; i < BranchDGV.Rows.Counts - 1; i++)
            {
                comboBox2.Items.Add(BranchDGV.Rows[i].Cells[0].Value.ToString());
            }*/
        }

        AvisSystem.AvisDSTableAdapters.VEHICLETableAdapter vehicleTA = new AvisSystem.AvisDSTableAdapters.VEHICLETableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = null;

            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                imageBytes = ms.ToArray();
            }

            //check the vehicle vin number
            string vin = textBox2.Text.Trim();

            if (!Regex.IsMatch(vin, "^[A-HJ-NPR-Z0-9]{17}$"))
            {
                MessageBox.Show("Invalid VIN number.");
                textBox2.Focus();
                return;
            }

            //checking the registration number
            string reg = textBox1.Text.Trim();

            if (!Regex.IsMatch(reg, @"^[A-Z]{2}\s\d{2}\s[A-Z]{2}\s[A-Z]{2}$"))
            {
                MessageBox.Show("Invalid registration number.");
                textBox1.Focus();
                return;
            }

            try
            {
                vehicleTA.AddNewVehicle(textBox2.Text.ToString(), Convert.ToInt32(comboBox2.Text), textBox2.Text.ToString(), textBox1.Text.ToString(), textBox6.Text.ToString(), textBox6.Text.ToString(), comboBox1.Text.ToString(), imageBytes);
                MessageBox.Show("Vehicle registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Refill employees table
                UpdateVehicles vehForm = Application.OpenForms["UpdateVehicle"] as UpdateVehicles;

                if (vehForm != null)
                {
                    vehForm.LoadVehicles(); // refresh open form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
