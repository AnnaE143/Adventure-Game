namespace Adventure_Game
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.storyLabel2 = new System.Windows.Forms.Label();
            this.endGameButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.moralityLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.storyLabel3 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storyLabel2
            // 
            this.storyLabel2.BackColor = System.Drawing.Color.Transparent;
            this.storyLabel2.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.storyLabel2.Location = new System.Drawing.Point(45, 14);
            this.storyLabel2.Name = "storyLabel2";
            this.storyLabel2.Size = new System.Drawing.Size(715, 264);
            this.storyLabel2.TabIndex = 66;
            this.storyLabel2.Text = "The sun is slowly coming up and you think you have lost the villagers.Now you nee" +
    "d to decide on your hideout for the day. \r\nDo you choose...";
            // 
            // endGameButton
            // 
            this.endGameButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameButton.ForeColor = System.Drawing.Color.DarkRed;
            this.endGameButton.Location = new System.Drawing.Point(643, 359);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(145, 34);
            this.endGameButton.TabIndex = 76;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerNameLabel.Location = new System.Drawing.Point(12, 413);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(210, 23);
            this.playerNameLabel.TabIndex = 70;
            this.playerNameLabel.Click += new System.EventHandler(this.playerNameLabel_Click);
            // 
            // powerLabel
            // 
            this.powerLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.powerLabel.Location = new System.Drawing.Point(225, 413);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(113, 23);
            this.powerLabel.TabIndex = 71;
            this.powerLabel.Text = "Power: ";
            // 
            // lifeLabel
            // 
            this.lifeLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lifeLabel.Location = new System.Drawing.Point(344, 413);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(80, 23);
            this.lifeLabel.TabIndex = 72;
            this.lifeLabel.Text = "Life: ";
            // 
            // moralityLabel
            // 
            this.moralityLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moralityLabel.Location = new System.Drawing.Point(430, 413);
            this.moralityLabel.Name = "moralityLabel";
            this.moralityLabel.Size = new System.Drawing.Size(129, 23);
            this.moralityLabel.TabIndex = 73;
            this.moralityLabel.Text = "Morality:";
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wisdomLabel.Location = new System.Drawing.Point(565, 413);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(152, 23);
            this.wisdomLabel.TabIndex = 74;
            this.wisdomLabel.Text = "Wisdom: ";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemainingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeRemainingLabel.Location = new System.Drawing.Point(12, 357);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(286, 36);
            this.timeRemainingLabel.TabIndex = 75;
            this.timeRemainingLabel.Text = "Time remaining: 0";
            // 
            // storyLabel3
            // 
            this.storyLabel3.BackColor = System.Drawing.Color.Transparent;
            this.storyLabel3.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel3.Location = new System.Drawing.Point(128, 128);
            this.storyLabel3.Name = "storyLabel3";
            this.storyLabel3.Size = new System.Drawing.Size(561, 136);
            this.storyLabel3.TabIndex = 77;
            this.storyLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.DarkRed;
            this.restartButton.Location = new System.Drawing.Point(643, 319);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(145, 34);
            this.restartButton.TabIndex = 78;
            this.restartButton.Text = "Restart Game";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::Adventure_Game.Properties.Resources.morgengrauen_in_eiselfing_vollformat_1f7518b1_53b6_49ce_aab6_e74f3ff2524a;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.storyLabel3);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.moralityLabel);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.storyLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "Until Dawn";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label storyLabel2;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label moralityLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label storyLabel3;
        private System.Windows.Forms.Button restartButton;
    }
}