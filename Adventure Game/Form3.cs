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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void decision11Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.morality += 1;
            SharedVar.companionFound = true;
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            decision21Button.Enabled = false;
            decision22Button.Enabled = false;
            decision23Button.Enabled = false;
            storyLabel2.Text = "You have found an adorable companion.";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //set all the labels that they show the correct stats once the form opens
            continueButton.Enabled = false;
            playerNameLabel.Text = SharedVar.playerName;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();
            timeRemainingLabel.Text = "Time Remaining: " + SharedVar.timeRemaining.ToString();
        }

        private void decision22Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.morality += 1;
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            decision21Button.Enabled = false;
            decision22Button.Enabled = false;
            decision23Button.Enabled = false;
            storyLabel2.Text = "Your kindness will be remembered.";
        }

        private void decision23Button_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            SharedVar.morality -= 1;
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            storyLabel2.Text = "You leave the bat behind, her cries for help becoming quieter.";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SharedVar.timeRemaining -= 1;
            Form4 form4 = new Form4();
            form4.Show();

            this.Close();
        }
    }
}
