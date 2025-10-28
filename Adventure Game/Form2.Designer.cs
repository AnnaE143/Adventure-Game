namespace Adventure_Game
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.storyLabel2 = new System.Windows.Forms.Label();
            this.decision11Button = new System.Windows.Forms.Button();
            this.decision12Button = new System.Windows.Forms.Button();
            this.decision13Button = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.moralityLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storyLabel2
            // 
            this.storyLabel2.BackColor = System.Drawing.Color.Transparent;
            this.storyLabel2.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.storyLabel2.Location = new System.Drawing.Point(45, 19);
            this.storyLabel2.Name = "storyLabel2";
            this.storyLabel2.Size = new System.Drawing.Size(715, 176);
            this.storyLabel2.TabIndex = 0;
            this.storyLabel2.Text = "You were discovered in your hideout. The villagers are on their way to get you so" +
    " you have to leave as quickly as possible.\r\nYou can only take one item with you." +
    " Do you choose...";
            // 
            // decision11Button
            // 
            this.decision11Button.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decision11Button.ForeColor = System.Drawing.Color.DarkRed;
            this.decision11Button.Location = new System.Drawing.Point(52, 160);
            this.decision11Button.Name = "decision11Button";
            this.decision11Button.Size = new System.Drawing.Size(198, 185);
            this.decision11Button.TabIndex = 1;
            this.decision11Button.Text = "...the ancient tome on the shelf.";
            this.decision11Button.UseVisualStyleBackColor = true;
            this.decision11Button.Click += new System.EventHandler(this.decision11Button_Click);
            // 
            // decision12Button
            // 
            this.decision12Button.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decision12Button.ForeColor = System.Drawing.Color.DarkRed;
            this.decision12Button.Location = new System.Drawing.Point(294, 160);
            this.decision12Button.Name = "decision12Button";
            this.decision12Button.Size = new System.Drawing.Size(198, 185);
            this.decision12Button.TabIndex = 2;
            this.decision12Button.Text = "...to pick up the ruby amulet from the floor.";
            this.decision12Button.UseVisualStyleBackColor = true;
            this.decision12Button.Click += new System.EventHandler(this.decision12Button_Click);
            // 
            // decision13Button
            // 
            this.decision13Button.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decision13Button.ForeColor = System.Drawing.Color.DarkRed;
            this.decision13Button.Location = new System.Drawing.Point(546, 160);
            this.decision13Button.Name = "decision13Button";
            this.decision13Button.Size = new System.Drawing.Size(198, 185);
            this.decision13Button.TabIndex = 3;
            this.decision13Button.Text = "...to leave immediately without taking anything.";
            this.decision13Button.UseVisualStyleBackColor = true;
            this.decision13Button.Click += new System.EventHandler(this.decision13Button_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.playerNameLabel.Location = new System.Drawing.Point(12, 418);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(238, 23);
            this.playerNameLabel.TabIndex = 4;
            this.playerNameLabel.Text = "Playername: ";
            // 
            // powerLabel
            // 
            this.powerLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.powerLabel.Location = new System.Drawing.Point(225, 418);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(113, 23);
            this.powerLabel.TabIndex = 5;
            this.powerLabel.Text = "Power: 100";
            // 
            // lifeLabel
            // 
            this.lifeLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lifeLabel.Location = new System.Drawing.Point(344, 418);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(80, 23);
            this.lifeLabel.TabIndex = 6;
            this.lifeLabel.Text = "Life: 3";
            this.lifeLabel.Click += new System.EventHandler(this.lifeLabel_Click);
            // 
            // moralityLabel
            // 
            this.moralityLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralityLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.moralityLabel.Location = new System.Drawing.Point(430, 418);
            this.moralityLabel.Name = "moralityLabel";
            this.moralityLabel.Size = new System.Drawing.Size(129, 23);
            this.moralityLabel.TabIndex = 7;
            this.moralityLabel.Text = "Morality: 0";
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wisdomLabel.Location = new System.Drawing.Point(565, 418);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(152, 23);
            this.wisdomLabel.TabIndex = 8;
            this.wisdomLabel.Text = "Wisdom: 0";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemainingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.timeRemainingLabel.Location = new System.Drawing.Point(12, 362);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(286, 36);
            this.timeRemainingLabel.TabIndex = 9;
            this.timeRemainingLabel.Text = "Time remaining: ";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.DarkRed;
            this.continueButton.Location = new System.Drawing.Point(643, 364);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(145, 34);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Adventure_Game.Properties.Resources.dreieichehainer_burgruine_bei_nacht_b606e313_cb5e_4ec4_a8ef_94295b7ffcee;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.moralityLabel);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.decision13Button);
            this.Controls.Add(this.decision12Button);
            this.Controls.Add(this.decision11Button);
            this.Controls.Add(this.storyLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Until Dawn";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storyLabel2;
        private System.Windows.Forms.Button decision11Button;
        private System.Windows.Forms.Button decision12Button;
        private System.Windows.Forms.Button decision13Button;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label moralityLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Button continueButton;
    }
}