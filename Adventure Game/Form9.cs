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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void playerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            playerNameLabel.Text = SharedVar.playerName;
            powerLabel.Text = "Power: " + SharedVar.power.ToString();
            lifeLabel.Text = "Life: " + SharedVar.life.ToString();
            moralityLabel.Text = "Morality: " + SharedVar.morality.ToString();
            wisdomLabel.Text = "Wisdom: " + SharedVar.wisdom.ToString();

            checkEnding();
        }

        private void checkEnding()
        {
            if ((SharedVar.power > 129) && (SharedVar.morality < 1) && (SharedVar.companionFound = true))
            {
                storyLabel2.Text = "You survived and managed to grow your vampiric strenght. Now you can easily fight against the villagers and continue to live your eternal life. But because your actions destroyed your morality you become a mindless beast and eat your bat friend.";
            }
            else if ((SharedVar.wisdom > 40) && (SharedVar.morality < 1) && (SharedVar.companionFound = true))
            {
                storyLabel2.Text = "You survived and managed to expand your wisdom but your actions hurt your morality so much, that you have now become a mindless beast. At least you have your bat friend by your side";
            }
            else if ((SharedVar.power > 129) && (SharedVar.morality < 1))
            {
                storyLabel2.Text = "You survived and managed to grow your vampiric strenght. Now you can easily fight against the villagers and continue to live your eternal life. But because your actions destroyed your morality you become a mindless beast.";
            }
            else if ((SharedVar.wisdom > 40) && (SharedVar.morality < 1))
            {
                storyLabel2.Text = "You survived and managed to expand your wisdom but your actions hurt your morality so much, that you have now become a mindless beast.";
            }
            else if ((SharedVar.power > 129) && (SharedVar.companionFound = true))
            {
                storyLabel2.Text = "You survived and managed to grow your vampiric strenght. Now you can easily fight against the villagers and continue to live your eternal life with your bat friend by your side.";
            }
            else if ((SharedVar.wisdom > 41) && (SharedVar.companionFound = true))
            {
                storyLabel2.Text = "You survived and managed to expand your wisdom. With your new aquired knowledge you can start life amongst the villagers again with your bat friend by your side.";
            }
            else if (SharedVar.power > 129)
            {
                storyLabel2.Text = "You survived and managed to grow your vampiric strenght. Now you can easily fight against the villagers and continue to live your eternal life.";
            }
            else if (SharedVar.wisdom > 40)
            {
                storyLabel2.Text = "You survived and managed to expand your wisdom. With your new aquired knowledge you can start life amongst the villagers again.";
            }
            else
            {
                storyLabel2.Text = "You survived but now you will have to live your life out in hiding from the villagers due to your insufficient abilities.";
            }
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            storyLabel3.Visible = true;
            storyLabel2.Visible = false;
            timeRemainingLabel.Visible = false;
            playerNameLabel.Visible = false;
            powerLabel.Visible = false;
            lifeLabel.Visible = false;
            wisdomLabel.Visible = false;
            moralityLabel.Visible = false;
            restartButton.Visible = true;
            endGameButton.Visible = false;

            storyLabel3.Text = "Thank you " + SharedVar.playerName + ", for playing the game :D";
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Restart();
            Environment.Exit(0);
        }
    }
}
