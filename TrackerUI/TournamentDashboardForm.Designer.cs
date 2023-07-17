namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            CreateTournamentLabel = new Label();
            loadExsistingTournamentDropDown = new ComboBox();
            loadExsistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentLabel.ForeColor = Color.Coral;
            CreateTournamentLabel.Location = new Point(63, 24);
            CreateTournamentLabel.Margin = new Padding(5, 0, 5, 0);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(231, 30);
            CreateTournamentLabel.TabIndex = 61;
            CreateTournamentLabel.Text = "Tournament Dashboard";
            // 
            // loadExsistingTournamentDropDown
            // 
            loadExsistingTournamentDropDown.FormattingEnabled = true;
            loadExsistingTournamentDropDown.Location = new Point(126, 101);
            loadExsistingTournamentDropDown.Name = "loadExsistingTournamentDropDown";
            loadExsistingTournamentDropDown.Size = new Size(104, 23);
            loadExsistingTournamentDropDown.TabIndex = 63;
            // 
            // loadExsistingTournamentLabel
            // 
            loadExsistingTournamentLabel.AutoSize = true;
            loadExsistingTournamentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadExsistingTournamentLabel.ForeColor = Color.Coral;
            loadExsistingTournamentLabel.Location = new Point(81, 67);
            loadExsistingTournamentLabel.Name = "loadExsistingTournamentLabel";
            loadExsistingTournamentLabel.RightToLeft = RightToLeft.Yes;
            loadExsistingTournamentLabel.Size = new Size(195, 21);
            loadExsistingTournamentLabel.TabIndex = 62;
            loadExsistingTournamentLabel.Text = "Load Exsisting Tournament";
            loadExsistingTournamentLabel.Click += selectTeamLabel_Click;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.Coral;
            loadTournamentButton.Location = new Point(99, 154);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(159, 40);
            loadTournamentButton.TabIndex = 64;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.Coral;
            createTournamentButton.Location = new Point(99, 211);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(159, 40);
            createTournamentButton.TabIndex = 65;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(361, 290);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExsistingTournamentDropDown);
            Controls.Add(loadExsistingTournamentLabel);
            Controls.Add(CreateTournamentLabel);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CreateTournamentLabel;
        private ComboBox loadExsistingTournamentDropDown;
        private Label loadExsistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}