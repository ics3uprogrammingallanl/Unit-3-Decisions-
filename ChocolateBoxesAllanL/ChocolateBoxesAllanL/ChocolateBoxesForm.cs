/*
 * Created by: Allan L
 * Created on: March 3, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
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

namespace ChocolateBoxesAllanL
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            //Set the user input to boxesOfChoc
            int boxesOfChoc;
            boxesOfChoc = Convert.ToInt32(nudBoxesSold.Value);

            if (boxesOfChoc > 20)
            {
                lblReward.Text = " A Car";
            }
            else
            {
                if (boxesOfChoc < 10)
                {
                    lblReward.Text = " An honorable Mention";
                }
                else if(boxesOfChoc >10)
                {
                    lblReward.Text = " A Small Prize";    
                }
            }
        }
    }
}
