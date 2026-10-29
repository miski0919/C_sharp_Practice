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

namespace FilesAssignment
{
    public partial class Form1 : Form
    {
        private string filePath = @"D:\C#\First_Example_CA242\FilesAssignment\FilesAssignment\chapter4.txt.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadingotherfunction_Click(object sender, EventArgs e)
        {
            try
            {
                lst.Items.Clear();

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = File.OpenText(filePath))
                    {
                        string line;
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            lst.Items.Add(line);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faylka la ma helin fadlan hubi path-ka!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }

        private void btnDeletethefile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the entire file?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    lst.Items.Clear();
                    MessageBox.Show("File deleted successfully");
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void btnDeletetheitemfile_Click(object sender, EventArgs e)
        {
             if (File.Exists(filePath))
            {
                if (lst.SelectedItem != null)
                {
                    string selectedItem = lst.SelectedItem.ToString();
                    var lines = File.ReadAllLines(filePath).ToList();

                    if (lines.Remove(selectedItem))
                    {
                        File.WriteAllLines(filePath, lines);
                        lst.Items.Remove(selectedItem);
                        MessageBox.Show("Item deleted successfully.");
                        lst.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.");
                }
            }
            else
            {
                MessageBox.Show("path not found");
            }
        }
    }
}
    
