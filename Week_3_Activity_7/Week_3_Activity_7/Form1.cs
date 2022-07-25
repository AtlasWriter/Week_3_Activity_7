using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_Activity_7
//  Write a Windows Forms Application that prompts the user for a number of
//  terms and CALCULATES the value of the sequence for the specified number of terms;
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Once the user opens the program and enters terms then press the calculate button.
        private void button1_Click(object sender, EventArgs e)
        {
            // Build a varable to sore user input from textbox
            double termsInput;
            // Once user presses caluclates button the data is pased as a string and converts it
            // to intergers. TryParse to create a user friendly exception. 
            if(double.TryParse(termsTextBox.Text, out termsInput))
                // Pass user input terms to disply amount entered to label.
                guiDisplayTerms.Text = termsInput.ToString();
                // For loop to multiple by the terms user entered.
                for(int i = 0; i < termsInput; i++)
                {
                // Logic caculations algorithm
                double displayPi = i * 4.177271127019824e-4;
                // Display calculations from calclations algorithm.
                equalsPi.Text = displayPi.ToString("#.##############"); 
            }
        }
        // Rest Fields Button
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear text box
            termsTextBox.Text = "";
            // Focus cruser.
            termsTextBox.Focus();
        }
        // Close program button
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes form.
            this.Close();
        }
    }
}
