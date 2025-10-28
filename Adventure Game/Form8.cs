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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            continueButton.Enabled = false;
            playerNameLabel.Text = SharedVar.playerName;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            timeRemainingLabel.Text = "Time Remaining: " + SharedVar.timeRemaining.ToString();
        }

        private void decision51Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.power += 10;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            decision71Button.Enabled = false;
            decision72Button.Enabled = false;
            decision73Button.Enabled = false;
            storyLabel2.Text = "The mansion turned out to be the previous hideout of other vampires and you could strengthen yourself.";
        }

        private void decision72Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.wisdom += 10;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            decision71Button.Enabled = false;
            decision72Button.Enabled = false;
            decision73Button.Enabled = false;
            storyLabel2.Text = "The crypt turned out to contain old books written by other vampires.";
        }

        private void decision73Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.morality -= 1;
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            decision71Button.Enabled = false;
            decision72Button.Enabled = false;
            decision73Button.Enabled = false;
            storyLabel2.Text = "People come to the cellar by day and you had to kill them to avoid being found ouh for a few more days.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form9 form9 = new Form9();
            form9.Show();

            this.Close();
        }
    }
}
