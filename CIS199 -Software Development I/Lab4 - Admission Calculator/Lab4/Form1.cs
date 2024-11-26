/*
Lab4
CIS-199-50
Grading ID : A1006
Due 10/01/2023

This is a Program that decides admission status based on gpa and test scores.
 */

using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int accepted = 0, rejected = 0; //counters for admission status

        public Form1()
        {
            InitializeComponent();
        }

        private void admitBtn_Click(object sender, EventArgs e)
        {
            double gpa, ats; //each scores

            //collect the user input
            if (double.TryParse(gpaBox.Text, out gpa) && double.TryParse(admissionTestScoreBox.Text, out ats))
            {
                //check if the gpa and admission test scores are within the range
                if (gpa >= 0.0 && gpa <= 4.0 && ats >= 0 && ats <= 100)
                {
                    //if gpa and test scores are accpeted, increase counter and display accept
                    if (gpa >= 3.0 && ats >= 60)
                    {
                        admissionDecision.Text = "Accept";
                        accepted++;
                        acceptedCount.Text = accepted.ToString();
                    }
                    //if the test score is accpeted, increase counter and display accept
                    else if (gpa < 3.0 && ats >= 80)
                    {
                        admissionDecision.Text = "Accept";
                        accepted++;
                        acceptedCount.Text = accepted.ToString();
                    }
                    //if gpa and test scores are not acceptable, increase counter and display reject
                    else
                    {
                        admissionDecision.Text = "Reject";
                        rejected++;
                        rejectedCount.Text = rejected.ToString();

                    }

                }
                //if the numbers are out of range, display message
                else
                {
                    MessageBox.Show("Check your numbers!");
                }
            }
            //if the numbers cannot be parsed, display message
            else
            {
                MessageBox.Show("Check your numbers!");
            }




        }
    }
}
