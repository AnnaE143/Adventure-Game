namespace Adventure_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.nameQuestionLabel = new System.Windows.Forms.Label();
            this.storyLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Viner Hand ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLabel.Location = new System.Drawing.Point(239, 183);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(318, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Until Dawn";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.DarkRed;
            this.startGameButton.Location = new System.Drawing.Point(302, 240);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(175, 34);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.DarkRed;
            this.continueButton.Location = new System.Drawing.Point(643, 404);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(145, 34);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // nameQuestionLabel
            // 
            this.nameQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameQuestionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameQuestionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.nameQuestionLabel.Location = new System.Drawing.Point(168, 7);
            this.nameQuestionLabel.Name = "nameQuestionLabel";
            this.nameQuestionLabel.Size = new System.Drawing.Size(309, 52);
            this.nameQuestionLabel.TabIndex = 3;
            this.nameQuestionLabel.Text = "Please enter your name:";
            this.nameQuestionLabel.Visible = false;
            // 
            // storyLabel
            // 
            this.storyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.storyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storyLabel.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.Location = new System.Drawing.Point(167, 59);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(419, 379);
            this.storyLabel.TabIndex = 4;
            this.storyLabel.Text = resources.GetString("storyLabel.Text");
            this.storyLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.DarkRed;
            this.nameTextBox.Location = new System.Drawing.Point(474, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(112, 45);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Adventure_Game.Properties.Resources.dreieichehainer_burgruine_bei_nacht_b606e313_cb5e_4ec4_a8ef_94295b7ffcee;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.nameQuestionLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Until Dawn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label nameQuestionLabel;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

