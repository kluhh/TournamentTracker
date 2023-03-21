namespace TrackerUI
{
    partial class tournamentDashboardForm
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
            headerLabel = new Label();
            loadExistingLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            loadExistingTournamentDropDown = new ComboBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(94, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(488, 62);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingLabel
            // 
            loadExistingLabel.AutoSize = true;
            loadExistingLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingLabel.Location = new Point(144, 97);
            loadExistingLabel.Name = "loadExistingLabel";
            loadExistingLabel.Size = new Size(388, 46);
            loadExistingLabel.TabIndex = 14;
            loadExistingLabel.Text = "Load Existing Tournment";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(214, 225);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(249, 58);
            loadTournamentButton.TabIndex = 20;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(181, 313);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(314, 97);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(135, 162);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(406, 45);
            loadExistingTournamentDropDown.TabIndex = 27;
            // 
            // tournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 466);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(6, 6, 6, 6);
            Name = "tournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label loadExistingLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
        private ComboBox loadExistingTournamentDropDown;
    }
}