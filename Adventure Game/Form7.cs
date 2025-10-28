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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            continueButton.Enabled = false;
            playerNameLabel.Text = SharedVar.playerName;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            timeRemainingLabel.Text = "Time Remaining: " + SharedVar.timeRemaining.ToString();

            if (SharedVar.power < 130)
            {
                decision62Button.Enabled = false;
            }
        }

        private void decision62Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            decision61Button.Enabled = false;
            decision62Button.Enabled = false;
            storyLabel2.Text = "You could easily cross the canyon without being noticed.";
        }

        private void decision61Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.life -= 1;
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            decision61Button.Enabled = false;
            decision62Button.Enabled = false;

            if (SharedVar.life < 1)
            {
                storyLabel2.Text = "Game Over";
                decision61Button.Visible = false;
                decision62Button.Visible = false;
                continueButton.Visible = false;
                storyLabel2.Text = "All the ways around the canyon were guarded by villagers.";

                Thread.Sleep(1000);
                Refresh();

                this.Close();

                Application.Restart();
                Environment.Exit(0);
            }

            storyLabel2.Text = "All the ways around the canyon were guarded by villagers.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form8 form8 = new Form8();
            form8.Show();

            this.Close();
        }
    }
}
