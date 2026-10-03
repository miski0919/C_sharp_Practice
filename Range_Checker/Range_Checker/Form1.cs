using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chechButton_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(inputTextBox.Text, out number))
            {
                if (number >= 1 && number <= 10)
                {
                    outputLabel.Text = "Valid entry! The number is within 1 to 10.";
                }
                else
                {
                    outputLabel.Text = "Invalid entry! Please enter a number between 1 and 10.";
                }
            }
            else
            {
                outputLabel.Text = "Fadlan gali number sax eh integer.";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear Button Code
            inputTextBox.Text = "";
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit Button Code
            this.Close();
        }
    }
}
