using AvisSystem.AvisDSTableAdapters;
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
    public partial class ReAssignVehicle : Form
    {
        private readonly int bookingID;
        private readonly string currentVin;

        private readonly DateTime pickUpDate;
        private readonly DateTime dropOffDate;

        private readonly string make;
        private readonly string model;
        private readonly string category;
        public ReAssignVehicle(int bookingID, string vin, DateTime pickUp, DateTime dropOff)
        {
            InitializeComponent();

            avisDS.EnforceConstraints = false;

            this.bookingID = bookingID;
            this.currentVin = vin;
            this.pickUpDate = pickUp;
            this.dropOffDate = dropOff;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            this.Hide();
            newAddCustomer.Show();
        }

        private void viewUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers newManageCustomers = new ManageCustomers();
            this.Hide();
            newManageCustomers.Show();
        }

        private void AddBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookingReservation newAddReservation = new AddBookingReservation();
            this.Hide();
            newAddReservation.Show();
        }

        private void viewUpdateCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AddRentalToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AddVehicleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AddBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            this.Hide();
            newUpdateBranch.Show();
        }

        private void AddClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClaim newAddClaim = new AddClaim();
            this.Hide();
            newAddClaim.Show();
        }

        private void viewUpdateClamisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClaim newUpdateClaim = new UpdateClaim();
            this.Hide();
            newUpdateClaim.Show();
        }

        
        private void AddBranch_Load(object sender, EventArgs e)
        {

            try
            {
                

                // STEP 1: Get current vehicle
                DataTable dt = vEHICLETableAdapter.GetDetailsOfVehicle(currentVin);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Vehicle not found.");
                    return;
                }

                string make = dt.Rows[0]["Make"].ToString();
                string model = dt.Rows[0]["Model"].ToString();
                string category = dt.Rows[0]["Category"].ToString();

                // STEP 2: Similar vehicles
                DataTable similarVehicles =
                    vEHICLETableAdapter.GetSimilarVehicles(make, model, category, currentVin);

                // STEP 3: Overlapping bookings
                DataTable booked = bookingTableAdapter1.GetOverlappingVehicles(pickUpDate, dropOffDate);

                HashSet<string> bookedVins = new HashSet<string>();

                foreach (DataRow row in booked.Rows)
                {
                    bookedVins.Add(row["VehicleVinNo"].ToString());
                }

                // STEP 4: FILTER
                DataTable filtered = similarVehicles.Clone();

                foreach (DataRow row in similarVehicles.Rows)
                {
                    string vin = row["VehicleVinNo"]?.ToString();
                    string status = row["Status"]?.ToString();

                    if (!string.IsNullOrEmpty(vin) &&
                        status == "Available" &&
                        vin != currentVin &&
                        !bookedVins.Contains(vin))
                    {
                        filtered.ImportRow(row);
                    }
                }

                // STEP 5: DISPLAY
                dataGridView1.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateVehicles updateVeh = new UpdateVehicles();
            updateVeh.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string newVin =
        dataGridView1.CurrentRow.Cells["VehicleVinNo"].Value.ToString();

            bookingTableAdapter1.UpdateBookingVehicle(
                newVin,
                bookingID);

            MessageBox.Show(
                "Vehicle reassigned successfully.");

            this.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
