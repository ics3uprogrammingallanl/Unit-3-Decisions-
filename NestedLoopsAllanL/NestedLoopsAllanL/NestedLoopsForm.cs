/*
 * Created by: Allan L
 * Created on: April 2, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Alphabet Nested Loops
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

namespace NestedLoopsAllanL
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int CapLetterCounter;
            int LowLetterCounter;
            string CapLetters;
            string LowLetters;

            //clear ListBox
            lstLetters.Items.Clear();

            for (CapLetterCounter = 65; CapLetterCounter <=90; CapLetterCounter++)
            {
                for (LowLetterCounter = 97; LowLetterCounter <= 122; LowLetterCounter++)
                {
                    CapLetters = char.ConvertFromUtf32 (CapLetterCounter);
                    LowLetters = char.ConvertFromUtf32(LowLetterCounter);

                    lstLetters.Items.Add(CapLetters + " -> " + LowLetters);
                }
                    
            }

        }
    }
}
