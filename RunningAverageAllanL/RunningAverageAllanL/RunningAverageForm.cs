/*
 * Created by: AllanL
 * Created on: April 3, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
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

namespace RunningAverageAllanL
{
    public partial class frmRunningAverage : Form
    {

        //variables
        int counter = 0;
        double total = 0;
        double userNum;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //incriment the counter
            counter++;
            userNum = Convert.ToDouble(txtNumber.Text);

            //if the user enters a number that is between 0-100, it will add it to the total
            if (userNum >= 0)
            {
                total = total + userNum;
            }
            else if (userNum == -1)
            {
                MessageBox.Show("Running Average Ended", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtNumber.Visible = false;
            }

            //diplay the average
            lblAverage.Text = Convert.ToString(total / counter);
        }
    }
}
