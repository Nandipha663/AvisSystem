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
    public partial class AddBookingReservation : Form
    {
        public AddBookingReservation()
        {
            InitializeComponent();
            label9.Click += panel1_Click;
            label11.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Clear  ();
            textBox10.Clear ();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker2.Text= DateTime.Now.ToString();
            dateTimePicker3.Text= DateTime.Now.ToString();
            comboBox2.Text="";
            comboBox3.SelectedIndex= 0;
            comboBox4.SelectedIndex = 0;
            textBox1.Clear();
            textBox5.Clear();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.avisDS.BRANCH);
            // TODO: This line of code loads data into the 'avisDS.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.avisDS.VEHICLE);
            // TODO: This line of code loads data into the 'avisDS.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.avisDS.CUSTOMER);
            fileToolStripMenuItem.Enabled = true;
            addBookingToolStripMenuItem2.Enabled = false;
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           UpdateReservation newUpdateReservation = new UpdateReservation();
            this.Hide();
            newUpdateReservation.Show();


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

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AddCustomer newAddCustomer = new AddCustomer();
                this.Hide();
                newAddCustomer.Show();
        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cUSTOMERTableAdapter.FillByFullName(avisDS.CUSTOMER, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            vEHICLETableAdapter.FillByMake(avisDS.VEHICLE,textBox5.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox9.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingTableAdapter1.InsertBooking(Convert.ToInt32(textBox10.Text), Convert.ToInt32(comboBox1.Text), textBox9.Text, comboBox4.Text, comboBox3.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker3.Text), comboBox2.Text);
            MessageBox.Show("Booking Added Successfully");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }
    }
}
