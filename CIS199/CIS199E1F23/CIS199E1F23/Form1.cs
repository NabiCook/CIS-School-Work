/*
Exam 1
CIS-199-50
Grading ID : A1006
Due 10/05/2023

This is a Program that evaluates membership based on the price.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199E1F23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double input;//for user input
            bool result;//for tryparse results

            //take user input and tryparse, setting input value as output, result to result
            result = double.TryParse(amountBox.Text, out input);

            //when tryparse was successful
            if (result == true) 
            {
                //if else logic for each membership plans
                if (input >= 61) 
                {
                    outputLbl.Text = "You can afford : VIP Membership";
                }
                else if (input >= 46 && input <= 60)
                {
                    outputLbl.Text = "You can afford : Ultra Plan";
                }
                else if (input >= 31 && input <= 45)
                {
                    outputLbl.Text = "You can afford : Family Plan";
                }
                else if (input >= 21 && input <= 30)
                {
                    outputLbl.Text = "You can afford : Premium Plan";
                }
                else if (input >= 11 && input <= 20)
                {
                    outputLbl.Text = "You can afford : Standard Plan";
                }
                else if (input >= 5 && input <= 10)
                {
                    outputLbl.Text = "You can afford : Basic Plan";
                }
                else
                {
                    outputLbl.Text = "You cannot afford any plans!";
                }
            }
            //when tryparse was not successful
            else if (result == false)
            {
                outputLbl.Text = "Please Enter Valid Amount!";
            }
        }
    }
}
