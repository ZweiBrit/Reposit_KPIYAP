namespace MatrixSumApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox matrixTextBox;
        private TextBox sumTextBox;
        private Label matrixLabel;
        private Label sumLabel;

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
            this.matrixTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.matrixLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matrixTextBox
            // 
            this.matrixTextBox.Location = new System.Drawing.Point(12, 29);
            this.matrixTextBox.Multiline = true;
            this.matrixTextBox.Name = "matrixTextBox";
            this.matrixTextBox.ReadOnly = true;
            this.matrixTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matrixTextBox.Size = new System.Drawing.Size(400, 300);
            this.matrixTextBox.TabIndex = 0;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(12, 355);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 1;
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Location = new System.Drawing.Point(12, 13);
            this.matrixLabel.Name = "matrixLabel";
            this.matrixLabel.Size = new System.Drawing.Size(39, 13);
            this.matrixLabel.TabIndex = 2;
            this.matrixLabel.Text = "Matrix:";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(12, 339);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(31, 13);
            this.sumLabel.TabIndex = 3;
            this.sumLabel.Text = "Sum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 391);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.matrixLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.matrixTextBox);
            this.Name = "MainForm";
            this.Text = "Matrix Sum App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
