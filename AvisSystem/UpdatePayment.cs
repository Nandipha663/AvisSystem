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
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox2.Click += panel1_Click;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /*public void LoadPayments()
        {
            pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
        }*/

        private void HighlightNewestPayment()
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
        private void UpdatePayment_Load(object sender, EventArgs e)
        {

            //LoadPayments();
            // TODO: This line of code loads data into the 'avisDS.PAYMENT' table. You can move, or remove it, as needed.
            this.pAYMENTTableAdapter.Fill(this.avisDS.PAYMENT);

            HighlightNewestPayment();

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
            
            HomeForm homeform = new HomeForm();
            homeform.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();

        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateRentalStatusToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewUpdateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehicles newUpdateVehicles = new UpdateVehicles();
            newUpdateVehicles.Show();
            this.Hide();


        }

        private void addPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void viewUpdateBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBranch newUpdateBranch = new UpdateBranch();
            newUpdateBranch.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvisMenuForm newAvisMenuForm = new AvisMenuForm();
            newAvisMenuForm.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void signUpEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmp = new ManageEmployee();
            manageEmp.Show();
            this.Hide();
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
            pAYMENTTableAdapter.FillByCustomerName(avisDS.PAYMENT, textBox1.Text);
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

            if (textBox1.Text == "🔍 Search Payments..." || textBox1.Text != "🔍 Search Payments...")
            {
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            try
            {
                this.Validate();
                pAYMENTBindingSource.EndEdit();
                pAYMENTTableAdapter.Update(avisDS.PAYMENT);

                pAYMENTTableAdapter.Fill(avisDS.PAYMENT);
                MessageBox.Show( "Paymnet record Updated with:\nBooking ID: {id}");
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
            textBox3.Clear();

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
        private DataTable GetInvoiceData(int PaymentID)
        {
            string conn =
            @"Data Source=146.230.177.46;Initial Catalog=GroupPmb3;User ID=GroupPmb3;Password=tt9d2h;TrustServerCertificate=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(conn))
            {
                string query = @"

                SELECT

                
                PAYMENT.PaymentID,
                PAYMENT.InvoiceID,
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
                BOOKING.PickUpBranchName As PickUpBranch,
                BOOKING.DropOffBranchName AS DropOffBranch,
                BOOKING.[Booking Date] AS BookingDate,

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
                    "@PaymentID", PaymentID);

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

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

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
                    + row["InvoiceID"], normalFont));

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

                doc.Add(new Paragraph(
                    "Booking Date: "
                    + Convert.ToDateTime(
                        row["BookingDate"]).ToShortDateString(),
                    normalFont));

                doc.Add(new Paragraph(
                    "Pick Up Branch: "
                    + row["PickUpBranch"],
                     normalFont));

                doc.Add(new Paragraph(
                    "Drop Off Branch: "
                    + row["DropOffBranch"],
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            int paymentID = Convert.ToInt32( pAYMENTTableAdapter.GetLastPaymentID());

            DataTable dt = GetInvoiceData(paymentID);

            ExportInvoicePdf(dt);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
