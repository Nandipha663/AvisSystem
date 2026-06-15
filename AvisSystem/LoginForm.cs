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
    public partial class LoginForm : Form
    {

        int failedAttempts = 0;

        DateTime? lockoutEndTime = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (lockoutEndTime != null && DateTime.Now < lockoutEndTime)
                {
                    TimeSpan remaining =
                        lockoutEndTime.Value - DateTime.Now;

                    MessageBox.Show(
                    $"Too many failed attempts.\nTry again in {remaining.Seconds} second(s).",
                    "Account Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    return;
                }
                AvisDSTableAdapters.EMPLOYEETableAdapter empTA =
                    new AvisDSTableAdapters.EMPLOYEETableAdapter();

                AvisDS.EMPLOYEEDataTable dt =
                    new AvisDS.EMPLOYEEDataTable();

                empTA.FillByLogin(
                    dt,
                    textBox1.Text,
                    textBox2.Text
                );

                if (dt.Rows.Count > 0)
                {
                    failedAttempts = 0;

                    AvisMenuForm menu = new AvisMenuForm();
                    menu.Show();

                    MessageBox.Show("WELCOME!\nLogin Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {
                    failedAttempts++;

                    MessageBox.Show(
                    $"Invalid Username or Password\nAttempt {failedAttempts}/3",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    if (failedAttempts >= 3)
                    {
                        lblCountdown.Visible = true;

                        lockoutEndTime = DateTime.Now.AddMinutes(1);

                        button2.Enabled = false;

                        textBox1.Enabled = false;

                        textBox2.Enabled = false;

                        timer1.Start();

                        MessageBox.Show(
                        "Too many failed attempts.\nLogin disabled for 1 minute.",
                        "Account Locked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            checkBox1.Checked = false;

            // Username
            if (textBox1.Text != "          Username")
            {
                textBox1.Text = "          Username";
                textBox1.ForeColor = Color.Gray;
                pictureBox3.Visible = true;
            }

            // Password
            if (textBox2.Text != "          Password")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "          Password";
                textBox2.ForeColor = Color.Gray;
                pictureBox4.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            homeform.Show();
            this.Hide();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // remove placeholder text if it exists
            if (textBox1.Text == "          Username")
            {
                textBox1.Text = "";
                pictureBox3.Visible = false;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if the textbox is empty, show the placeholder text again
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "          Username";
                pictureBox3.Visible = true;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "          Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                pictureBox4.Visible = false;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "          Password";
                textBox2.ForeColor = Color.Gray;
                pictureBox4.Visible = true;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SignUpForm signupform = new SignUpForm();
            signupform.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lockoutEndTime != null)
            {
                TimeSpan remaining =
                    lockoutEndTime.Value - DateTime.Now;

                // SHOW COUNTDOWN
                lblCountdown.Text =
                    $"Login locked. Try again in {remaining.Seconds} second(s).";

                lblCountdown.Visible = true;

                // UNLOCK WHEN TIME FINISHES
                if (DateTime.Now >= lockoutEndTime)
                {
                    button2.Enabled = true;

                    textBox1.Enabled = true;

                    textBox2.Enabled = true;

                    failedAttempts = 0;

                    timer1.Stop();

                    lblCountdown.Visible = false;

                    MessageBox.Show(
                    "You may now try logging in again.",
                    "Login Unlocked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }
    }
}
