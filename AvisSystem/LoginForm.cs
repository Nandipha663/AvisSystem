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

           /* if (textBox1.Text == "AvisAdmin" && textBox2.Text == "2026")
            {
                MessageBox.Show("Login successful!");
            }
            else if (textBox1.Text != "AvisAdmin" && textBox2.Text == "2026")
            {
                MessageBox.Show("Invalid Username!");
                textBox1.Clear();

            }
            else if (textBox1.Text == "AvisAdmin" && textBox2.Text != "2026")
            {
                MessageBox.Show("Invalid Password!");
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                textBox1.Clear();
                textBox2.Clear();
            }*/
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
                    textBox1.Clear();
                    checkBox1.Checked = false;

                }
                else if (textBox1.Text == "AvisAdmin" && textBox2.Text != "2026")
                {
                    MessageBox.Show("Invalid Password!");
                    textBox2.Clear();
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                    textBox1.Clear();
                    textBox2.Clear();
                    checkBox1.Checked = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            checkBox1.Checked = false;
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
            textBox2.UseSystemPasswordChar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }
    }
}
