/*
 * Created by: Allan L
 * Created on: March 21, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial with For Loop
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

namespace FactorialWithForLoopAllanL
{
    public partial class frmFactorialWithForLoop : Form
    {
        public frmFactorialWithForLoop()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Local Variables
            Double facAns;
            Double FacNum;
            int facCount;

            //clear the listbox items
            this.lstFacNum.Items.Clear();

            //Initialize the answer to 1
            facAns = 1;

            //get the number from the user
            FacNum = Convert.ToDouble(this.nudNum.Value);

            //Looping
            for (facCount = 1; facCount <= FacNum; facCount++)
            {
                //add the counter number to the list
                this.lstFacNum.Items.Add(facCount);

                //add the counter to the answer
                facAns = facAns * facCount;
            }
            //Convert the answer to a string and display it
            this.lblAnswer.Text = this.nudNum.Value + " ! = " + Convert.ToString(facAns);
        }
    }
}
