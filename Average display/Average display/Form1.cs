using System;
using System.Windows.Forms;

namespace Average_display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double score1 = double.Parse(txtScore1.Text);
                double score2 = double.Parse(txtScore2.Text);
                double score3 = double.Parse(txtScore3.Text);

                double average = (score1 + score2 + score3) / 3.0;

                txtAverage.Text = average.ToString("n1");
            }
            catch (Exception)
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            txtAverage.Clear();

            txtScore1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtScore1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}