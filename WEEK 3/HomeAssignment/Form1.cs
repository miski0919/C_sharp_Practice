using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            try
            {
                // Constant for high score value
                const double HIGH_SCORE = 95.0;

                // Variables to store test scores and average
                double test1, test2, test3, average;

                // Get the test scores from the TextBoxes
                test1 = double.Parse(txtScore1.Text);
                test2 = double.Parse(txtScore2.Text);
                test3 = double.Parse(txtScore3.Text);

                // Calculate the average test score
                average = (test1 + test2 + test3) / 3.0;

                // Display the average, rounded to 2 decimal places 
                txtScore4.Text = average.ToString("n1");

                // If the average is a high score, congratulate the user with a message box
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations! Great job!"); 
                }
            }
            catch (Exception ex)
            {   // Display error message if input is invalid
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes 
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            txtScore4.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

