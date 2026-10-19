using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                decimal hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                decimal grossPay = 0.0m;

                if (hoursWorked > 40)
                {
                    // Saacadaha caadiga ah (40) + Saacadaha dheeraadka ah
                    decimal basePay = 40 * hourlyPayRate;
                    decimal overtimeHours = hoursWorked - 40;
                    decimal overtimePay = overtimeHours * (hourlyPayRate * 1.5m);

                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // Marka saacaduhu 40 ama ka yar yihiin
                    grossPay = hoursWorked * hourlyPayRate;
                }

                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception)
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
