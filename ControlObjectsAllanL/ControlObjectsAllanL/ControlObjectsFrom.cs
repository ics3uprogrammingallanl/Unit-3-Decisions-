/*
 * Created by: Allan L
 * Created on: April 4, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Control Objects
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

namespace ControlObjectsAllanL
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            //change the backround color of label to deep sky blue 
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.DeepSkyBlue;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.DeepSkyBlue;
                }
            }
        }
    }
}
