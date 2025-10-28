using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            continueButton.Enabled = false;
            playerNameLabel.Text = SharedVar.playerName;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            timeRemainingLabel.Text = "Time Remaining: " + SharedVar.timeRemaining.ToString();
        }

        private void decision41Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.wisdom += 10;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            decision51Button.Enabled = false;
            decision52Button.Enabled = false;
            decision53Button.Enabled = false;
            storyLabel2.Text = "On the way you come across ancient scripts.";
        }

        private void decision52Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.life -= 1;
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            decision51Button.Enabled = false;
            decision52Button.Enabled = false;
            decision53Button.Enabled = false;

            //end the game should the player be out of lives
            if (SharedVar.life < 1)
            {
                storyLabel2.Text = "Game Over";
                decision51Button.Visible = false;
                decision52Button.Visible = false;
                decision53Button.Visible = false;
                continueButton.Visible = false;
                storyLabel2.Text = "The middle way was a trap and you fell for it thinking no one would be there.";

                Thread.Sleep(1000);
                Refresh();

                this.Close();

                Application.Restart();
                Environment.Exit(0);

            }

            storyLabel2.Text = "The middle way was a trap and you fell for it thinking no one would be there.";
        }

        private void decision53Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.power += 10;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            decision51Button.Enabled = false;
            decision52Button.Enabled = false;
            decision53Button.Enabled = false;
            storyLabel2.Text = "On the way you found a victim to strengthen yourself with.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form7 form7 = new Form7();
            form7.Show();

            this.Close();
        }
    }
}
