using AvisSystem.AvisDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AvisSystem
{
    public partial class UpdateReservation : Form
    {
        public UpdateReservation()
        {
            InitializeComponent();
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void HighlightMostRecentBooking()
        {
            DateTime latestTime = DateTime.MinValue;
            DataGridViewRow latestRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["LastUpdated"].Value != DBNull.Value)
                {
                    DateTime updateTime =
                        Convert.ToDateTime(row.Cells[18].Value);

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

       
        private void UpdateReservation_Load(object sender, EventArgs e)
        {
             dateTimePicker1.Enabled = false;
            comboBox2.Enabled = false;
            button7.Visible = false;


            // TODO: This line of code loads data into the 'avisDS.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.avisDS.BOOKING);
           


            if (!dataGridView1.Columns.Contains("AlertStatus"))
            {
                DataGridViewTextBoxColumn alertCol = new DataGridViewTextBoxColumn();
                alertCol.Name = "AlertStatus";
                alertCol.HeaderText = "Alert Status";
                alertCol.ReadOnly = true;

                dataGridView1.Columns.Add(alertCol);
            }

            HighlightMostRecentBooking();

            fileToolStripMenuItem.Enabled = true;
            viewUpdateBookingToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

       
        private string GetBookingAlert(int currentBookingID,
                               string vin,
                               DateTime returnDate,
                               string status)
        {

            if (status != "Confirmed")
                return "";


            bool isOverdue =
                status == "Confirmed" &&
                returnDate < DateTime.Today;

            bool futureCustomerWaiting = false;
            bool needsReassignment = false;

            foreach (DataRow booking in avisDS.BOOKING.Rows)
            {

                int otherBookingID =
                    Convert.ToInt32(booking["BookingID"]);

                // Skip the booking currently being checked
                if (otherBookingID == currentBookingID)
                    continue;

                string otherVin =
                    booking["VehicleVinNo"].ToString();

                string otherStatus =
                    booking["Status"].ToString();

                DateTime otherPickupDate =
                    Convert.ToDateTime(booking["PickUp Date"]);


                if (otherVin == vin && otherStatus == "Confirmed")
                {
                    if (otherPickupDate <= DateTime.Today.AddDays(1))
                    {
                        needsReassignment = true;
                    }
                }


                // Same vehicle?
                if (otherVin == vin)
                {
                    // Another confirmed booking waiting?
                    if (otherStatus == "Confirmed" &&
                        otherPickupDate > DateTime.Today)
                    {
                        futureCustomerWaiting = true;
                        break;
                    }
                }
            }

            if (isOverdue && futureCustomerWaiting)
                return "OVERDUE - CUSTOMER WAITING";

            if (isOverdue)
                return "OVERDUE BOOKING";

            if (needsReassignment)
                return "REASSIGN VEHICLE";

            if (futureCustomerWaiting)
                return "UPCOMING BOOKING";

            return "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bOOKINGTableAdapter.FillByCustName(avisDS.BOOKING, textBox1.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            string bookingStatus = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            string vin = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (bookingStatus == "Cancelled")
            {
                vehicleTableAdapter1.UpdateVehicleStatus("Available", vin);
            }

            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                this.Validate();
                bOOKINGBindingSource.EndEdit();
                bOOKINGTableAdapter.Update(avisDS.BOOKING);

                bOOKINGTableAdapter.Fill(avisDS.BOOKING);
                MessageBox.Show($"Booking Updated with:\nBooking ID: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void AddReservationToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AddRentalToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AddVehicleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AddPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "🔍 Search for Booking...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search for Booking...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void AddNewClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            this.Hide();
            newAddClaim.Show();
        }

        private void viewUpdateClaimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            this.Hide();
            newUpdateClaim.Show();
        }

        private void AddNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           AvisMenuForm newAvisMenuForm = new AvisMenuForm();
           this.Hide();
           newAvisMenuForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
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
                    else if (comboBox2.Text == "Confirmed")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Confirmed'";
                    }
                    else if (comboBox2.Text == "Completed")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Completed'";
                    }
                    else if (comboBox2.Text == "Pending")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Pending'";
                    }
                    else if (comboBox2.Text == "Cancelled")
                    {
                        bOOKINGBindingSource.Filter = "Status = 'Cancelled'";
                    }
                   

                }
                else if (comboBox1.Text == "Booking Date")
                {
                    DateTime date = dateTimePicker1.Value.Date;

                    bOOKINGBindingSource.Filter =
                        $"[Booking Date] >= '{date:yyyy-MM-dd}' AND [Booking Date] < '{date.AddDays(1):yyyy-MM-dd}'";
                }
                else if (comboBox1.Text == "Expected Return Date")
                {
                    DateTime date = dateTimePicker1.Value.Date;

                    bOOKINGBindingSource.Filter =
                        $"ExpectedReturnDate >= '{date:yyyy-MM-dd}' AND ExpectedReturnDate < '{date.AddDays(1):yyyy-MM-dd}'";
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

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                  "Are you sure you want to delete this booking record?",
                                  "Confirm Delete",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question
                                  );

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bOOKINGTableAdapter.DeleteBooking(id);

                MessageBox.Show("Booking record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bOOKINGTableAdapter.Fill(avisDS.BOOKING);
            }
            else
            {
                MessageBox.Show("Booking recording deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search Reservation...";
            textBox1.ForeColor = Color.Gray;
            textBox2.Clear();
            textBox3.Clear();
            bOOKINGTableAdapter.Fill(avisDS.BOOKING);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Status")
            {
                comboBox2.Enabled = true;
                dateTimePicker1.Enabled = false;
                comboBox2.Items.Add("Completed");
                comboBox2.Items.Add("Pending");
                comboBox2.Items.Add("Cancelled");
                comboBox2.Items.Add("Confirmed");
                
            }
            else if (comboBox1.Text == "Booking Date"  || comboBox1.Text == "Expected return date")
            {

                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                bOOKINGBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox2.Clear();
                textBox3.Clear();
                

                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (textBox1.Text == "🔍 Search for Booking...")
            {
                try
                {

                    textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            else
            {
                try
                {

                    textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            string alert = dataGridView1.CurrentRow.Cells["AlertStatus"].Value?.ToString();

            if (alert == "REASSIGN VEHICLE")
            {
                button7.Visible = true;
            }
            else
            {
                button7.Visible = false;
            }
        }

        private void signUpEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            this.Hide();
            signUp.Show();
        }

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            manageEmp.Show();
            this.Hide();
        }


        //changing status of the booking once the date arrives and changing the status of the vehicle to rented or available based on the booking status
        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int bookingID = Convert.ToInt32(row.Cells[0].Value);

                string vin =
                    row.Cells[3].Value?.ToString();

                DateTime pickUpDate = Convert.ToDateTime(row.Cells[7].Value);
                string bookingStatus = row.Cells[13].Value.ToString();


                if (pickUpDate.Date == DateTime.Today)
                {
                    if (bookingStatus == "Confirmed")
                    {
                        vehicleTableAdapter1.UpdateVehicleStatus( "Rented", vin);
                    }
                    else if (bookingStatus == "Cancelled" || bookingStatus == "Pending")
                    {
                        vehicleTableAdapter1.UpdateVehicleStatus( "Available", vin);
                    }
                }


                string status =
                        row.Cells[13].Value?.ToString();

                DateTime returnDate;

                if (!DateTime.TryParse(
                        row.Cells[6].Value?.ToString(),
                        out returnDate))
                {
                    continue;
                }

                string alert =
                    GetBookingAlert( bookingID, vin, returnDate, status);

                if (string.IsNullOrEmpty(alert))
                {
                    continue;
                }

                row.Cells["AlertStatus"].Value = alert;

                if (alert == "OVERDUE - CUSTOMER WAITING")
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else if (alert == "OVERDUE BOOKING")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (alert == "UPCOMING BOOKING")
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;

                }
                else if (alert == "REASSIGN VEHICLE")
                {
                    row.DefaultCellStyle.BackColor = Color.Gold;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int bookingID =
        Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            string vin =
                dataGridView1.CurrentRow.Cells[3].Value.ToString();

            DateTime pickUp = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
            DateTime dropOff = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value);

            ReAssignVehicle frm =
                new ReAssignVehicle(bookingID, vin, pickUp, dropOff);

            frm.ShowDialog();

            bOOKINGTableAdapter.Fill(avisDS.BOOKING);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*if the booking status is pending,change booking status to cancelled
             * if booking status is confirmed, change booking status to cancelled and update vehicle status to available
             * record refund
             * refund status should be pending and once the refund payment has been recorded for that booking , the refund status should be updated to refund is being processed
             * on payment table we should record refund payment and make the status to be pending
             */
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookingStatus = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            string vin = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int bookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show(
                                 "Are you sure you want to cancel this booking?",
                                 "Confirm Cancelation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question
                                 );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Validate status before proceeding
                    if (bookingStatus == "Completed")
                    {
                        MessageBox.Show("Booking cannot be cancelled as it is already completed.",
                            "Cancellation Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                //check if refund is elligible based on the pick up date and current date
               // DateTime pickupDateTime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);

                 //   DateTime currentDateTime = DateTime.Now;

                   // TimeSpan timeUntilPickup = pickupDateTime - currentDateTime;

                //if (timeUntilPickup.TotalHours >= 24)
                  //  {
                    //    dataGridView1.CurrentRow.Cells[17].Value = "Eligible";
                    //}
                    //else
                    //{
                      //  dataGridView1.CurrentRow.Cells[17].Value = "Not eligible";
                    //}
                
            }
            else
            {
                MessageBox.Show("Booking Cancelation Terminated.", "Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Validate();
            bOOKINGBindingSource.EndEdit();
            bOOKINGTableAdapter.Update(avisDS.BOOKING);

            bOOKINGTableAdapter.Fill(avisDS.BOOKING);
            //try
            //{
            //    // Update the in-memory row
            //    dataGridView1.CurrentRow.Cells[15].Value = "Cancelled";

            //    if (bookingStatus == "Confirmed")
            //    {
            //        vehicleTableAdapter1.UpdateVehicleStatus("Available", vin);
            //    }

            //    // NOTE: RefundStatus is marked read-only both on the DataGridView column
            //    // and on the underlying DataTable (see AvisDS.xsd), which is exactly what
            //    // was throwing the "Column 'RefundStatus' is read only" error. It can't be
            //    // set through dataGridView1.CurrentRow.Cells[...] at all. If you still want
            //    // to record refund eligibility, that needs its own TableAdapter update query
            //    // (or the ReadOnly flag removed from the dataset), not a direct cell write.

            //    // Persist the status change to the database
            //    this.Validate();
            //    bOOKINGBindingSource.EndEdit();
            //    bOOKINGTableAdapter.Update(avisDS.BOOKING);

            //    bOOKINGTableAdapter.Fill(avisDS.BOOKING);

            //    MessageBox.Show($"Booking has been cancelled.", "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error cancelling booking: " + ex.Message);
            //}

        }

        private void addInspectionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInspection newAddInspection = new AddInspection();
            newAddInspection.Show();
            this.Hide();

        }

        private void viewInspectionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInspection newManageInspection = new ManageInspection();
            newManageInspection.Show();
            this.Hide();

        }

        private void addRentalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRentalRental addRentalRentalForm = new AddRentalRental();
            addRentalRentalForm.Show();
            this.Hide();
        }

        private void viewRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRentalRental updateRentalRentalForm = new UpdateRentalRental();
            updateRentalRentalForm.Show();
            this.Hide();
        }
    }
}
