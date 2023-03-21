namespace TrackerUI
{
    partial class TournamentViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentLabel = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoName = new Label();
            teamTeamTwoScoreLabel = new Label();
            teamTwoScoreValue = new TextBox();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(271, 62);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentLabel.Location = new Point(289, 9);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(189, 62);
            tournamentLabel.TabIndex = 1;
            tournamentLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(12, 88);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(117, 46);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(138, 101);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(257, 28);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckBox.Location = new Point(138, 135);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(257, 50);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 20;
            matchupListBox.Location = new Point(12, 193);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(383, 242);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(443, 191);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(208, 46);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            teamOneName.Click += teamOneName_Click;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(443, 238);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(104, 46);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            teamOneScoreLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(553, 249);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(98, 27);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(443, 332);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(208, 46);
            teamTwoName.TabIndex = 6;
            teamTwoName.Text = "<team two>";
            teamTwoName.Click += teamTwoName_Click;
            // 
            // teamTeamTwoScoreLabel
            // 
            teamTeamTwoScoreLabel.AutoSize = true;
            teamTeamTwoScoreLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamTeamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTeamTwoScoreLabel.Location = new Point(443, 379);
            teamTeamTwoScoreLabel.Name = "teamTeamTwoScoreLabel";
            teamTeamTwoScoreLabel.Size = new Size(104, 46);
            teamTeamTwoScoreLabel.TabIndex = 7;
            teamTeamTwoScoreLabel.Text = "Score";
            teamTeamTwoScoreLabel.Click += teamTeamTwoScoreLabel_Click;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(553, 392);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(98, 27);
            teamTwoScoreValue.TabIndex = 8;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(519, 285);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(87, 46);
            versusLabel.TabIndex = 9;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(696, 277);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(136, 66);
            scoreButton.TabIndex = 10;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 693);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamTeamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentLabel);
            Controls.Add(headerLabel);
            Name = "TournamentViewForm";
            Text = "Form1";
            Load += TournamentViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentLabel;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private Label teamTwoName;
        private Label teamTeamTwoScoreLabel;
        private TextBox teamTwoScoreValue;
        private Label versusLabel;
        private Button scoreButton;
    }
}