using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
        }





        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal packagePrice;

            //waxaa la hubinaa in lasoo galiyey tiro ka weyn 0
            if (!int.TryParse(txtNumberofPackages.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Fadlan geli wax ka weyn 0");
                txtNumberofPackages.Focus(); 
                return;
            }

            //waxaa la hubinaa in lasoo galiyey tiro ka weyn 0
            if (!decimal.TryParse(txtPriceperPackage.Text, out packagePrice) || packagePrice <= 0)
            {
                MessageBox.Show("Fadlan geli wax ka weyn 0");
                txtPriceperPackage.Focus();
                return; 
            }

            //  qiimo dhimista Discount Rate oo ka bilaabmaya 0
            decimal discountRate = 0m;

            // Xisaabinta 100 qiimo dhimista waxana loo eega tirada la iibsaday
            if (quantity >= 10 && quantity <= 19)
                discountRate = 0.20m; 
            else if (quantity >= 20 && quantity <= 49)
                discountRate = 0.30m; 
            else if (quantity >= 50 && quantity <= 99)
                discountRate = 0.40m; 
            else if (quantity >= 100)
                discountRate = 0.50m; 

            // Xisaabinta guud ee lacagta qiimo dhimista iyo wadarta dambe
            decimal subtotal = quantity * packagePrice;
            decimal discountAmount = subtotal * discountRate;
            decimal totalAmount = subtotal - discountAmount;


            //Display
            listSoftware.Items.Clear();
            listSoftware.Items.Add("---- Software Sales Results ----");
            listSoftware.Items.Add("Number of Packages : " + quantity);
            listSoftware.Items.Add("Price per Package  : " + packagePrice);
            listSoftware.Items.Add("Subtotal (Before Discount) : " + subtotal);
            listSoftware.Items.Add("Discount Rate : " + discountRate);
            listSoftware.Items.Add("Discount Amount : " + discountAmount);
            listSoftware.Items.Add("Total Amount (After Discount) : " + totalAmount);
        }

        //Clear
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtNumberofPackages.Clear();
            listSoftware.Items.Clear();
            txtPriceperPackage.Clear();
           
        }
        //Exit
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

       