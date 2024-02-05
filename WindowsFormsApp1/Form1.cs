using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variable declaration
            int centimeters, yards, feet, inches;

            // Input
            centimeters = Convert.ToInt16(CentimetersTextBox.Text);

            // Process
            inches = Convert.ToInt16(centimeters / 2.54);
            yards = inches / 36;
            feet = inches % 36 / 12;
            inches = inches % 36 % 12;

            // Output
            YardsTextBox.Text = yards.ToString();
            FeetTextBox.Text = feet.ToString();
            InchesTextBox.Text = inches.ToString();
        }
    }
}
