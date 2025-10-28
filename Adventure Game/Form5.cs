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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            SharedVar.morality -= 5;
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            SharedVar.life -= 1;
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            SharedVar.power += 10;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            SharedVar.wisdom -= 10;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            decision41Button.Enabled = false;
            decision42Button.Enabled = false;
            decision43Button.Enabled = false;
            storyLabel2.Text = "You attack the villagers and they manage to wound you badly, before you can kill them all.";
        }

        private void decision42Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.wisdom += 10;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            decision41Button.Enabled = false;
            decision42Button.Enabled = false;
            decision43Button.Enabled = false;
            storyLabel2.Text = "After a while they leave and you're good to go on.";
        }

        private void decision43Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.morality += 1;
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            SharedVar.wisdom += 5;
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            decision41Button.Enabled = false;
            decision42Button.Enabled = false;
            decision43Button.Enabled = false;
            storyLabel2.Text = "You narrowly avoid being noticed.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form6 form6 = new Form6();
            form6.Show();

            this.Close();
        }
    }
}
