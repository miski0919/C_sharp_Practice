using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_program
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
            Double Weight, Height, BMI;
            if (double.TryParse(txtWeight.Text, out Weight) && double.TryParse(txtHeight.Text, out Height))
            {
                if (Weight <= 0 || Height < 0)
                {
                    BMI = Weight * 703 / (Height * Height);
                    lblDisplay.Text = BMI.ToString("f2");

                    if (BMI < 18.5)
                    {
                        MessageBox.Show("Under Weight");
                    }
                    else if (BMI <= 25)
                    {
                        MessageBox.Show("optional weight");
                    }
                    else
                    {
                        MessageBox.Show("OverWeight");
                    }
                }

                else
                {
                    MessageBox.Show("Weight and Height must be possive");
                }
            }
            else
            {
                MessageBox.Show("invailed input please enter numaric value");
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
            lblBMI.Text = string.Empty;

        }
    }
}
    



