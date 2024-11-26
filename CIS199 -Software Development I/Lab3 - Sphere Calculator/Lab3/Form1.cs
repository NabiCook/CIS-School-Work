/*
Lab3
CIS-199-50
Grading ID : A1006
Due 9/24/2023

This is a Program that calculates diameter, surface area, and volume of a sphere based on its radius.
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

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double radius, //radius value
                rSquared, //radius squared
                rCubed, //radius cubed
                diameter, //diameter value
                surfaceArea, //surface area value
                volume, //volume value
                PI; //pi value

            
            //run the code until it faces any error.
            try
            {
                //reads the box for user input and sets as the radius.
                radius = double.Parse(radiusBox.Text);

                //calls the value of PI
                PI = Math.PI;

                //equations for each sections
                rSquared = Math.Pow(radius, 2);
                rCubed = Math.Pow(radius, 3);

                diameter = radius * 2;
                surfaceArea = 4 * PI * rSquared;
                volume = (4 * PI * rCubed) / 3;

                //displays the result to each labels, in xxx,xxx.xx format.
                diameterBox.Text = diameter.ToString("N2");
                surfaceAreaBox.Text = surfaceArea.ToString("N2");
                volumeBox.Text = volume.ToString("N2");
            }

            //catch format exception then output invalid to each boxes, in case the user input is other than numbers.
            catch (FormatException)
            {
                diameterBox.Text = "INVALID";
                surfaceAreaBox.Text = "INVALID";
                volumeBox.Text = "INVALID";
            }
        }
    }
}




