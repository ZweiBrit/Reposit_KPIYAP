namespace WinFormsApp2
{
    partial class Form1
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
            textBoxResult = new TextBox();
            textBoxX = new TextBox();
            textBoxZ = new TextBox();
            textBoxY = new TextBox();
            calculateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(16, 133);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 0;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(16, 34);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 1;
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(16, 100);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(125, 27);
            textBoxZ.TabIndex = 2;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(16, 67);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(125, 27);
            textBoxY.TabIndex = 3;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(163, 133);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(92, 29);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Посчитать";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.MouseClick += calculateButton_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Введите Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 103);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 7;
            label3.Text = "Введите Z";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calculateButton);
            Controls.Add(textBoxY);
            Controls.Add(textBoxZ);
            Controls.Add(textBoxX);
            Controls.Add(textBoxResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult;
        private TextBox textBoxX;
        private TextBox textBoxZ;
        private TextBox textBoxY;
        private Button calculateButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
