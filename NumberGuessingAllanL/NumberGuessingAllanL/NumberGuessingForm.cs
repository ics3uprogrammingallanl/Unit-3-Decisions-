/*
     * Created by: Allan L
     * Created on: April 9, 2019
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - NumberGuessingGame
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

namespace NumberGuessingAllanL
{
    public partial class frmNumberGuessing : Form
    {
        public frmNumberGuessing()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //local variables
            const int NUM_SECRET = 3;
            int numGuess;

            //Get the number from the textbox
            numGuess = int.Parse(txtGuess.Text);

            //If the user gets it right, display a checkmark and play a ding sound
            if (numGuess == NUM_SECRET)
            {
                this.picRightWrong.Image = Properties.Resources.checkmark;
                System.Media.SoundPlayer dingSound = new System.Media.SoundPlayer(@"Correct Answer Sound Effect.wav");
                dingSound.Play();
            }
            //If the user gets it wrong, display a X and play a wrong sound
            else
            {
                this.picRightWrong.Image = Properties.Resources.red_x;
                System.Media.SoundPlayer wrongSound = new System.Media.SoundPlayer(@"Wrong Buzzer Sound Effect.wav");
                wrongSound.Play();
            }
        }

        private void frmNumberGuessing_Load(object sender, EventArgs e)
        {

        }
    }
}
