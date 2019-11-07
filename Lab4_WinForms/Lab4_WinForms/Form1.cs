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

namespace Lab4_WinForms
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            string delim = ",";

            if(textBoxName.Text != "" && textBoxNumber.Text != "" && textBoxEmp.Text != "" &&
                textBoxAvailability.Text != "" && textBoxDate.Text != "" && textBoxDecription.Text != "")
            {
                string filePath = "C:\\Users\\egnnica\\products.csv";
                FileStream outFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter writerCSV = new StreamWriter(outFile);

                writerCSV.WriteLine(textBoxName.Text + delim + textBoxNumber.Text + delim + textBoxDecription.Text + delim + 
                    textBoxAvailability.Text + delim + textBoxDate.Text + delim + textBoxEmp.Text);

                writerCSV.Close();
                outFile.Close();

                textBoxName.Text = "";
                textBoxNumber.Text = "";
                textBoxEmp.Text = "";
                textBoxAvailability.Text = "";
                textBoxDate.Text = "";
                textBoxDecription.Text = "";

                textBoxName.Focus();
            }
            else
            {
                MessageBox.Show("Must fiil in all boxes", "Fill boxes");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxNumber.Text = "";
            textBoxEmp.Text = "";
            textBoxAvailability.Text = "";
            textBoxDate.Text = "";
            textBoxDecription.Text = "";

            textBoxName.Focus();
        }
    }
}
