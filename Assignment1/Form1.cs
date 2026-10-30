using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear 
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create variable to store user input 
            string studentname, studentid, dep, semester, Fullinfor;

            studentname = txtsemester.Text;
            studentid = txtdepartment.Text;
            dep = txtdepartment.Text;
            semester = txtsemester.Text;

            // process to concantion
            Fullinfor = studentname + " " + studentid + " " + 
             dep + " " + semester;


        }

        private void lbloutput_Click(object sender, EventArgs e)
        {
            
        }
    }
}
