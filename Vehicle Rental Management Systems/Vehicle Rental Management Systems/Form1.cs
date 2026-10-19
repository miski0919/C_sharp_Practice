using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();

            string customerName = txtname.Text.Trim();
            int age, rentalDays, drivingExp;

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtage.Text, out age) || age < 18 || age > 80)
            {
                MessageBox.Show("Customer age must be between 18 and 80 years.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtdays.Text, out rentalDays) || rentalDays < 1 || rentalDays > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30 days.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtexperience.Text, out drivingExp) || drivingExp < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vehicle Type & Daily Rate
            string vehicleType = "";
            double dailyRate = 0;

            if (rdeconomy.Checked)
            {
                vehicleType = "Economy";
                dailyRate = 35.00;
            }
            else if (rdsuv.Checked)
            {
                vehicleType = "SUV";
                dailyRate = 60.00;
            }
            else if (rdoluxury.Checked)
            {
                vehicleType = "Luxury";
                dailyRate = 100.00;
            }

            // Eligibility Validation (bool flag logic)
            bool isEligible = true;
            string rejectionReason = "";

            if (age < 21)
            {
                isEligible = false;
                rejectionReason = "Customers below 21 years are not eligible.";
            }
            else if (drivingExp < 1)
            {
                isEligible = false;
                rejectionReason = "Customers must have at least 1 year of driving experience.";
            }
            else if (vehicleType == "Luxury" && (age < 25 || drivingExp < 3))
            {
                isEligible = false;
                rejectionReason = "Luxury vehicles require at least 25 years of age and 3 years of driving experience.";
            }

            if (!isEligible)
            {
                lstresult.Items.Add("Rental Details");
                lstresult.Items.Add("----------------------------------------");
                lstresult.Items.Add($"Customer Name : {customerName}");
                lstresult.Items.Add($"Vehicle Type : {vehicleType}");
                lstresult.Items.Add("");
                lstresult.Items.Add("Rental Status : REJECTED");
                lstresult.Items.Add($"Reason : {rejectionReason}");
                return;
            }

            // Calculations
            double basicRentalCost = dailyRate * rentalDays;

            // Discount Rules
            double discountRate = 0;
            if (rentalDays >= 7 && rentalDays <= 13)
            {
                discountRate = 0.05; // 5% discount
            }
            else if (rentalDays >= 14)
            {
                discountRate = 0.10; // 10% discount
            }
            double discount = basicRentalCost * discountRate;

            // Insurance Cost ($15 per day)
            double insuranceCost = 0;
            if (chkinsurance.Checked)
            {
                insuranceCost = 15.00 * rentalDays;
            }

            // Young Driver Surcharge (Age 21-24: add 10% surcharge)
            double youngDriverSurcharge = 0;
            if (age >= 21 && age <= 24)
            {
                youngDriverSurcharge = basicRentalCost * 0.10;
            }

            // Final Rental Cost Calculation
            double finalRentalCost = (basicRentalCost - discount) + insuranceCost + youngDriverSurcharge;

            // Display Results in lstresults ListBox
            lstresult.Items.Add("Rental Details");
            lstresult.Items.Add("----------------------------------------");
            lstresult.Items.Add($"Customer Name : {customerName}");
            lstresult.Items.Add($"Customer Age : {age}");
            lstresult.Items.Add($"Driving Experience : {drivingExp} years");
            lstresult.Items.Add($"Vehicle Type : {vehicleType}");
            lstresult.Items.Add($"Daily Rate : ${dailyRate:F2}");
            lstresult.Items.Add($"Rental Days : {rentalDays}");
            lstresult.Items.Add($"Basic Rental Cost : ${basicRentalCost:F2}");
            lstresult.Items.Add($"Discount : ${discount:F2}");
            lstresult.Items.Add($"Insurance Cost : ${insuranceCost:F2}");
            lstresult.Items.Add($"Young Driver Surcharge : ${youngDriverSurcharge:F2}");
            lstresult.Items.Add("----------------------------------------");
            lstresult.Items.Add($"Final Rental Cost : ${finalRentalCost:F2}");
            lstresult.Items.Add("");
            lstresult.Items.Add("Rental Status : APPROVED");
        }
    }
}
