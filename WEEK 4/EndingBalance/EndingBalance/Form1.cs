using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndingBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            try
            {
                decimal balance = decimal.Parse(txtStartingBal.Text); 
                int months = int.Parse(txtMonth.Text);         
                const decimal INTEREST_RATE = 0.005m;
                //
                int count = 1;
                    // WHILE LOOP
                while (count <= months)
                {
                    balance = balance + (INTEREST_RATE * balance);
                    lstOutput.Items.Add("Month " + count + " balance: " + balance.ToString("c"));
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli nambaro sax ah! Cilad: " + ex.Message);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (lstOutput.Items.Count == 0)
            {
                MessageBox.Show("Fadlan horta xisaabi balance-ka si xog loo kaydiyo!");
                return;
            }
            try
            {
                StreamWriter outputFile = File.CreateText("results.txt");
                // FOR LOOP
                for (int i = 0; i < lstOutput.Items.Count; i++)
                {
                    outputFile.WriteLine(lstOutput.Items[i].ToString());
                }
                outputFile.Close();
                MessageBox.Show("Xogtaada si guul leh ayaa loogu kaydiyay faylka 'results.txt'!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cilad ayaa dhacday: " + ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("results.txt"))
                {
                    lstOutput.Items.Clear();
                    StreamReader inputFile = File.OpenText("results.txt");

                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();
                        lstOutput.Items.Add(line);
                    }
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("Faylka 'results.txt' lama helin! Fadlan horta save dheh.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cilad ayaa dhacday: " + ex.Message);
            }
        }

        private void btnRandomNumbers_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            Random rand = new Random();

            lstOutput.Items.Add("--- Nambarada Random-ka ah ---");

            for (int i = 1; i <= 5; i++)
            {
                int randomNumber = rand.Next(1, 101); 
                lstOutput.Items.Add("Random Number " + i + ": " + randomNumber);
            }
        }
    }
}



