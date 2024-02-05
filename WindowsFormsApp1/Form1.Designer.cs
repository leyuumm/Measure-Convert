namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.CentimetersTextBox = new System.Windows.Forms.TextBox();
            this.YardsTextBox = new System.Windows.Forms.TextBox();
            this.YardsLabel = new System.Windows.Forms.Label();
            this.FeetTextBox = new System.Windows.Forms.TextBox();
            this.FeetLabel = new System.Windows.Forms.Label();
            this.InchesTextBox = new System.Windows.Forms.TextBox();
            this.InchesLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length in centimeters :";
            // 
            // CentimetersTextBox
            // 
            this.CentimetersTextBox.Location = new System.Drawing.Point(338, 88);
            this.CentimetersTextBox.Name = "CentimetersTextBox";
            this.CentimetersTextBox.Size = new System.Drawing.Size(115, 20);
            this.CentimetersTextBox.TabIndex = 1;
            // 
            // YardsTextBox
            // 
            this.YardsTextBox.Location = new System.Drawing.Point(122, 161);
            this.YardsTextBox.Name = "YardsTextBox";
            this.YardsTextBox.Size = new System.Drawing.Size(28, 20);
            this.YardsTextBox.TabIndex = 2;
            // 
            // YardsLabel
            // 
            this.YardsLabel.AutoSize = true;
            this.YardsLabel.Location = new System.Drawing.Point(156, 164);
            this.YardsLabel.Name = "YardsLabel";
            this.YardsLabel.Size = new System.Drawing.Size(40, 13);
            this.YardsLabel.TabIndex = 3;
            this.YardsLabel.Text = ": Yards";
            // 
            // FeetTextBox
            // 
            this.FeetTextBox.Location = new System.Drawing.Point(357, 161);
            this.FeetTextBox.Name = "FeetTextBox";
            this.FeetTextBox.Size = new System.Drawing.Size(27, 20);
            this.FeetTextBox.TabIndex = 4;
            // 
            // FeetLabel
            // 
            this.FeetLabel.AutoSize = true;
            this.FeetLabel.Location = new System.Drawing.Point(390, 164);
            this.FeetLabel.Name = "FeetLabel";
            this.FeetLabel.Size = new System.Drawing.Size(34, 13);
            this.FeetLabel.TabIndex = 5;
            this.FeetLabel.Text = ": Feet";
            // 
            // InchesTextBox
            // 
            this.InchesTextBox.Location = new System.Drawing.Point(550, 161);
            this.InchesTextBox.Name = "InchesTextBox";
            this.InchesTextBox.Size = new System.Drawing.Size(29, 20);
            this.InchesTextBox.TabIndex = 6;
            // 
            // InchesLabel
            // 
            this.InchesLabel.AutoSize = true;
            this.InchesLabel.Location = new System.Drawing.Point(585, 164);
            this.InchesLabel.Name = "InchesLabel";
            this.InchesLabel.Size = new System.Drawing.Size(45, 13);
            this.InchesLabel.TabIndex = 7;
            this.InchesLabel.Text = ": Inches";
            // 
            // CalculateButton
            // 
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateButton.Location = new System.Drawing.Point(338, 248);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(86, 35);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InchesLabel);
            this.Controls.Add(this.InchesTextBox);
            this.Controls.Add(this.FeetLabel);
            this.Controls.Add(this.FeetTextBox);
            this.Controls.Add(this.YardsLabel);
            this.Controls.Add(this.YardsTextBox);
            this.Controls.Add(this.CentimetersTextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Measure Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CentimetersTextBox;
        private System.Windows.Forms.TextBox YardsTextBox;
        private System.Windows.Forms.Label YardsLabel;
        private System.Windows.Forms.TextBox FeetTextBox;
        private System.Windows.Forms.Label FeetLabel;
        private System.Windows.Forms.TextBox InchesTextBox;
        private System.Windows.Forms.Label InchesLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}

