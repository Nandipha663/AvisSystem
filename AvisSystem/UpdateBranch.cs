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
    public partial class UpdateBranch : Form
    {
        public UpdateBranch()
        {
            InitializeComponent();
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            pictureBox1.Click += panel1_Click;
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "🔍 Search branch...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "🔍 Search branch...";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBranch_Load(object sender, EventArgs e)
        {
            viewUpdateBranchesToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Location");
            comboBox1.SelectedIndex = -1;

            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = true;

            dataGridView1.ClearSelection();
            this.branchTableAdapter1.Fill(this.avisDS1.BRANCH);

        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch newAddBranch = new AddBranch();
            this.Hide();
            newAddBranch.Show();
        }

        private void addClaimToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment newAddPayment = new AddPayment();
            this.Hide();
            newAddPayment.Show();
        }

        private void viewUpdatePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment newUpdatePayment = new UpdatePayment();
            this.Hide();
            newUpdatePayment.Show();
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

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addBookingsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                bRANCHBindingSource.RemoveFilter();

                // Reset ComboBoxes
                comboBox1.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Enabled = false;

                MessageBox.Show("Filters reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting filters: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          //branchTableAdapter1.FillByBranchName(this.avisDS1BRANCH, textBox1.Text);
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text != "🔍 Search branch...")
            {
                try
                {
                    string txt = textBox1.Text.Replace("'", "''");
                    this.bRANCHBindingSource.Filter = $"BranchName LIKE '%{txt}%'";
                }
                catch
                {
                    this.bRANCHBindingSource.Filter = null;
                  //this.branchTableAdapter1.Fill(this.avisDS1.BRANCH);
                }
            }
            else
            {
                this.bRANCHBindingSource.Filter = null;
               //his.branchTableAdapter1.Fill(this.avisDS1.BRANCH);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Select filter type and value");
                    return;
                }

                string column = "";
                string value = comboBox2.Text.Trim().Replace("'", "''");

                if (comboBox1.Text == "Location")
                    column = "Location";

                if (column == "")
                    return;

                // Applies the filter directly to the Branch dataset
                bRANCHBindingSource.Filter = $"{column} = '{value}'";
            }catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search branch...";
            textBox1.ForeColor = Color.Gray;

            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            comboBox2.Text = "";

            if (comboBox1.SelectedItem == null)
            {
                comboBox2.Enabled = false;
                return;
            }

            if (comboBox1.Text == "Location")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("Durban CBD, KwaZulu-Natal");
                comboBox2.Items.Add("Umhlanga Ridge, KwaZulu-Natal");
                comboBox2.Items.Add("Sandton, Gauteng");
                comboBox2.Items.Add("Cape Town International, WC");
                comboBox2.Items.Add("Menlyn, Pretoria, Gauteng");
                comboBox2.Items.Add("Pharazyn Way, Oribi Airport, Oribi Village");
                comboBox2.Items.Add("Airport Boulevard, East London, Eastern Cape");
                comboBox2.Items.Add("Oxford Street, East London, Eastern Cape");
                comboBox2.Items.Add("Da Gama Road, Jeffreys Bay, Eastern Cape");
                comboBox2.Items.Add("Cathcart Street, King Williamstown, Eastern Cape");
                comboBox2.Items.Add("Mthatha Airport, Mthatha, Eastern Cape");
                comboBox2.Items.Add("Pascoe Crescent, Port Alfred, Eastern Cape");
                comboBox2.Items.Add("Port Elizabeth Airport, Gqeberha, Eastern Cape");
                comboBox2.Items.Add("Greenacres, Gqeberha, Eastern Cape");
                comboBox2.Items.Add("Muller Street, Bethlehem, Free State");
                comboBox2.Items.Add("Bloemfontein Airport, Bloemfontein, Free State");
                comboBox2.Items.Add("Zastron Street, Bloemfontein, Free State");
                comboBox2.Items.Add("Warden Street, Harrismith, Free State");
                comboBox2.Items.Add("Nico Smith Street, Welkom, Free State");
                comboBox2.Items.Add("John Vorster Drive, Centurion, Gauteng");
                comboBox2.Items.Add("Isando Road, Isando, Gauteng");
                comboBox2.Items.Add("Ontdekkers Road, Krugersdorp, Gauteng");
                comboBox2.Items.Add("Lanseria Airport, Lanseria, Gauteng");
                comboBox2.Items.Add("Atterbury Road, Menlyn, Pretoria, Gauteng");
                comboBox2.Items.Add("Mondeor, Johannesburg, Gauteng");
                comboBox2.Items.Add("Montana Park, Pretoria, Gauteng");
                comboBox2.Items.Add("OR Tambo International Airport, Kempton Park, Gauteng");
                comboBox2.Items.Add("Schoeman Street, Pretoria, Gauteng");
                comboBox2.Items.Add("Chris Hani Road, Soweto, Gauteng");
                comboBox2.Items.Add("Grand Central Airport, Midrand, Gauteng");
                comboBox2.Items.Add("Rivonia Road, Sandton, Gauteng");
                comboBox2.Items.Add("Sunninghill, Johannesburg, Gauteng");
                comboBox2.Items.Add("Voortrekker Road, Vereeniging, Gauteng");
                comboBox2.Items.Add("Beach Road, Amanzimtoti, KwaZulu-Natal");
                comboBox2.Items.Add("Ballito Drive, Ballito, KwaZulu-Natal");
                comboBox2.Items.Add("Union Street, Empangeni, KwaZulu-Natal");
                comboBox2.Items.Add("King Shaka Airport, La Mercy, KwaZulu-Natal");
                comboBox2.Items.Add("Hope Street, Kokstad, KwaZulu-Natal");
                comboBox2.Items.Add("Murchison Street, Ladysmith, KwaZulu-Natal");
                comboBox2.Items.Add("Margate Airport, Margate, KwaZulu-Natal");
                comboBox2.Items.Add("Allen Street, Newcastle, KwaZulu-Natal");
                comboBox2.Items.Add("Oribi Airport, Pietermaritzburg, KwaZulu-Natal");
                comboBox2.Items.Add("Kings Road, Pinetown, KwaZulu-Natal");
                comboBox2.Items.Add("Richards Bay Airport, Richards Bay, KwaZulu-Natal");
                comboBox2.Items.Add("Ulundi Airport, Ulundi, KwaZulu-Natal");
                comboBox2.Items.Add("Mark Street, Vryheid, KwaZulu-Natal");
                comboBox2.Items.Add("Eastgate Airport, Hoedspruit, Limpopo");
                comboBox2.Items.Add("Chris Hani Street, Lephalale, Limpopo");
                comboBox2.Items.Add("Musina Central, Musina, Limpopo");
                comboBox2.Items.Add("Phalaborwa Airport, Phalaborwa, Limpopo");
                comboBox2.Items.Add("Polokwane Airport, Polokwane, Limpopo");
                comboBox2.Items.Add("Thohoyandou, Limpopo");
                comboBox2.Items.Add("Agatha Street, Tzaneen, Limpopo");
                comboBox2.Items.Add("Mandela Street, Emalahleni, Mpumalanga");
                comboBox2.Items.Add("Kruger Mpumalanga Airport, Nelspruit, Mpumalanga");
                comboBox2.Items.Add("Nelspruit CBD, Nelspruit, Mpumalanga");
                comboBox2.Items.Add("Secunda, Mpumalanga");
                comboBox2.Items.Add("Skukuza Airport, Kruger National Park, Mpumalanga");
                comboBox2.Items.Add("Skukuza Rest Camp, Kruger National Park, Mpumalanga");
                comboBox2.Items.Add("Sishen Office Park, Kathu, Northern Cape");
                comboBox2.Items.Add("Kimberley Airport, Kimberley, Northern Cape");
                comboBox2.Items.Add("Upington Airport, Upington, Northern Cape");
                comboBox2.Items.Add("4069 Newton Street, Mmabatho, North West");
                comboBox2.Items.Add("Cnr Parys And Holthausen, Potchefstroom, North West");
                comboBox2.Items.Add("56a Von Wielligh Street, Rustenburg, North West");
                comboBox2.Items.Add("Market Street, Vryburg, North West");
                comboBox2.Items.Add("Airport Industria, Cape Town, Western Cape");
                comboBox2.Items.Add("Cape Town International Airport, Western Cape");
                comboBox2.Items.Add("123 Strand Street, Cape Town, Western Cape");
                comboBox2.Items.Add("George Airport, George, Western Cape");
                comboBox2.Items.Add("York Street, George, Western Cape");
                comboBox2.Items.Add("Church Street, Mossel Bay, Western Cape");
                comboBox2.Items.Add("Main Street, Plettenberg Bay, Western Cape");
                comboBox2.Items.Add("Bird Street, Stellenbosch, Western Cape");
                comboBox2.Items.Add("Strand, Western Cape");
                comboBox2.Items.Add("Wynberg, Cape Town, Western Cape");
                comboBox2.Items.Add("Miriam Makeba Street, Johannesburg, Gauteng");
                comboBox2.Items.Add("Bullion Boulevard, Richards Bay, KwaZulu-Natal");
                comboBox2.Items.Add("Bergville Road, Winterton, KwaZulu-Natal");
                comboBox2.Items.Add("Mandela Drive, Witbank, Mpumalanga");
                comboBox2.Items.Add("Somerset Street, Grahamstown, Eastern Cape");
                comboBox2.Items.Add("Joe Slovo Road, Klerksdorp, North West");
                comboBox2.Items.Add("Main Road, Knysna, Western Cape");
            }
            else
            {
                comboBox2.Items.Add("Select filter first");
                comboBox2.Enabled = false;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                string location = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = location;
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            AIHelpFeature ai = new AIHelpFeature();
            ai.Show();
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "🔍 Search branch...";
            textBox2.Clear();

            // Reset ComboBoxes
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Enabled = false;

            branchTableAdapter1.Fill(avisDS1.BRANCH);
        }
        private void viewUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee newManageEmployee = new ManageEmployee();
            this.Hide();
            newManageEmployee.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm newSignUpForm = new SignUpForm();
            this.Hide();
            newSignUpForm.Show();
        }
    }
    
}
