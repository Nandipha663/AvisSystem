using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AvisSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;

            button1.Enabled = false;
            button1.BackColor = Color.LightCoral;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Username")
            {
                textBox1.Text = "";
                pictureBox2.Visible = false;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "          Username";
                pictureBox2.Visible = true;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "Email")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                pictureBox3.Visible = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "          Email";
                textBox2.ForeColor = Color.Gray;
                pictureBox3.Visible = true;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                pictureBox4.Visible = false;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "          Password";
                textBox3.ForeColor = Color.Gray;
                pictureBox4.Visible = true;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "Confirm Password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                pictureBox5.Visible = false;
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "          Confirm Password";
                textBox4.ForeColor = Color.Gray;
                pictureBox5.Visible = true;
                textBox4.UseSystemPasswordChar = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (textBox3.Text.Trim() != "Password")
                {
                    textBox3.UseSystemPasswordChar = false;
                }
            }
            else
            {
                if (textBox3.Text.Trim() != "Password")
                {
                    textBox3.UseSystemPasswordChar = true;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (textBox4.Text.Trim() != "Confirm Password")
                {
                    textBox4.UseSystemPasswordChar = false;
                }
            }
            else
            {
                if (textBox4.Text.Trim() != "Confirm Password")
                {
                    textBox4.UseSystemPasswordChar = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ValidateRegistration();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ValidateRegistration();
            string password = textBox3.Text;

            //Ignore the placeholder text
            if (password == "Password")
            {
                label5.Text = "  ";
                return;
            }

            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasLower = Regex.IsMatch(password, "[a-z]");
            bool hasDigit = Regex.IsMatch(password, "[0-9]");
            bool hasLength = password.Length >= 8;

            if (hasUpper && hasLower && hasDigit && hasLength)
            {
                label5.Text = "Strong Password ✔";
                label5.ForeColor = Color.Green;
            }
            else
            {
                label5.Text = "Password must be 8+ chars,atleast one uppercase,one lowercase,one number";
                label5.ForeColor = Color.Red;
            }
        }

        private void ValidateRegistration()
        {
            if (checkBox1.Checked &&

                !string.IsNullOrWhiteSpace(textBox1.Text) &&
                textBox1.Text != "Username" &&

                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                textBox2.Text != "Email" &&

                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                textBox3.Text != "Password" &&

                !string.IsNullOrWhiteSpace(textBox4.Text) &&
                textBox4.Text != "Confirm Password" &&

                label5.Text == "Strong Password ✔")
            {
                button1.Enabled = true;
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ValidateRegistration();
            if (button1.Enabled == false)
            {
                MessageBox.Show("Please agree to the terms and conditions to proceed with registration.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (button1.Enabled == true)
            {
                //Check Username
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "          Username")
                {
                    MessageBox.Show("Please Enter a Valid Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }

                //Check Password
                if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "          Password" || label5.Text == "Password must be 8+ chars,atleast one uppercase,one lowercase,one number")
                {
                    MessageBox.Show("Please Enter a valid Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }

                //Check Email
                if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "          Email")
                {
                    MessageBox.Show("Please Enter a Valid Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }

                if (textBox4.Text == textBox3.Text)
                {
                    //Also the add the conditions where all textboxes are filled and the password is strong before allowing the registration to be successful
                    //WTD:Add the registration information to the employees table in the database


                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginform = new LoginForm();
                    loginform.Show();
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                    return;

                }

                //Check Confirm Password
                if (string.IsNullOrWhiteSpace(textBox4.Text) || textBox4.Text == "          Confirm Password")
                {
                    MessageBox.Show("Please enter your full name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;


            // Username
            if (textBox1.Text != "Username")
            {
                textBox1.Text = "          Username";
                textBox1.ForeColor = Color.Gray;
                pictureBox2.Visible = true;
            }

            // Email
            if (textBox2.Text != "Email")
            {
                textBox2.Text = "          Email";
                textBox2.ForeColor = Color.Gray;
                pictureBox3.Visible = true;
            }

            // Password
            if (textBox3.Text != "Password")
            {
                textBox3.UseSystemPasswordChar = false;
                textBox3.Text = "          Password";
                textBox3.ForeColor = Color.Gray;
                pictureBox4.Visible = true;
            }

            //Confirm Password
            if (textBox4.Text != "Confirm Password")
            {
                textBox4.UseSystemPasswordChar = false;
                textBox4.Text = "          Confirm Password";
                textBox4.ForeColor = Color.Gray;
                pictureBox5.Visible = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateRegistration();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateRegistration();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateRegistration();
        }
    }
}
