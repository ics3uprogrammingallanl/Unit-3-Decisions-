using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsAllanL
{
    public partial class frmRockPaperScissors : Form
    {

        //Global Variables and Constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;
        int userChoice;
        int compChoice;
        int compRandom;
        Random randomNumberGenerator = new Random();
        

        public frmRockPaperScissors()
        {
            InitializeComponent();

            //Set all buttons to be unchecked
            radUserRock.Checked = false;
            radUserPaper.Checked = false;
            radUserScissors.Checked = false;
            radCompRock.Checked = false;
            radCompPaper.Checked = false;
            radCompScissors.Checked = false;

            //Disable all computer buttons
            radCompRock.Enabled = false;
            radCompPaper.Enabled = false;
            radCompScissors.Enabled = false;

        }

        private void radUserPaper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCompPaper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //generate a random number and set compchoice to it
            compRandom = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //if the user checks  a certain box, set userChoice to its corresponding value
            if (radUserRock.Checked == true)
            {
                userChoice = ROCK;
            }
            else if (radUserPaper.Checked == true)
            {
                userChoice = PAPER;
            }
            else if (radUserScissors.Checked == true)
            {
                userChoice = SCISSORS;
            }

            //Set the random number to compChoice
            if (compRandom == ROCK)
            {
                compChoice = ROCK;
                radCompRock.Checked = true;
            }
            else if (compRandom == PAPER)
            {
                compChoice = PAPER;
                radCompPaper.Checked = true;
            }
            else if (compRandom == SCISSORS)
            {
                compChoice = SCISSORS;
                radCompScissors.Checked = true;
            }

            //See who won
            if (compChoice == ROCK)
            {
                if (userChoice == ROCK)
                {
                    lblWin.Text = "Tie";
                }
                else if (userChoice == PAPER)
                {
                    lblWin.Text = "You Win";
                }
                else if (userChoice == SCISSORS)
                {
                    lblWin.Text = "Computer Wins";
                }
            }

            else if (compChoice == PAPER)
            {
                if (userChoice == ROCK)
                {
                   lblWin.Text = "Computer Wins";
                }
                if (userChoice == PAPER)
                {
                    lblWin.Text = "Tie";
                }
                if (userChoice == SCISSORS)
                {
                    lblWin.Text = "You Win";
                }
                }
            
                if (compChoice == SCISSORS)
                {
                    if (userChoice == ROCK)
                    {
                        lblWin.Text = "You Win";
                    }
                    else if (userChoice == PAPER)
                    {
                        lblWin.Text = "Computer Wins";
                    }
                    else if (userChoice ==SCISSORS)
                    {
                        lblWin.Text = "Tie";
                    }
                }
            }
        }
    }
