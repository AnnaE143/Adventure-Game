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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void timeRemainingLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            continueButton.Enabled = false;
            playerNameLabel.Text = SharedVar.playerName;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            timeRemainingLabel.Text = "Time Remaining: " + SharedVar.timeRemaining.ToString();
        }

        private void decision21Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.wisdom += 10;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            decision31Button.Enabled = false;
            decision32Button.Enabled = false;
            decision33Button.Enabled = false;
            storyLabel2.Text = "Spooked out you value your life and stay away from sketchy bodies of water.";
        }

        private void decision32Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.life -= 1;
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            SharedVar.power += 20;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            decision31Button.Enabled = false;
            decision32Button.Enabled = false;
            decision33Button.Enabled = false;
            storyLabel2.Text = "Overcome by your instincts you drown in the water, absorbing its ancient power.";
        }

        private void decision33Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.power += 10;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            decision31Button.Enabled = false;
            decision32Button.Enabled = false;
            decision33Button.Enabled = false;
            storyLabel2.Text = "Keeping your instincts in check, you absorb a small amount of the ponds ancient power.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form5 form5 = new Form5();
            form5.Show();

            this.Close();
        }
    }
}
