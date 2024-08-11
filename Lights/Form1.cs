using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            lightOnPictureBox.Visible = true; //Display the "light on" image
            lightOffPictureBox.Visible = false; //Hide the "light off" image
            lightStateLabel.Text = "ON"; //Display the light's state
        }

        private void TurnLightOff()
        {
            lightOnPictureBox.Visible = false; //Hide the "light off" image
            lightOffPictureBox.Visible = true; //Display the "light on" image
            lightStateLabel.Text = "OFF"; //Display the light's state
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close the form
        }
    }
}
