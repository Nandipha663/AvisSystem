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
    public partial class TermsandConditions : Form
    {
        public TermsandConditions()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.Enabled = false;
                button1.BackColor = Color.LightCoral;
            }


        }

        private void TermsandConditions_Load(object sender, EventArgs e)
        {

            button1.Enabled = false;
            

            richTextBox1.Rtf = @"{\rtf1\ansi

\b Driver Requirements\b0\par
The renter must hold a valid driver’s license.\par
The driver must be of legal driving age (usually 18–25 depending on category).\par
The driver must present identification and valid documentation before vehicle release.\par

\par
\b Vehicle Usage\b0\par
The vehicle must only be used for lawful purposes.\par
The vehicle must not be used for racing, towing, or illegal activities.\par
Off-road use is not permitted unless explicitly allowed.\par
The vehicle must not be driven under the influence of alcohol or drugs.\par

\par
\b Booking & Payment\b0\par
All bookings must be confirmed before vehicle collection.\par
Full or partial payment may be required before rental begins.\par
Additional charges may apply for extra services or late returns.\par
The company reserves the right to cancel unpaid bookings.\par

\par
\b Fuel Policy\b0\par
Vehicles must be returned with the same fuel level as collected.\par
If not, refueling charges will be applied.\par

\par
\b Vehicle Condition\b0\par
The renter is responsible for keeping the vehicle in good condition.\par
Any damage caused during the rental period will be charged to the renter.\par
Pre-existing damage must be reported before departure.\par

\par
\b Insurance & Liability\b0\par
Basic insurance may be included depending on booking type.\par
The renter may be liable for damages not covered by insurance.\par
Theft or loss due to negligence is the renter’s responsibility.\par

\par
\b Mileage Policy\b0\par
Mileage limits may apply depending on rental agreement.\par
Excess mileage will incur additional charges.\par

\par
\b Late Returns\b0\par
Late returns may result in additional hourly or daily charges.\par
Failure to return the vehicle may be treated as unauthorized use.\par

\par
\b Cancellations\b0\par
Cancellation policies may apply depending on booking type.\par
Refunds may not be available for last-minute cancellations.\par

\par
\b Traffic Fines & Violations\b0\par
The renter is responsible for all traffic fines and penalties during the rental period.\par
Administrative fees may apply for processing violations.\par

\par
\b Company Rights\b0\par
The company reserves the right to refuse service.\par
The company may terminate a rental if terms are violated.\par
The company may track vehicles for safety and recovery purposes.\par

\par
\b Acceptance\b0\par
By confirming a booking, the renter agrees to all terms and conditions listed above.\par
}
";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CanFocus && button1.Enabled)
            {
                SignUpForm signUp = new SignUpForm();
                signUp.Show();
                this.Hide();
            }
        }
    }
}
