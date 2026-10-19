using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listBookingdetails.Items.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Fadlan geli magaca.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 18 || age > 90)
            {
                MessageBox.Show("Da'du waa inay u dhaxeyso 18 iyo 90.");
                return;
            }

            if (!int.TryParse(txtNights.Text, out int nights) || nights < 1 || nights > 30)
            {
                MessageBox.Show("Habeenadu waa inay u dhaxeyso 1 iyo 30.");
                return;
            }

            if (!int.TryParse(txtGuests.Text, out int guests) || guests < 1 || guests > 6)
            {
                MessageBox.Show("Martidu waa inay u dhaxeyso 1 iyo 6.");
                return;
            }

            string roomType = "";
            double rate = 0;
            int choice = radioStandard.Checked ? 1 : (radioNormal.Checked ? 2 : 3);

            switch (choice)
            {
                case 1: roomType = "Standard"; rate = 50; break;
                case 2: roomType = "Normal"; rate = 80; break;
                case 3: roomType = "Hiight"; rate = 130; break;
            }

            bool approved = true;
            string reason = "";

            if (roomType == "Standard" && guests > 2)
            {
                approved = false;
                reason = "Standard room waxay qaadaysaa ugu badnaan 2 qof.";
            }
            else if (roomType == "Hiight" && guests > 6)
            {
                approved = false;
                reason = "Hiight room waxay qaadaysaa ugu badnaan 6 qof.";
            }

            if (!approved)
            {
                listBookingdetails.Items.Add("Booking Status: REJECTED");
                listBookingdetails.Items.Add("Sababta: " + reason);
                return;
            }

            double roomCost = rate * nights;

            double nightDisc = 0;
            if (nights >= 5 && nights <= 9) nightDisc = roomCost * 0.05;
            else if (nights >= 10) nightDisc = roomCost * 0.12;

            double seniorDisc = (age >= 60) ? roomCost * 0.05 : 0;
            double breakfast = chkBreakfast.Checked ? (10 * guests * nights) : 0;
            double surcharge = (guests > 4) ? roomCost * 0.05 : 0;

            double finalCost = (roomCost - nightDisc - seniorDisc) + breakfast + surcharge;

            listBookingdetails.Items.Add("--- HOTEL BOOKING DETAILS ---");
            listBookingdetails.Items.Add("Guest Name: " + txtName.Text);
            listBookingdetails.Items.Add("Guest Age: " + age);
            listBookingdetails.Items.Add("Room Type: " + roomType);
            listBookingdetails.Items.Add("Nights: " + nights);
            listBookingdetails.Items.Add("Guests: " + guests);
            listBookingdetails.Items.Add("Room Cost: $" + roomCost);
            listBookingdetails.Items.Add("Night Discount: $" + nightDisc);
            listBookingdetails.Items.Add("Senior Discount: $" + seniorDisc);
            listBookingdetails.Items.Add("Breakfast: $" + breakfast);
            listBookingdetails.Items.Add("Service Surcharge: $" + surcharge);
            listBookingdetails.Items.Add("Final Cost: $" + finalCost);
            listBookingdetails.Items.Add("Booking Status: APPROVED");
        }
    }
}
