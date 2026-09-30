using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Tax_andTotal
{
    public partial class taxtfood1 : Form
    {
        public taxtfood1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblenterfood_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Declaring variables
            string food1, food2;
            double foodPrice1, foodPrice2;
            double tax, totalAmount;

            // 2. Initialisation value
            food1 = lblenterfood.Text;
            food2 = label2.Text;

            foodPrice1 = double.Parse(txtprice1.Text);
            foodPrice2 = double.Parse(txtprice2.Text);


            //calculation 
            double subtotal = foodPrice1 + foodPrice2;

            //tax
            tax = subtotal * 0.07;

            //total amount 
            totalAmount = subtotal + tax;

            // Display Total salary
            tlblsalary.Text = tax.ToString("F2");

            // Display Total Amount
            lbltotal.Text = totalAmount.ToString("F2");
        }
    }
}
