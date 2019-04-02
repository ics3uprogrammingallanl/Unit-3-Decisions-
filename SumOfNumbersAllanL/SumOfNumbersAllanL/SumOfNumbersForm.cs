/*
 * Created by: Allan L
 * Created on: March 25, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - SumOfNumbers
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

namespace SumOfNumbersAllanL
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Local Variables
            Double sumAns;
            Double SumNum;
            int sumCount;

            //clear the listbox items
            this.lstSumNum.Items.Clear();

            //Initialize the answer to 1
            sumAns = 0;

            //get the number from the user
            SumNum = Convert.ToDouble(this.nudSumNum.Value);

            //Looping
            for (sumCount = 1; sumCount <= SumNum; sumCount++)
            {
                //add the counter number to the list
                this.lstSumNum.Items.Add(sumCount);

                //add the counter to the answer
                sumAns = sumAns + sumCount;
            }
            //Convert the answer to a string and display it
            this.lblAnswer.Text = this.nudSumNum.Value + " and all the numbers before it = " + Convert.ToString(sumAns);
        }
    }
}
