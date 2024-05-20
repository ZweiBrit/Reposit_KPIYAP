namespace WinFormsApp3
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
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            calculateButton = new Button();
            shRadioButton = new RadioButton();
            squareRadioButton = new RadioButton();
            expRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(22, 23);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(125, 27);
            inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(22, 68);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(125, 27);
            outputTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(36, 116);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Расчитать";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.MouseClick += calculateButton_MouseClick;
            // 
            // shRadioButton
            // 
            shRadioButton.AutoSize = true;
            shRadioButton.Location = new Point(244, 23);
            shRadioButton.Name = "shRadioButton";
            shRadioButton.Size = new Size(61, 24);
            shRadioButton.TabIndex = 3;
            shRadioButton.TabStop = true;
            shRadioButton.Text = "sh(x)";
            shRadioButton.UseVisualStyleBackColor = true;
            // 
            // squareRadioButton
            // 
            squareRadioButton.AutoSize = true;
            squareRadioButton.Location = new Point(244, 53);
            squareRadioButton.Name = "squareRadioButton";
            squareRadioButton.Size = new Size(55, 24);
            squareRadioButton.TabIndex = 4;
            squareRadioButton.TabStop = true;
            squareRadioButton.Text = "x^2";
            squareRadioButton.UseVisualStyleBackColor = true;
            // 
            // expRadioButton
            // 
            expRadioButton.AutoSize = true;
            expRadioButton.Location = new Point(244, 83);
            expRadioButton.Name = "expRadioButton";
            expRadioButton.Size = new Size(55, 24);
            expRadioButton.TabIndex = 5;
            expRadioButton.TabStop = true;
            expRadioButton.Text = "e^x";
            expRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(expRadioButton);
            Controls.Add(squareRadioButton);
            Controls.Add(shRadioButton);
            Controls.Add(calculateButton);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button calculateButton;
        private RadioButton shRadioButton;
        private RadioButton squareRadioButton;
        private RadioButton expRadioButton;
    }
}
