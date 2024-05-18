namespace ArrayReplacementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox originalArrayTextBox;
        private TextBox modifiedArrayTextBox;
        private Button replaceButton;
        private Label originalArrayLabel;
        private Label modifiedArrayLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.originalArrayTextBox = new System.Windows.Forms.TextBox();
            this.modifiedArrayTextBox = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.originalArrayLabel = new System.Windows.Forms.Label();
            this.modifiedArrayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalArrayTextBox
            // 
            this.originalArrayTextBox.Location = new System.Drawing.Point(12, 29);
            this.originalArrayTextBox.Name = "originalArrayTextBox";
            this.originalArrayTextBox.ReadOnly = true;
            this.originalArrayTextBox.Size = new System.Drawing.Size(360, 20);
            this.originalArrayTextBox.TabIndex = 0;
            // 
            // modifiedArrayTextBox
            // 
            this.modifiedArrayTextBox.Location = new System.Drawing.Point(12, 75);
            this.modifiedArrayTextBox.Name = "modifiedArrayTextBox";
            this.modifiedArrayTextBox.ReadOnly = true;
            this.modifiedArrayTextBox.Size = new System.Drawing.Size(360, 20);
            this.modifiedArrayTextBox.TabIndex = 1;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(297, 101);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // originalArrayLabel
            // 
            this.originalArrayLabel.AutoSize = true;
            this.originalArrayLabel.Location = new System.Drawing.Point(12, 13);
            this.originalArrayLabel.Name = "originalArrayLabel";
            this.originalArrayLabel.Size = new System.Drawing.Size(70, 13);
            this.originalArrayLabel.TabIndex = 3;
            this.originalArrayLabel.Text = "Original Array";
            // 
            // modifiedArrayLabel
            // 
            this.modifiedArrayLabel.AutoSize = true;
            this.modifiedArrayLabel.Location = new System.Drawing.Point(12, 59);
            this.modifiedArrayLabel.Name = "modifiedArrayLabel";
            this.modifiedArrayLabel.Size = new System.Drawing.Size(76, 13);
            this.modifiedArrayLabel.TabIndex = 4;
            this.modifiedArrayLabel.Text = "Modified Array";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.modifiedArrayLabel);
            this.Controls.Add(this.originalArrayLabel);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.modifiedArrayTextBox);
            this.Controls.Add(this.originalArrayTextBox);
            this.Name = "MainForm";
            this.Text = "Array Replacement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
