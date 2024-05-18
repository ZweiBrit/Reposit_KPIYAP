namespace TwoFormsApp
{
    partial class StartForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button openSecondFormButton;

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
            this.openSecondFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openSecondFormButton
            // 
            this.openSecondFormButton.Location = new System.Drawing.Point(12, 12);
            this.openSecondFormButton.Name = "openSecondFormButton";
            this.openSecondFormButton.Size = new System.Drawing.Size(260, 23);
            this.openSecondFormButton.TabIndex = 0;
            this.openSecondFormButton.Text = "Open Second Form";
            this.openSecondFormButton.UseVisualStyleBackColor = true;
            this.openSecondFormButton.Click += new System.EventHandler(this.openSecondFormButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openSecondFormButton);
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.ResumeLayout(false);

        }
    }
}
