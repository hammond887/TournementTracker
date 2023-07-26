namespace TrackerUI
{
    partial class CreateTeamForm
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
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            CreateTournamentLabel = new Label();
            addTeamButton = new Button();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            phoneValue = new TextBox();
            phoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            createTournamentButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.ForeColor = Color.Coral;
            tournamentNameValue.Location = new Point(16, 89);
            tournamentNameValue.Margin = new Padding(3, 4, 3, 4);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(202, 27);
            tournamentNameValue.TabIndex = 28;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.Coral;
            tournamentNameLabel.Location = new Point(16, 57);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(114, 28);
            tournamentNameLabel.TabIndex = 27;
            tournamentNameLabel.Text = "Team Name";
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentLabel.ForeColor = Color.Coral;
            CreateTournamentLabel.Location = new Point(16, 12);
            CreateTournamentLabel.Margin = new Padding(6, 0, 6, 0);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(147, 32);
            CreateTournamentLabel.TabIndex = 26;
            CreateTournamentLabel.Text = "Create Team";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.Coral;
            addTeamButton.Location = new Point(50, 255);
            addTeamButton.Margin = new Padding(3, 4, 3, 4);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(144, 43);
            addTeamButton.TabIndex = 34;
            addTeamButton.Text = "Add Member";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(16, 197);
            selectTeamDropDown.Margin = new Padding(3, 4, 3, 4);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(202, 28);
            selectTeamDropDown.TabIndex = 32;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.Coral;
            selectTeamLabel.Location = new Point(16, 151);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.RightToLeft = RightToLeft.Yes;
            selectTeamLabel.Size = new Size(193, 28);
            selectTeamLabel.TabIndex = 35;
            selectTeamLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(phoneValue);
            addNewMemberGroupBox.Controls.Add(phoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(16, 320);
            addNewMemberGroupBox.Margin = new Padding(3, 4, 3, 4);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Padding = new Padding(3, 4, 3, 4);
            addNewMemberGroupBox.Size = new Size(231, 264);
            addNewMemberGroupBox.TabIndex = 36;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.Coral;
            createMemberButton.Location = new Point(34, 195);
            createMemberButton.Margin = new Padding(3, 4, 3, 4);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(159, 49);
            createMemberButton.TabIndex = 37;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // phoneValue
            // 
            phoneValue.BorderStyle = BorderStyle.FixedSingle;
            phoneValue.Location = new Point(110, 145);
            phoneValue.Margin = new Padding(3, 4, 3, 4);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(114, 27);
            phoneValue.TabIndex = 21;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.ForeColor = Color.Coral;
            phoneLabel.Location = new Point(13, 145);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(67, 28);
            phoneLabel.TabIndex = 20;
            phoneLabel.Text = "Phone";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Location = new Point(110, 107);
            emailValue.Margin = new Padding(3, 4, 3, 4);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(114, 27);
            emailValue.TabIndex = 19;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.Coral;
            emailLabel.Location = new Point(13, 107);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 28);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Location = new Point(110, 68);
            lastNameValue.Margin = new Padding(3, 4, 3, 4);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(114, 27);
            lastNameValue.TabIndex = 17;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.Coral;
            lastNameLabel.Location = new Point(13, 68);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(94, 28);
            lastNameLabel.TabIndex = 16;
            lastNameLabel.Text = "Lastname";
            lastNameLabel.Click += label1_Click;
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Location = new Point(109, 29);
            firstNameValue.Margin = new Padding(3, 4, 3, 4);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(114, 27);
            firstNameValue.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.Coral;
            firstNameLabel.Location = new Point(11, 29);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 28);
            firstNameLabel.TabIndex = 14;
            firstNameLabel.Text = "Firstname";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 28;
            teamMembersListBox.Location = new Point(277, 89);
            teamMembersListBox.Margin = new Padding(3, 4, 3, 4);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(250, 480);
            teamMembersListBox.TabIndex = 37;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPlayerButton.ForeColor = Color.Coral;
            deleteSelectedPlayerButton.Location = new Point(544, 292);
            deleteSelectedPlayerButton.Margin = new Padding(3, 4, 3, 4);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(144, 85);
            deleteSelectedPlayerButton.TabIndex = 38;
            deleteSelectedPlayerButton.Text = "Delete Selected Member";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.Coral;
            createTournamentButton.Location = new Point(277, 597);
            createTournamentButton.Margin = new Padding(3, 4, 3, 4);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(183, 41);
            createTournamentButton.TabIndex = 40;
            createTournamentButton.Text = "Create Team";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 655);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(addTeamButton);
            Controls.Add(selectTeamDropDown);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(CreateTournamentLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private Label CreateTournamentLabel;
        private Button addTeamButton;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox phoneValue;
        private Label phoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}