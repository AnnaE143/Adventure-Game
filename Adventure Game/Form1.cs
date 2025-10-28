using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            startGameButton.Visible = false;
            nameQuestionLabel.Visible = true;
            nameTextBox.Visible = true;
            storyLabel.Visible = true;
            continueButton.Visible = true;


        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //set the playername
            SharedVar.playerName = nameTextBox.Text;

            //create new form and open it
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
    public static class SharedVar
    {
        //Global Variables for all forms
        public static string playerName;
        public static int power = 100;
        public static int morality = 0;
        public static int life = 3;
        public static int wisdom = 0;
        public static int timeRemaining = 7;
        public static Boolean companionFound = false;

    }
}
