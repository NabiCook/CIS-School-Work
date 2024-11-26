/*
Program 2
CIS-199-50
Grading ID : A1006
Due 10/25/2023

This is a Program that calculates the insurance cost based on age, car value, and other multiple factors.
 */

using System;
using System.Windows.Forms;

namespace Program2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Preload values for the combobox
            string[] healthInsurance = { "Medical", "Dental", "Vision", "None" };
            string[] carInsurance = { "Full", "Liability", "None" };
            healthInsuranceCombo.Items.AddRange(healthInsurance);
            carInsuranceCombo.Items.AddRange(carInsurance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //set variables and define initial value.
            //default set to 0 so that each selection would change the value and added to the total later on.
            //otherwise, it will not affect the calculation
            int age, carValue;
            double totalCost,
                //car insurance costs are divided to calculate each percentage changes from the total.
                carCoverageCost,
                carCoverageCost2,
                carCoverageCostAnnual,
                carBaseRate, //initial coverage cost before % increase or decrease.
                healthCoverageCost,
                healthCoverageCostAnnual,
                //values for health insurance.
                medicalRate = 0,
                dentalRate = 0,
                visionRate = 0,
                //values for car insurance.
                fullRate = 0,
                liabilityRate = 0,
                //values for radio selections, if smoking or has accident history.
                smokeRate = 0,
                youngRate = 0,
                //values for discount or increasement rates.
                baseRateDecrease = 0,
                baseRateIncrease = 0;
            //boolian values for validation on every input.
            bool ageParse,
                carValueParse,
                goodState,
                ageCheck,
                valueCheck,
                healthCheck,
                carCheck,
                smokeCheck,
                accidentCheck;

            //take user input from the textbox.
            ageParse = int.TryParse(ageBox.Text, out age);
            carValueParse = int.TryParse(valueBox.Text, out carValue);

            try
            {
                //filter for missing data and user input validation.
                if (!ageParse || age < 1 || age > 100)
                {
                    MessageBox.Show("Invalid Age");
                    ageCheck = false;
                }
                else ageCheck = true;

                if (!carValueParse || carValue < 0)
                {
                    MessageBox.Show("Invalid Car Value");
                    valueCheck = false;
                }
                else valueCheck = true;

                if (healthInsuranceCombo.SelectedIndex == -1) healthCheck = false;
                else healthCheck = true;

                if (carInsuranceCombo.SelectedIndex == -1) carCheck = false;
                else carCheck = true;

                if (!smokeYes.Checked && !smokeNo.Checked)
                {
                    MessageBox.Show("Missing Smoking Status");
                    smokeCheck = false;
                }
                else smokeCheck = true;

                if (!accidentYes.Checked && !accidentNo.Checked)
                {
                    MessageBox.Show("Missing Accident History");
                    accidentCheck = false;
                }
                else accidentCheck = true;

                //check if all inputs are valid
                if (ageParse && carValueParse && ageCheck && valueCheck && healthCheck && carCheck && smokeCheck && accidentCheck)
                    goodState = true;
                else goodState = false;

                //adds the value to variables depending on selection, any invalid input (goodState false) will skip.
                if (healthInsuranceCombo.SelectedItem.ToString() == "Medical" && goodState)
                {
                    medicalRate = 160;
                    if (smokeYes.Checked)
                        smokeRate = 70;
                }

                if (healthInsuranceCombo.SelectedItem.ToString() == "Dental" && goodState)
                    dentalRate = 20;

                if (healthInsuranceCombo.SelectedItem.ToString() == "Vision" && goodState)
                    visionRate = 30;

                if (carInsuranceCombo.SelectedItem.ToString() == "Full" && goodState)
                {
                    fullRate = 110;
                    if (age <= 21)
                        youngRate = 25;
                    if (carValue < 15000)
                        baseRateDecrease = 0.12;
                    if (accidentYes.Checked)
                        baseRateIncrease = 0.2;
                }

                if (carInsuranceCombo.SelectedItem.ToString() == "Liability" && goodState)
                {
                    liabilityRate = 50;
                    if (age <= 21)
                        youngRate = 25;
                    if (carValue < 15000)
                        baseRateDecrease = 0.12;
                    if (accidentYes.Checked)
                        baseRateIncrease = 0.2;
                }

                //Rate calculation
                healthCoverageCost = medicalRate + dentalRate + visionRate + smokeRate;
                carBaseRate = youngRate + fullRate + liabilityRate;
                carCoverageCost = carBaseRate - (carBaseRate * baseRateDecrease);
                carCoverageCost2 = carCoverageCost + (carCoverageCost * baseRateIncrease);
                healthCoverageCostAnnual = healthCoverageCost * 12;
                carCoverageCostAnnual = carCoverageCost2 * 12;
                totalCost = healthCoverageCostAnnual + carCoverageCostAnnual;

                //text output to textboxes in currency format, 2 digit precision.
                healthCostBox.Text = healthCoverageCostAnnual.ToString("C2");
                carCostBox.Text = carCoverageCostAnnual.ToString("C2");
                totalCostBox.Text = totalCost.ToString("C2");
            }
            //if either of the comboboxes are not selected, catch error and show messagebox
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please Select your Insurance Coverage!");
            }
        }
    }
}
