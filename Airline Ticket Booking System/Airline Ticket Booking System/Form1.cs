using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age, numberOfTickets;
            double baggageWeight;
            double ticketPrice = 300.00;

            // 1. Validation for Age
            if (!int.TryParse(txtAge.Text, out age) || age < 1 || age > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validation for Tickets
            if (!int.TryParse(txtTickets.Text, out numberOfTickets) || numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validation for Baggage Weight
            if (!double.TryParse(txtWeight.Text, out baggageWeight) || baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage weight cannot be negative and cannot exceed 50 kg.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string travelClass = "Normal Class";
            if (radFirstClass.Checked) travelClass = "First Class";
            else if (radBusinessClass.Checked) travelClass = "Business Class";

            // Clear previous output
            listDisplayOutput.Items.Clear();

            // 4. Check First Class Rule for Under 12
            if (age < 12 && radFirstClass.Checked)
            {
                listDisplayOutput.Items.Add("--- AIRLINE BOOKING DETAILS ---");
                listDisplayOutput.Items.Add($"Passenger Name: {txtName.Text}");
                listDisplayOutput.Items.Add($"Passenger Age: {age}");
                listDisplayOutput.Items.Add($"Travel Class: {travelClass}");
                listDisplayOutput.Items.Add($"Number of Tickets: {numberOfTickets}");
                listDisplayOutput.Items.Add($"Baggage Weight: {baggageWeight} kg");
                listDisplayOutput.Items.Add("");
                listDisplayOutput.Items.Add("Booking Status: REJECTED");
                listDisplayOutput.Items.Add("Reason: Passengers below 12 years cannot book First Class.");
                return;
            }

            // 5. Cost Calculations
            double basicTicketCost = ticketPrice * numberOfTickets;

            double ticketDiscountRate = 0;
            if (numberOfTickets == 3 || numberOfTickets == 4)
            {
                ticketDiscountRate = 0.05;
            }
            else if (numberOfTickets == 5)
            {
                ticketDiscountRate = 0.10;
            }
            double ticketDiscount = basicTicketCost * ticketDiscountRate;

            double ageDiscountRate = 0;
            if (age < 12)
            {
                ageDiscountRate = 0.20;
            }
            else if (age >= 60)
            {
                ageDiscountRate = 0.10;
            }
            double ageDiscount = basicTicketCost * ageDiscountRate;

            double insuranceCost = 0;
            if (chkInsurance.Checked)
            {
                insuranceCost = 25.00 * numberOfTickets;
            }

            double excessBaggageCost = 0;
            if (baggageWeight > 20)
            {
                excessBaggageCost = (baggageWeight - 20) * 10.00;
            }

            double finalCost = (basicTicketCost - ticketDiscount - ageDiscount) + insuranceCost + excessBaggageCost;

            // 6. Display Output
            listDisplayOutput.Items.Add("AIRLINE BOOKING DETAILS");
            listDisplayOutput.Items.Add("------------------------------------");
            listDisplayOutput.Items.Add($"Passenger Name: {txtName.Text}");
            listDisplayOutput.Items.Add($"Passenger Age: {age}");
            listDisplayOutput.Items.Add($"Travel Class: {travelClass}");
            listDisplayOutput.Items.Add($"Number of Tickets: {numberOfTickets}");
            listDisplayOutput.Items.Add($"Baggage Weight: {baggageWeight} kg");
            listDisplayOutput.Items.Add("");
            listDisplayOutput.Items.Add($"Ticket Price: ${ticketPrice:F2}");
            listDisplayOutput.Items.Add($"Basic Ticket Cost: ${basicTicketCost:F2}");
            listDisplayOutput.Items.Add($"Ticket Discount: ${ticketDiscount:F2}");
            listDisplayOutput.Items.Add($"Age Discount: ${ageDiscount:F2}");
            listDisplayOutput.Items.Add($"Insurance Cost: ${insuranceCost:F2}");
            listDisplayOutput.Items.Add($"Excess Baggage Cost: ${excessBaggageCost:F2}");
            listDisplayOutput.Items.Add("------------------------------------");
            listDisplayOutput.Items.Add($"Final Ticket Cost: ${finalCost:F2}");
            listDisplayOutput.Items.Add("");
            listDisplayOutput.Items.Add("Booking Status: APPROVED");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtName.Clear();
            txtTickets.Clear();
            txtWeight.Clear();
            listDisplayOutput.Items.Clear();
            chkInsurance.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
