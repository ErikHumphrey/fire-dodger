/*
___  ___           _              ______ _            _        
|  \/  |          (_)             | ___ \ |          | |       
| .  . | _____   ___ _ __   __ _  | |_/ / | ___   ___| | _____ 
| |\/| |/ _ \ \ / / | '_ \ / _` | | ___ \ |/ _ \ / __| |/ / __|
| |  | | (_) \ V /| | | | | (_| | | |_/ / | (_) | (__|   <\__ \
\_|  |_/\___/ \_/ |_|_| |_|\__, | \____/|_|\___/ \___|_|\_\___/
                            __/ |                              
                           |___/                                   */                 

/* Author: Erik Humphrey
 * Project title: Project 23 - Moving Blocks
 * Date started: December 14th
 * Executable name: HumphreyErik23MovingBlocks.exe
 * Description: Game with moving image character controlled by user. User wins or loses based on objects they collide with; some move.
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

namespace HumphreyErik23MovingBlocks
{
    public partial class frmMovingBlocks : Form
    {
        // Global declarations
        bool sRight, sLeft, sUp, sDown;
        int[] yFVelocity = new int[5];
        int scoreTimer;

        public frmMovingBlocks()
        {
            InitializeComponent();
        }

        private void frmMovingBlocks_Load(object sender, EventArgs e)
        {
            // Set speed of fires
            yFVelocity[0] = 1;
            yFVelocity[1] = 2;
            yFVelocity[2] = 3;
            yFVelocity[3] = 3;
            yFVelocity[4] = -3;
            // Show tutorial message, start game when it is closed
            MessageBox.Show("Navigate around the walls of fire to reach the bag of chips!\r\n\r\nArrow keys to move.", "Tutorial");
            tmrScore.Start();
            tmrFires.Start();
        }

        // Stops pressing arrow keys
        private void frmMovingBlocks_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    sRight = false;
                    break;
                case Keys.Left:
                    sLeft = false;
                    break;
                case Keys.Up:
                    sUp = false;
                    break;
                case Keys.Down:
                    sDown = false;
                    break;
            }

        }

        // Starts pressing arrow keys
        private void frmMovingBlocks_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    sRight = true;
                    picHero.Image = Properties.Resources.hero;
                    break;
                case Keys.Left:
                    sLeft = true;
                    picHero.Image = Properties.Resources.heroleft;
                    break;
                case Keys.Up:
                    sUp = true;
                    break;
                case Keys.Down:
                    sDown = true;
                    break;
            }
        }

        private void tmrFires_Tick(object sender, EventArgs e)
        {
            // Declare moving fire picturebox array
            PictureBox[] picFires = new PictureBox[] {
				picFire1, picFire2, picFire3, picFire4, picFire5
			};
            int[] yFire = new int[5];

            // Move hero based on keys pressed
            if (sRight == true && picHero.Left + picHero.Width < this.ClientRectangle.Width)
            {
                picHero.Left += 3;
            }
            else if (sLeft == true && picHero.Left > this.ClientRectangle.Left)
            {
                picHero.Left -= 3;
            }
            else if (sUp == true && picHero.Top > this.ClientRectangle.Top)
            {
                picHero.Top -= 3;
            }
            else if (sDown == true && picHero.Top + picHero.Height < this.ClientRectangle.Height)
            {
                picHero.Top += 3;
            }

            // Moving fires
            for (int i = 0; i < 5; i++)
            {
                yFire[i] = picFires[i].Top;
                yFire[i] = yFire[i] + yFVelocity[i];
            }

            // Change direction
            for (int i = 0; i < 5; i++)
            {
                if (yFire[i] < 0 || yFire[i] > this.ClientRectangle.Height - picFires[i].Height)
                {
                    yFVelocity[i] = (-1) * yFVelocity[i];
                }

                picFires[i].Top = yFire[i];
            }

            // Detect Hero collision with fires
            for (int i = 0; i < 5; i++)
            {
                if (picHero.Bounds.IntersectsWith(picFires[i].Bounds))
                {
                    // Change image of hero to look dead (different depending on the direction he was facing)
                    if (sRight) picHero.Image = Properties.Resources.right4dead;
                    else picHero.Image = Properties.Resources.left4dead;
                    endGame();
                    DialogResult playAgain = MessageBox.Show(
                        "You ran into a fire after " + scoreTimer + " seconds.\r\n\r\nTIP: Fires have square hitboxes, stay as far away from them as you can!",
                        "Game over",
                        // "Makes sure" the default focused button is Retry, but because the user is hitting the right arrow key, it will probably move to Cancel anyway
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    if (playAgain == DialogResult.Retry)
                    {
                        resetGame();
                    }
                    else if (playAgain == DialogResult.Cancel)
                    {
                        this.Close(); // Close the program
                    }
                }
            }

            // Hero collision with bag of chips objective
            if (picHero.Bounds.IntersectsWith(picChips.Bounds))
            {
                endGame();
                DialogResult playAgain = MessageBox.Show("You reached the chips in " + scoreTimer + " seconds.\r\n\r\nWould you like to try for a better time?",
                    "Victory!",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                if (playAgain == DialogResult.Retry)
                {
                    resetGame();
                }
                else if (playAgain == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

        }

        // Score timer that counts up 1/second and updates form title
        private void tmrScore_Tick(object sender, EventArgs e)
        {
            scoreTimer += 1;
            this.Text = "Erik Humphrey's Quest for Chips - Timer: " + scoreTimer;
        }

        void endGame()
        {
            // Stop timers
            tmrFires.Stop();
            tmrScore.Stop();
        }

        void resetGame()
        {
            sRight = sLeft = sDown = sUp = false;
            // Unkill the player character
            picHero.Image = Properties.Resources.hero;
            // Return player character and fires to starting positions
            picHero.Location = new Point(69, 197);
            picFire1.Location = new Point(293, 12);
            picFire2.Location = new Point(213, 335);
            picFire3.Location = new Point(370, 178);
            picFire4.Location = new Point(468, 106);
            picFire5.Location = new Point(468, 188);
            // Count score
            scoreTimer = 0;
            this.Text = "Erik Humphrey's Quest for Chips - Timer: " + scoreTimer;
            tmrScore.Start();
            // Allow the player and fires to move
            tmrFires.Start();
        }
    }
}