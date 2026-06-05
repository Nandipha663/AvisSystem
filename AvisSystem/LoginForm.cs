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
            if (textBox1.Text == "AvisAdmin" && textBox2.Text == "2026")
            {
                this.Hide();
                AvisMenuForm menuform = new AvisMenuForm();
                menuform.Show();

            }else
            {
                if (textBox1.Text != "AvisAdmin" && textBox2.Text == "2026")
                {
                    MessageBox.Show("Invalid Username!");

                    textBox1.Text = "          Username";
                    textBox1.ForeColor = Color.Gray;
                    pictureBox3.Visible = true;

                    checkBox1.Checked = false;

                }
                else if (textBox1.Text == "AvisAdmin" && textBox2.Text != "2026")
                {
                    MessageBox.Show("Invalid Password!");
                    textBox2.UseSystemPasswordChar = false;
                    textBox2.Text = "          Password";
                    textBox2.ForeColor = Color.Gray;
                    pictureBox4.Visible = true;

                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");

                    textBox1.Text = "          Username";
                    textBox1.ForeColor = Color.Gray;
                    pictureBox3.Visible = true;

                    textBox2.UseSystemPasswordChar = false;
                    textBox2.Text = "          Password";
                    textBox2.ForeColor = Color.Gray;
                    pictureBox4.Visible = true;

                    checkBox1.Checked = false;
                }
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
            //textBox2.UseSystemPasswordChar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
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
            this.Hide();
            SignUpForm signupform = new SignUpForm();
            signupform.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
