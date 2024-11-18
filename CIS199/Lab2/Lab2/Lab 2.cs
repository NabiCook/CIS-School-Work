/*
Lab2
CIS-199-50
Grading ID : A1006
Due 9/17/2023

This is a Program that calculates tip for 15%, 18%, and 20% from the meal price
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
using System.Globalization;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void calcTipBtn_Click(object sender, EventArgs e)
        {
            double mealPrice,//value the user inputs as a meal price
                    tip15, //value for the 15% tip
                    tip18, //value for the 18% tip
                    tip20; //value for the 20% tip

            //try if the code runs successfully
            try
            {
                //reads the box for user input and sets as the meal price
                mealPrice = double.Parse(priceInputBox.Text);

                //find out each tip amounts
                tip15 = mealPrice * 0.15;
                tip18 = mealPrice * 0.18;
                tip20 = mealPrice * 0.20;
            
                //outputs the final tip amounts to each labels, converting them into string with US curreny
                tipAmount15.Text = tip15.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
                tipAmount18.Text = tip18.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
                tipAmount20.Text = tip20.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
            }

            //FormatException happens when the user input(priceInputBox) is not double, either string or null
            //when the exception is catched, output all labels as invalid 
            catch (System.FormatException)
            {
                tipAmount15.Text = "INVALID";
                tipAmount18.Text = "INVALID";
                tipAmount20.Text = "INVALID";
            }                       
        }
    }
}
