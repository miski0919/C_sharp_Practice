using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Akhri xogta ka timaada TextBoxes-ka dhanka bidix
            string customerName = txtCusName.Text;

            int age = 0;
            int rentalDays = 0;
            int experience = 0;

            // Hubinta in nambarro sax ah la geliyay
            if (!int.TryParse(txtCusAge.Text, out age) ||
                !int.TryParse(txtNumber.Text, out rentalDays) ||
                !int.TryParse(txtYears.Text, out experience))
            {
                MessageBox.Show("Fadlan meelaha nambarka looga baahan yahay geli nambarro sax ah!", "Digniin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vehicleType = txtVehicle.Text.Trim();

            // 2. Qiimaha Maalintii (Daily Rate)
            double dailyRate = 0;

            if (vehicleType.Equals("Economy", StringComparison.OrdinalIgnoreCase))
            {
                dailyRate = 35;
            }
            else if (vehicleType.Equals("SUV", StringComparison.OrdinalIgnoreCase))
            {
                dailyRate = 60;
            }
            else if (vehicleType.Equals("Luxury", StringComparison.OrdinalIgnoreCase))
            {
                dailyRate = 100;
            }

            // 3. Basic Cost
            double basicCost = dailyRate * rentalDays;

            // 4. Discount
            double discount = 0;
            if (rentalDays >= 7 && rentalDays <= 13)
            {
                discount = basicCost * 0.05;
            }
            else if (rentalDays >= 14)
            {
                discount = basicCost * 0.10;
            }

            // 5. Insurance (Yes ama No)
            double insurance = 0;
            string insuranceInput = txtInsurance.Text.Trim(); // TextBox-ka 6-aad

            if (insuranceInput.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                insurance = 15 * rentalDays;
            }
            else if (!insuranceInput.Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Fadlan Insurance Option-ka u qor Yes ama No!", "Digniin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Young Driver Surcharge
            double surcharge = 0;
            if (age >= 21 && age <= 24)
            {
                surcharge = (basicCost - discount) * 0.10;
            }

            // 7. Final Cost
            double finalCost = basicCost - discount + insurance + surcharge;

            // Muujinta Natiijooyinka Labels-ka dhanka midig
            lblCustomerName.Text = customerName;
            lblVehicleType.Text = vehicleType;
            lblBasicCost.Text = basicCost.ToString("0.00");
            lblInsurance.Text = insurance.ToString("0.00");
            lblSurcharge.Text = surcharge.ToString("0.00");
            lblFinalCost.Text = finalCost.ToString("0.00");
        }

        // Button Clear / Reset
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Nadiifinta TextBoxes-ka bidix
            txtCusName.Clear();
            txtCusAge.Clear();
            txtNumber.Clear();
            txtYears.Clear();
            txtVehicle.Clear();
            txtInsurance.Clear();

            // Nadiifinta Labels-ka midig
            lblCustomerName.Text = "";
            lblVehicleType.Text = "";
            lblBasicCost.Text = "";
            lblInsurance.Text = "";
            lblStatus.Text = "";
            lblFinalCost.Text = "";
        }

        // Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

