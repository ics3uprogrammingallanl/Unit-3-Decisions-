/*
 * Created by: Allan L
 * Created on: March 19, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
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

namespace FactorialDoWhileAllanL
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Local variables
            Double facAns;
            Double facNum;
            int facCounter;

            //Clear the list box
            this.lstNumbers.Items.Clear();

            //Initialize the final answer to 1
            facAns = 1;

            //Set the users input to facNum
            facNum = Convert.ToDouble(this.txtNumber.Text);

            //Set the counter to 0
            facCounter = 0;

            //loop until the counter is equal to the facNum
            do
            {
                //Add 1 to the counter
                facCounter = facCounter + 1;

                //Add the counter number to the list
                lstNumbers.Items.Add(facCounter);

                //Multiply the counter by the answer
                facAns = facAns * facCounter;
            } while (facNum >= facCounter + 1);

            //Display the answer 
            this.lblAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(facAns);
        }
    }
}