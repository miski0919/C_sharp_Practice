using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //creating a variables
            string dayof_week, Name_of_month, Numaric_Day, Year, Full_Date;

            //intial values to variables
            dayof_week = txtDayoftheweek.Text;
            Name_of_month = txtdayofthemonth.Text;
            Numaric_Day = txtofthemonth.Text;
            Year = txtYear.Text;

            // stage 2 = process - concatination of full date
            Full_Date = dayof_week + "," + Name_of_month + "," + 
                Numaric_Day + "," + Year;

            // stage 3 = the output using lebal
            lbloutbut.Text = Full_Date;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing texbox and lebal
            txtDayoftheweek.Clear();
            txtdayofthemonth.Text = "";
            txtofthemonth.Text = string.Empty;
            txtYear.Clear();


            //clearing label 
            lbloutbut.Text = "";
            //lbloutbut.Text = string.Empty;
        }

    }
}
