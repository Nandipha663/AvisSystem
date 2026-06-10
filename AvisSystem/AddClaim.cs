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
    public partial class AddClaim : Form
    {
        public AddClaim()
        {
            InitializeComponent();

        }

        private void manageBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewUpdateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void viewUpdateBookingsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            this.Hide();
            newUpdatePayment.Show();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            this.Hide();
            newAddBranch.Show();
        }

        private void viewUpdateBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            this.Hide();
            newUpdateClaim.Show();
        }

        private void AddClaim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisDS1.CLAIM' table. You can move, or remove it, as needed.
            this.cLAIMTableAdapter.Fill(this.avisDS1.CLAIM);
            addNewClaimToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;

            var statuses = this.avisDS1.CLAIM
                               .AsEnumerable()
                               .Select(row => row["CLaimStatus"].ToString())
                               .Distinct()
                               .ToList();
            comboBox2.DataSource = statuses;

            comboBox2.SelectedIndex = -1;
            LoadBookingIDs();
        }
        private void LoadBookingIDs()
        {
            try
            {
                // Fill the BOOKING table if not already filled
                if (this.avisDS1.BOOKING.Rows.Count == 0)
                    dsBook.Fill(this.avisDS1.BOOKING);
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Booking IDs:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            this.Hide();
            newAvisMenuForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //   comboBox1.SelectedValue = DBNull.Value;
         //   comboBox1.SelectedIndex = -1;

           // comboBox2.SelectedIndex = -1;

          //  textBox1.Clear();
          // dateTimePicker1.Value = DateTime.Today;
          //  textBox2.Clear();
          //  textBox3.Clear();

         //   this.dsBook.Fill(this.avisDS1.BOOKING);
         ClearForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a Booking ID before adding a claim.",
                                " ",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = Convert.ToInt32(comboBox1.SelectedValue);
            try
            {
             //  dsBook.FillByBookingID(this.avisDS1.BOOKING, bookingID);

                MessageBox.Show($"Claim added for Booking ID: {bookingID}",
                                " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding claim:\n" + ex.Message,
                                "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Please select a Claim Status.",
                                " ",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string claimStatus = comboBox2.SelectedItem.ToString();
            try
            {
                int nextClaimID = GetNextCLAIMID();
                string claimType = textBox2.Text.Trim();
                string claimDescription = textBox1.Text.Trim();
                string responsibleParty = textBox3.Text.Trim();
                DateTime claimDate = dateTimePicker1.Value;

                this.cLAIMTableAdapter.Fill(this.avisDS1.CLAIM);

                AvisDS.CLAIMRow newRow = this.avisDS1.CLAIM.NewCLAIMRow();
               // newRow["ClaimID"] = nextClaimID;
                newRow.BookingID = bookingID;
                newRow.ClaimStatus = claimStatus;
                newRow.ClaimDescription = claimDescription;
                newRow.ClaimType = claimType;
                newRow.ResponsibleParty= responsibleParty;
                newRow.ClaimDate = claimDate;

                this.avisDS1.CLAIM.AddCLAIMRow(newRow);
                this.cLAIMTableAdapter.Update(this.avisDS1.CLAIM);
                MessageBox.Show("Claim successfully added to the database!",
                                " ",
                                MessageBoxButtons.OK);
                ClearForm(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving claim:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
           // comboBox1.SelectedValue = DBNull.Value;
           // comboBox1.SelectedIndex = -1;

           // comboBox2.SelectedIndex = -1;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
            dateTimePicker1.Value = DateTime.Today;

            this.dsBook.Fill(this.avisDS1.BOOKING);
            if (comboBox1.DataSource != null)
            {
                this.BindingContext[comboBox1.DataSource].ResumeBinding();
            }

            comboBox1.SelectedIndex = -1;

            comboBox2.SelectedIndex = -1;

        }
        private int GetNextCLAIMID()
        {
            if (this.avisDS1.CLAIM.Rows.Count == 0)
                return 1;

            // Find the maximum ClaimID and add 1
            int maxId = this.avisDS1.CLAIM
                .AsEnumerable()
                .Select(row => row.Field<int>("ClaimID"))
                .DefaultIfEmpty(0)
                .Max();

            return maxId + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
