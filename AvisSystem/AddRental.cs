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

            //ConfigureComboBox1();

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
                UpdateVehicles newUpdateVehicles = new UpdateVehicles();
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "🔍 Search for Booking...";
            textBox6.ForeColor = Color.Gray;
            textBox7.Clear();
           // maskedTextBox2.Clear();
            //comboBox1.SelectedIndex = -1;
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
                //UPDATE VEHICLE STATUS
                vehicleTableAdapter1.UpdateVehicleStatus("Available", textBox2.Text);

                //update the status of the booking to "Completed"
                bOOKINGTableAdapter.UpdateStatusBooking("Completed", Convert.ToInt32(textBox1.Text));

                vehiclE_RETURNTableAdapter1.AddNewVR(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox3.Text, Convert.ToDecimal(textBox4.Text), textBox2.Text, textBox7.Text, textBox5.Text);
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

       /* private void ConfigureComboBox1()
        {
            // Create filtered views for dropoff branches (only where dropOffAvailable = 'Yes')
            DataView dropoffBranchesView = new DataView(this.avisDS.BRANCH);
            dropoffBranchesView.RowFilter = "dropOffAvailable = 'Yes'";

            // DropOff Branch combobox - ONLY branches that allow dropoff
            comboBox1.DataSource = dropoffBranchesView;
            comboBox1.DisplayMember = "branchName";
            comboBox1.ValueMember = "BranchID";
            comboBox1.SelectedIndex = -1;
        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool bookingSelected = false;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Booking selected! Please choose the return date to calculate any extra charges if applicable.", "Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bookingSelected = false;
            if (textBox6.Text == "🔍 Search for Booking...")
                return;

                string status = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            if (status == "Pending" ||  status == "Completed"  ||  status == "Cancelled")
            {
                MessageBox.Show("Only Confirmed bookings can be selected for this operation!. Please select a confirmed.",
                               "Invalid Booking Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string vin = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                string description = vehicleTableAdapter1.GetVehicleDescrByVIN(vin).ToString();
                textBox5.Text = description;

                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                textBox4.Clear();
                dateTimePicker1.Value = DateTime.Today;

                bookingSelected = true;
            }   
        }


        private void CalculateExtraCharge()
        {
            DateTime expectedReturnDate =
                Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);

            DateTime actualReturnDate =
                dateTimePicker1.Value.Date;

            int lateDays =
                (actualReturnDate - expectedReturnDate).Days;

            string vin =
                dataGridView1.CurrentRow.Cells[3].Value.ToString();

            string category = vehicleTableAdapter1.GetCatByVIN(vin).ToString();

            decimal penaltyPerDay = 0;

            if (category == "SUV")
                penaltyPerDay = 800;
            else if (category == "Van")
                penaltyPerDay = 650;
            else if (category == "Hatchback")
                penaltyPerDay = 450;
            else if (category == "Sedan")
                penaltyPerDay = 550;
            else if (category == "Premium")
                penaltyPerDay = 1200;
            else if (category == "Luxury")
                penaltyPerDay = 1800;
            else if (category == "Compact")
                penaltyPerDay = 350;
            else
                penaltyPerDay = 400;

            decimal extraCharge =
                lateDays > 0 ? lateDays * penaltyPerDay : 0;

            textBox4.Text = extraCharge.ToString("0.00");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!bookingSelected)
                return;

            CalculateExtraCharge();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            bOOKINGTableAdapter.FillByCustName(avisDS.BOOKING, textBox6.Text);
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "🔍 Search for Booking...")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "🔍 Search for Booking...";
                textBox6.ForeColor = Color.Gray;
                textBox6.Font = new Font(textBox6.Font, FontStyle.Italic);
            }
        }
    }
    
}
