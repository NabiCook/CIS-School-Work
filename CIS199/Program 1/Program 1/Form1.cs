/*
Program 1
CIS-199-50
Grading ID : A1006
Due 9/28/2023

This is a Program that calculates the materials and labor costs for mural painting company.
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

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width, //width of the painting area
                length, //length of the painting area
                price, //price of the paint
                paintingArea, //total area for the painting
                laborCost, //total cost of labor
                paintCost, //total cost of paint
                coatingCost, //total cost of coating
                totalCost; //sum of all costs, final price

            int colors, //number of colors that will be used
                coats, //layer(s) of coat that will be used, 1 or 2.
                illuminate; //if the mural will be illuminated or not. 1 for yes, 0 for no
            
            const double wastePercentage = 0.1; //additional 10% factor for waste, in case some more are needed
            const double colorCost = 8.5; //cost per color
            const double coatCost = 10; //cost per layer of coating
            const double illuminateCost = 75; //cost for illumination
            const double laborFeeSqFt = 6.5; //labor fee per sq ft



            //try to run the code
            try
            {
                //set each variables according to user input
                width = double.Parse(widthBox.Text);
                length = double.Parse(lengthBox.Text);
                price = double.Parse(paintPriceBox.Text);
                colors = int.Parse(colorsBox.Text);
                coats = int.Parse(coatsBox.Text);
                illuminate = int.Parse(illuminateBox.Text);

                //formula for the area and costs
                paintingArea = width * length;
                laborCost = (illuminate * illuminateCost) + (paintingArea * laborFeeSqFt);
                paintCost = (paintingArea * price) * (1 + wastePercentage) + (colors * colorCost);
                coatingCost = coats * coatCost;
                totalCost = laborCost + paintCost + coatingCost;

                //show the results through the label
                totalAreaLbl.Text = paintingArea.ToString("F1");
                paintCostLbl.Text = paintCost.ToString("C2");
                coatsCostLbl.Text = coatingCost.ToString("C2");
                laborCostLbl.Text = laborCost.ToString("C2");
                totalCostLbl.Text = totalCost.ToString("C2");
            }

            //when user input cannot be accepted (due to wrong format or empty), show all labels as invalid.
            catch (FormatException) 
            {
                totalAreaLbl.Text = "Invalid";
                paintCostLbl.Text = "Invalid";
                coatsCostLbl.Text = "Invalid";
                laborCostLbl.Text = "Invalid";
                totalCostLbl.Text = "Invalid";
            }
        }
    }
}
