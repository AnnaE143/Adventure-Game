using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            continueButton.Enabled = false;
            playerNameLabel.Text = SharedVar.playerName;
            timeRemainingLabel.Text = "Time Remaining: " + SharedVar.timeRemaining.ToString();
        }

        private void lifeLabel_Click(object sender, EventArgs e)
        {

        }

        private void decision11Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.wisdom += 10;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            SharedVar.timeRemaining -= 1;
            decision11Button.Enabled = false;
            decision12Button.Enabled = false;
            decision13Button.Enabled = false;
            storyLabel2.Text = "The tome contained precious ancient knowledge.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form3 form3 = new Form3();
            form3.Show();

            this.Close();
        }

        private void decision12Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.power += 10;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            SharedVar.timeRemaining -= 1;
            decision11Button.Enabled = false;
            decision12Button.Enabled = false;
            decision13Button.Enabled = false;
            storyLabel2.Text = "The amulet contained an ancient power.";
        }

        private void decision13Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.timeRemaining -= 1;
            decision11Button.Enabled = false;
            decision12Button.Enabled = false;
            decision13Button.Enabled = false;
            storyLabel2.Text = "You managed to leave with enough time.";
        }
    }
}
