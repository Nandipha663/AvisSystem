using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AvisSystem
{
    public partial class UpdatePayment : Form
    {
        public UpdatePayment()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void LoadPayments()
        {
            pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
        }
        private void UpdatePayment_Load(object sender, EventArgs e)
        {

            LoadPayments();
            // TODO: This line of code loads data into the 'avisDS.PAYMENT' table. You can move, or remove it, as needed.
            this.pAYMENTTableAdapter.Fill(this.avisDS.PAYMENT);
            fileToolStripMenuItem.Enabled = true;
            viewUpdatePaymentToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();

        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateRentalStatusToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            this.Hide();
            newUpdateVehicles.Show();


        }

        private void addPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void manageRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "🔍 Search Payments...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search Payments...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void addNewClaimToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddBranch newAddBranch = new AddBranch();
            this.Hide();
            newAddBranch.Show();
        }

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void label13_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            manageEmp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Payment Type")
                {
                    if (string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a payment type first.");
                        return;
                    }

                    pAYMENTBindingSource.Filter =
                        $"PaymentType = '{comboBox2.Text}'";
                }

                else if (comboBox1.Text == "Payment Status")
                {
                    if (string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        MessageBox.Show("Please select a payment status first.");
                        return;
                    }

                    pAYMENTBindingSource.Filter =
                        $"PaymentStatus = '{comboBox2.Text}'";
                }

                else if (comboBox1.Text == "Date")
                {
                    if (dateTimePicker1.CustomFormat == " ")
                    {
                        MessageBox.Show("Please select a date first.");
                        return;
                    }

                    DateTime date = dateTimePicker1.Value.Date;

                    pAYMENTBindingSource.Filter =
                        $"PaymentDate >= #{date:yyyy-MM-dd}# AND PaymentDate < #{date.AddDays(1):yyyy-MM-dd}#";
                }

                else
                {
                    MessageBox.Show("Please select a filter category first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                textBox1.Text == "🔍 Search Payment...")
            {
                pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
                return;
            }

            pAYMENTTableAdapter.FillByBookingID(avisDS.PAYMENT, textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Payment Type")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("EFT");
                comboBox2.Items.Add("Cash");
                comboBox2.Items.Add("Debit Card");
                comboBox2.Items.Add("Credit Card");
            }
            else if (comboBox1.Text == "Payment Status")
            {

                comboBox2.Enabled = true;
                comboBox2.Items.Add("Complete");
                comboBox2.Items.Add("Incomplete");
                comboBox2.Items.Add("Pending");
                comboBox2.Items.Add("Confirmed");
                comboBox2.Items.Add("Cancelled");

            } else if (comboBox1.Text == "Date")
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                pAYMENTBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;

                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[3].Value;

                if (value != null)
                {
                    textBox2.Text = value.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                this.Validate();
                pAYMENTBindingSource.EndEdit();
                pAYMENTTableAdapter.Update(avisDS.PAYMENT);

                pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
                MessageBox.Show($"Vehicle Return Updated with:\nBooking ID: {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text  = "🔍 Search Payment...";
            textBox2.Clear();

            // Reset ComboBoxes
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

            pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
        }


        //GENERATING AN INVOICE
        //Get Invoice Details
        private DataTable GetInvoiceData(int paymentID)
        {
            string conn =
            @"Data Source=146.230.177.46;Initial Catalog=GroupPmb3;User ID=GroupPmb3;Password=tt9d2h;TrustServerCertificate=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(conn))
            {
                string query = @"

                SELECT

                PAYMENT.PaymentID,
                PAYMENT.PaymentDate,
                PAYMENT.PaymentAmount,
                PAYMENT.PaymentType,
                PAYMENT.PaymentStatus,

                CUSTOMER.FullName,
                CUSTOMER.EmailAddress,
                CUSTOMER.ContactNumber,

                BOOKING.BookingID,
                BOOKING.[PickUp Date] AS PickUpDate,
                BOOKING.ExpectedReturnDate AS ReturnDate,

                VEHICLE.VehicleVinNo,
                VEHICLE.Make,
                VEHICLE.Model

                FROM PAYMENT

                INNER JOIN BOOKING
                ON PAYMENT.BookingID = BOOKING.BookingID

                INNER JOIN CUSTOMER
                ON BOOKING.CustomerID = CUSTOMER.CustomerID

                INNER JOIN VEHICLE
                ON BOOKING.VehicleVinNo = VEHICLE.VehicleVinNo

                WHERE PAYMENT.PaymentID = @PaymentID
                ";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@PaymentID", paymentID);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }

        }

        //Export to PDF
        private void ExportInvoicePdf(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No invoice data found.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "PDF Files|*.pdf";
            save.Title = "Save Invoice";
            save.FileName = "AVIS_Invoice.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document doc =
                    new Document(PageSize.A4, 40, 40, 40, 40);

                PdfWriter.GetInstance(doc,
                    new FileStream(save.FileName, FileMode.Create));

                doc.Open();

                DataRow row = dt.Rows[0];

                iTextSharp.text.Font titleFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD, 22);

                iTextSharp.text.Font headingFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD, 14);

                iTextSharp.text.Font normalFont =
                    FontFactory.GetFont(
                        FontFactory.HELVETICA, 12);

                Paragraph title =
                    new Paragraph(
                        "AVIS CAR RENTAL INVOICE",
                        titleFont);

                title.Alignment = Element.ALIGN_CENTER;

                doc.Add(title);

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph(
                    "Invoice Number: "
                    + row["PaymentID"], normalFont));

                doc.Add(new Paragraph(
                    "Invoice Date: "
                    + DateTime.Now.ToShortDateString(),
                    normalFont));

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph(
                    "CUSTOMER DETAILS",
                    headingFont));

                doc.Add(new Paragraph(
                    "Customer: "
                    + row["FullName"],
                    normalFont));

                doc.Add(new Paragraph(
                    "Email: "
                    + row["EmailAddress"],
                    normalFont));

                doc.Add(new Paragraph(
                    "Phone: "
                    + row["ContactNumber"],
                    normalFont));

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph(
                    "BOOKING DETAILS",
                    headingFont));

                doc.Add(new Paragraph(
                    "Booking ID: "
                    + row["BookingID"],
                    normalFont));

                doc.Add(new Paragraph(
                    "Pickup Date: "
                    + Convert.ToDateTime(
                        row["PickUpDate"]).ToShortDateString(),
                    normalFont));

                doc.Add(new Paragraph(
                    "Return Date: "
                    + Convert.ToDateTime(
                        row["ReturnDate"]).ToShortDateString(),
                    normalFont));

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph(
                    "VEHICLE DETAILS",
                    headingFont));

                doc.Add(new Paragraph(
                    "Vehicle VIN: "
                    + row["VehicleVinNo"],
                    normalFont));

                doc.Add(new Paragraph(
                    "Vehicle: "
                    + row["Make"] + " "
                    + row["Model"],
                    normalFont));

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph(
                    "PAYMENT DETAILS",
                    headingFont));

                doc.Add(new Paragraph(
                    "Payment Type: "
                    + row["PaymentType"],
                    normalFont));

                doc.Add(new Paragraph(
                    "Payment Status: "
                    + row["PaymentStatus"],
                    normalFont));

                doc.Add(new Paragraph(
                    "Amount Paid: R"
                    + row["PaymentAmount"],
                    normalFont));

                doc.Add(new Paragraph(" "));

                Paragraph thanks =
                    new Paragraph(
                        "Thank you for choosing AVIS!",
                        headingFont);

                thanks.Alignment = Element.ALIGN_CENTER;

                doc.Add(thanks);

                doc.Close();

                MessageBox.Show(
                    "Invoice PDF Generated Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(
                    save.FileName);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int paymentID = Convert.ToInt32(pAYMENTTableAdapter.GetLastPaymentID());
            DataTable dt = GetInvoiceData(paymentID);
            ExportInvoicePdf(dt);

            MessageBox.Show("Invoice Generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
