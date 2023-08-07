namespace TrackerUI
{
    partial class CreateTournamentForm
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
            tournamentNameText = new TextBox();
            tournamentNameLabel = new Label();
            CreateTournamentLabel = new Label();
            entryFeeLabel = new Label();
            entryFeeText = new TextBox();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeam = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentNameText
            // 
            tournamentNameText.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameText.ForeColor = Color.Coral;
            tournamentNameText.Location = new Point(16, 93);
            tournamentNameText.Margin = new Padding(3, 4, 3, 4);
            tournamentNameText.Name = "tournamentNameText";
            tournamentNameText.Size = new Size(202, 27);
            tournamentNameText.TabIndex = 25;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.Coral;
            tournamentNameLabel.Location = new Point(16, 61);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(173, 28);
            tournamentNameLabel.TabIndex = 18;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentLabel.ForeColor = Color.Coral;
            CreateTournamentLabel.Location = new Point(16, 16);
            CreateTournamentLabel.Margin = new Padding(6, 0, 6, 0);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(224, 32);
            CreateTournamentLabel.TabIndex = 16;
            CreateTournamentLabel.Text = "Create Tournament:";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.Coral;
            entryFeeLabel.Location = new Point(16, 159);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(96, 28);
            entryFeeLabel.TabIndex = 26;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // entryFeeText
            // 
            entryFeeText.BorderStyle = BorderStyle.FixedSingle;
            entryFeeText.ForeColor = Color.Coral;
            entryFeeText.Location = new Point(111, 159);
            entryFeeText.Margin = new Padding(3, 4, 3, 4);
            entryFeeText.Name = "entryFeeText";
            entryFeeText.Size = new Size(91, 27);
            entryFeeText.TabIndex = 27;
            entryFeeText.Text = "0";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(16, 255);
            selectTeamDropDown.Margin = new Padding(3, 4, 3, 4);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(202, 28);
            selectTeamDropDown.TabIndex = 29;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.Coral;
            selectTeamLabel.Location = new Point(13, 223);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.RightToLeft = RightToLeft.Yes;
            selectTeamLabel.Size = new Size(114, 28);
            selectTeamLabel.TabIndex = 28;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeam
            // 
            createNewTeam.AutoSize = true;
            createNewTeam.Location = new Point(133, 230);
            createNewTeam.Name = "createNewTeam";
            createNewTeam.Size = new Size(84, 20);
            createNewTeam.TabIndex = 30;
            createNewTeam.TabStop = true;
            createNewTeam.Text = "create New";
            createNewTeam.LinkClicked += createNewTeam_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.Coral;
            addTeamButton.Location = new Point(57, 308);
            addTeamButton.Margin = new Padding(3, 4, 3, 4);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(128, 43);
            addTeamButton.TabIndex = 31;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.Coral;
            createPrizeButton.Location = new Point(57, 359);
            createPrizeButton.Margin = new Padding(3, 4, 3, 4);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(128, 43);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 20;
            tournamentPlayersListBox.Location = new Point(243, 93);
            tournamentPlayersListBox.Margin = new Padding(3, 4, 3, 4);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(217, 104);
            tournamentPlayersListBox.TabIndex = 33;
            tournamentPlayersListBox.SelectedIndexChanged += tournamentPlayersListBox_SelectedIndexChanged;
            // 
            // tournamentPlayersLLabel
            // 
            tournamentPlayersLLabel.AutoSize = true;
            tournamentPlayersLLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLLabel.ForeColor = Color.Coral;
            tournamentPlayersLLabel.Location = new Point(243, 61);
            tournamentPlayersLLabel.Name = "tournamentPlayersLLabel";
            tournamentPlayersLLabel.RightToLeft = RightToLeft.Yes;
            tournamentPlayersLLabel.Size = new Size(144, 28);
            tournamentPlayersLLabel.TabIndex = 34;
            tournamentPlayersLLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPlayerButton.ForeColor = Color.Coral;
            deleteSelectedPlayerButton.Location = new Point(478, 112);
            deleteSelectedPlayerButton.Margin = new Padding(3, 4, 3, 4);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(101, 85);
            deleteSelectedPlayerButton.TabIndex = 35;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            deleteSelectedPlayerButton.Click += deleteSelectedPlayerButton_Click;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = Color.Coral;
            deleteSelectedPrizeButton.Location = new Point(478, 289);
            deleteSelectedPrizeButton.Margin = new Padding(3, 4, 3, 4);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(101, 81);
            deleteSelectedPrizeButton.TabIndex = 38;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            deleteSelectedPrizeButton.Click += deleteSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.Coral;
            prizesLabel.Location = new Point(243, 241);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.RightToLeft = RightToLeft.Yes;
            prizesLabel.Size = new Size(62, 28);
            prizesLabel.TabIndex = 37;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 20;
            prizesListBox.Location = new Point(243, 273);
            prizesListBox.Margin = new Padding(3, 4, 3, 4);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(217, 104);
            prizesListBox.TabIndex = 36;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.Coral;
            createTournamentButton.Location = new Point(243, 425);
            createTournamentButton.Margin = new Padding(3, 4, 3, 4);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(183, 41);
            createTournamentButton.TabIndex = 39;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(597, 497);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayersLLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeam);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeText);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameText);
            Controls.Add(tournamentNameLabel);
            Controls.Add(CreateTournamentLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button scoreButton;
        private Label versusLabel;
        private TextBox teamTwoScoreValue;
        private Label label3;
        private Label teamTwoName;
        private TextBox tournamentNameText;
        private Label teamOneScoreLabel;
        private Label label1;
        private Label teamOneName;
        private ListBox matchupListBox;
        private CheckBox unplayedOnlyCheckbox;
        private Label tournamentNameLabel;
        private Label tournamentName;
        private Label CreateTournamentLabel;
        private Label entryFeeLabel;
        private TextBox entryFeeText;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeam;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}