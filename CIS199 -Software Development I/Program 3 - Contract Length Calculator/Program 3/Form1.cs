/*
Program 3
CIS-199-50
Grading ID : A1006
Due 11/11/2023

This is a Program that calculates the final shippiing contract for each business's products.
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

namespace Program_3
{
    public partial class Form1 : Form
    {
        //Define arrays
        double[] discountRate = { 0.22, 0.18, 0.19, 0.20 };
        string[] company = { "USPS", "DHL", "FedEx", "UPS" };
        string[] business = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" };
        double[] contractPrice = { 55000, 85000, 60000, 75000, 95000, 55000 };
        int[,] contractYears = { { 0, 0, 1 }, {2, 3, 4 }, {5, 6, 7 }, {8, 9, 10 } };
        double[] addDiscount = { 0, 10000, 20000, 30000 };

        public Form1()
        {
            InitializeComponent(); 
            //Load combo box items from arrays
            providerComBox.Items.AddRange(company);
            businessComBox.Items.AddRange(business);
        }

        public void calculateBtn_Click(object sender, EventArgs e)
        {
            //bool for testing valid user input
            bool providerCheck, 
                businessCheck, 
                contractCheck, 
                loop = true;

            
            int contractLength, //user input

                //index values will be stored from for loop.
                providerIndex = 0, 
                businessIndex = 0, 
                contractIndex = 0, 

                //maximum index value for the multidimensional array contractYears.
                rows = contractYears.GetLength(0),
                cols = contractYears.GetLength(1);

            //stores calculated values
            double companyDiscount, finalPrice;

            try //tries if the program runs successfully
            {
                //checks if the combo box is selected
                if (providerComBox.SelectedIndex == -1)
                {
                    MessageBox.Show("You Must Select a Provider");
                    providerCheck = false;
                }
                else providerCheck = true;

                //checks if the combo box is selected
                if (businessComBox.SelectedIndex == -1)
                {
                    MessageBox.Show("You Must Select a Business");
                    businessCheck = false;
                }
                else businessCheck = true;

                //takes the user input
                contractCheck = int.TryParse(contractLengthBox.Text, out contractLength);       
                if (contractCheck == false)
                    MessageBox.Show("You Must Provide Valid Contract Years [0,10]");

                else
                {
                    //checks if the user input is valid and within the accepted range
                    if (contractLength >= 0 && contractLength <= 10)
                        contractCheck = true;

                    else
                    {
                        MessageBox.Show("You Must Provide Valid Contract Years [0,10]");
                        contractCheck = false;
                    }
                }

                //if all checks passed, proceed to finding index values
                if (providerCheck == true && businessCheck == true && contractCheck == true)
                {
                    //loop to find the shipping company's index value
                    for (int i = 0; i < company.Length; i++)
                    {
                        if (providerComBox.Text == company[i].ToString())
                        {
                            providerIndex = i;
                            break;
                        }
                    }
                    //loop to find the business's index value
                    for (int i = 0; i < business.Length; i++)
                    {
                        if (businessComBox.Text == business[i].ToString())
                        {
                            businessIndex = i;
                            break;
                        }
                    }

                    //loop to find the contract year's index value from the multidimensional array
                    //also bool loop is used to ensure the loop stops once the value is found.
                    while (loop)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int x = 0; x < cols; x++)
                            {
                                if (contractYears[i, x] == contractLength)
                                {
                                    contractIndex = i;
                                    loop = false;
                                    break;
                                }
                            }
                            if (!loop) break;
                        }
                    }

                    //replace each boxes with the corresponding value in the arrays.
                    //also the calculation for discount and final price.
                    providerBox.Text = company[providerIndex].ToString();
                    initialContractBox.Text = contractPrice[businessIndex].ToString("C2");
                    companyDiscount = contractPrice[businessIndex] * discountRate[providerIndex];
                    companyDiscountBox.Text = companyDiscount.ToString("C2");
                    lengthDiscountBox.Text = addDiscount[contractIndex].ToString("C2");
                    finalPrice = contractPrice[businessIndex] - companyDiscount - addDiscount[contractIndex];
                    finalPriceBox.Text = finalPrice.ToString("C2");
                }
            }
            //catch was replaced with the checks. It remains to keep the try-catch format.
            catch (System.NullReferenceException) { MessageBox.Show("NullReferenceException"); }




        }
    }
}
