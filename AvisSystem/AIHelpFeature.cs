using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisSystem
{
    public partial class AIHelpFeature : Form
    {
        public AIHelpFeature()
        {
            InitializeComponent();
        }

        private void AIHelpFeature_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;

            AddMessage("Hello 👋 How can I help you today?", false);
        }
        private static readonly HttpClient client = new HttpClient();

        private async Task<string> GetGeminiResponse(string prompt)
        {
            // Fake typing delay
            await Task.Delay(1500);

            prompt = prompt.ToLower();

            // Booking responses
            if (prompt.Contains("booking"))
            {
                return "To create a booking, open the add booking Form and enter booking details for the customer and click save booking to add booking details to the database.";
            }

            // Payment responses
            if (prompt.Contains("payment"))
            {
                return "To make payment, open the add payment section and enter the payment details for the customer and click save payment to add payment details to the database.";
            }

            // Vehicle responses
            if (prompt.Contains("vehicle"))
            {
                return "To add vehicle details, open add vehicle section and enter vehicle details and click save to save the vehicle records to the database.";
            }

            // Customer responses
            if (prompt.Contains("customer"))
            {
                return "Customers can be added, updated, or searched in the Customer section.";
            }

            //Invoice responses
            if (prompt.Contains("invoice"))
            {
                return "Click Generate Invoice button to generate an invoice after the payment.";
            }

            //branch responses
            if (prompt.Contains("branch"))
            {
                return "Branch information can be viewed in the Branch Management section but cannot be modified.";
            }

            // Greeting responses
            if (prompt.Contains("hello") || prompt.Contains("hi"))
            {
                return "Hello 👋 How can I assist you with the Avis Rental System today?";
            }

            // Help responses
            if (prompt.Contains("help"))
            {
                return "I can help you with bookings, payments, customers, and vehicles.";
            }

            // Default response
            return "I'm here to help with the Avis Rental System.";
        }



        //Add Message to the chat
        private Panel AddMessage(string text, bool isUser)
        {
            // MAIN ROW PANEL
            Panel row = new Panel();
            row.Width = flowLayoutPanel1.Width - 25;
            row.AutoSize = true;
            row.Padding = new Padding(5);

            // PROFILE PICTURE
            PictureBox pic = new PictureBox();
            pic.Size = new Size(40, 40);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set profile images
            if (isUser)
            {
                pic.Image = Properties.Resources.usericon;
            }
            else
            {
                pic.Image = Properties.Resources.aiicon;
            }

            // MESSAGE BUBBLE
            Panel bubble = new Panel();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(300, 0);
            bubble.Padding = new Padding(10);
            bubble.BackColor = isUser ? Color.LightSkyBlue : Color.LightGray;

            // MESSAGE TEXT
            Label lblMessage = new Label();
            lblMessage.Text = text;
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size(250, 0);
            lblMessage.Font = new Font("Segoe UI", 10);

            // TIME LABEL
            Label lblTime = new Label();
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 7);
            lblTime.ForeColor = Color.DarkGray;
            lblTime.Dock = DockStyle.Bottom;

            // Add labels to bubble
            bubble.Controls.Add(lblMessage);
            bubble.Controls.Add(lblTime);

            // USER MESSAGE (RIGHT SIDE)
            if (isUser)
            {
                pic.Location = new Point(row.Width - 50, 5);

                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                bubble.Location = new Point(row.Width - 320, 5);
            }
            else
            {
                pic.Location = new Point(5, 5);

                bubble.Location = new Point(55, 5);
            }

            // Add controls to row
            row.Controls.Add(pic);
            row.Controls.Add(bubble);

            // Add row to chat panel
            flowLayoutPanel1.Controls.Add(row);

            // Scroll to newest message
            flowLayoutPanel1.ScrollControlIntoView(row);

            return row;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string userText = textBox1.Text;

            if (string.IsNullOrWhiteSpace(userText))
                return;

            //Show user message
            AddMessage(userText, true);

            textBox1.Clear();

            // typing indicator
            Panel typingBubble = AddMessage("AI is typing...", false);

            //Get AI response
            string aiResponse = await GetGeminiResponse(userText);

            // 4. Remove typing message (optional improvement later)
            flowLayoutPanel1.Controls.Remove(typingBubble);
            typingBubble.Dispose();

            // 5. Show AI message
            AddMessage(aiResponse, false);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Type your question here...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Type your question here...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

           /* if (AIHelpFeature != null && !AIHelpFeature.IsDisposed)
            {
                AIHelpFeature.ClearChat();
            }*/

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newAddCustomer = new AddCustomer();
            newAddCustomer.Show();
            this.Hide();
        }

        private void processPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //When a user log out,clear the chat
        public void ClearChat()
        {
            flowLayoutPanel1.Controls.Clear();

            AddMessage("Hello 👋 How can I help you today?", false);
        }
    }
}

