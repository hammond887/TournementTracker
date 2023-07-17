namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeLabel = new Label();
            createPrizeButton = new Button();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizeNameValue = new TextBox();
            prizeNameLabel = new Label();
            prizeNumberValue = new TextBox();
            prizeNumberLabel = new Label();
            orLabel = new Label();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePrizeLabel.ForeColor = Color.Coral;
            CreatePrizeLabel.Location = new Point(14, 9);
            CreatePrizeLabel.Margin = new Padding(5, 0, 5, 0);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(114, 25);
            CreatePrizeLabel.TabIndex = 41;
            CreatePrizeLabel.Text = "Create Prize";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.Coral;
            createPrizeButton.Location = new Point(61, 206);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(139, 40);
            createPrizeButton.TabIndex = 59;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.Location = new Point(146, 162);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(100, 23);
            prizePercentageValue.TabIndex = 58;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.Coral;
            prizePercentageLabel.Location = new Point(14, 162);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(124, 21);
            prizePercentageLabel.TabIndex = 57;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountValue.Location = new Point(146, 105);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(100, 23);
            prizeAmountValue.TabIndex = 56;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.Coral;
            prizeAmountLabel.Location = new Point(14, 105);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(104, 21);
            prizeAmountLabel.TabIndex = 55;
            prizeAmountLabel.Text = "Prize Amount";
            prizeAmountLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // prizeNameValue
            // 
            prizeNameValue.BorderStyle = BorderStyle.FixedSingle;
            prizeNameValue.Location = new Point(146, 76);
            prizeNameValue.Name = "prizeNameValue";
            prizeNameValue.Size = new Size(100, 23);
            prizeNameValue.TabIndex = 54;
            // 
            // prizeNameLabel
            // 
            prizeNameLabel.AutoSize = true;
            prizeNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeNameLabel.ForeColor = Color.Coral;
            prizeNameLabel.Location = new Point(14, 76);
            prizeNameLabel.Name = "prizeNameLabel";
            prizeNameLabel.Size = new Size(92, 21);
            prizeNameLabel.TabIndex = 53;
            prizeNameLabel.Text = "Place Name";
            // 
            // prizeNumberValue
            // 
            prizeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            prizeNumberValue.Location = new Point(146, 47);
            prizeNumberValue.Name = "prizeNumberValue";
            prizeNumberValue.Size = new Size(100, 23);
            prizeNumberValue.TabIndex = 52;
            // 
            // prizeNumberLabel
            // 
            prizeNumberLabel.AutoSize = true;
            prizeNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeNumberLabel.ForeColor = Color.Coral;
            prizeNumberLabel.Location = new Point(13, 47);
            prizeNumberLabel.Name = "prizeNumberLabel";
            prizeNumberLabel.Size = new Size(108, 21);
            prizeNumberLabel.TabIndex = 51;
            prizeNumberLabel.Text = "Place Number";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.Coral;
            orLabel.Location = new Point(101, 134);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(45, 21);
            orLabel.TabIndex = 60;
            orLabel.Text = "- or -";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(286, 286);
            Controls.Add(orLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizeNameValue);
            Controls.Add(prizeNameLabel);
            Controls.Add(prizeNumberValue);
            Controls.Add(prizeNumberLabel);
            Controls.Add(CreatePrizeLabel);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CreatePrizeLabel;
        private Button createPrizeButton;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizeNameValue;
        private Label prizeNameLabel;
        private TextBox prizeNumberValue;
        private Label prizeNumberLabel;
        private Label orLabel;
    }
}