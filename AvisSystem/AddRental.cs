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

namespace AvisSystem
{
    public partial class AddRental : Form
    {
        public AddRental()
        {
            InitializeComponent();
            label3.Click += panel1_Click;
            label10.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void AddRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.avisDS.BRANCH);
            // TODO: This line of code loads data into the 'avisDS.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.avisDS.BOOKING);

            AvisDSTableAdapters.VEHICLETableAdapter vehicleTA = new AvisDSTableAdapters.VEHICLETableAdapter();

            AvisDS.VEHICLEDataTable dt = new AvisDS.VEHICLEDataTable();

            vehicleTA.Fill(dt);

            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "VehicleVinNo";
            comboBox3.ValueMember = "VehicleVinNo";

            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            addRentalToolStripMenuItem.Enabled = false;
           
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

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicle newAddVehicle = new AddVehicle();
            newAddVehicle.Show();
            this.Hide();
        }

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                UpdateVehicles newUpdateVehicles = new UpdateVehicles();                this.Hide();
                newUpdateVehicles.Show();
                this.Hide();
        }

        private void addRentalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            newAddReservation.Show();
            this.Hide();
        }

        private void viewUpdateRentalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateReservation newUpdateReservation = new UpdateReservation();
            newUpdateReservation.Show();
            this.Hide();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void manageRentalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox3.Clear();
            maskedTextBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.ResetText();

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

        private void button1_Click(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            newAvisMenuForm.Show();
            this.Hide();
        }

        AvisSystem.AvisDSTableAdapters.VEHICLE_RETURNTableAdapter vehicleTA = new AvisSystem.AvisDSTableAdapters.VEHICLE_RETURNTableAdapter();

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                vehicleTA.AddNewVR(Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox1.Text), dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox3.Text.ToString(), Convert.ToDecimal(maskedTextBox2.Text),comboBox3.Text);
                MessageBox.Show("Vehicle return record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Refill employees table
                UpdateRental Return = Application.OpenForms["UpdateRental"] as UpdateRental;

                if (Return != null)
                {
                    Return.LoadVehiclesReturn(); // refresh open form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
    }
    
}
