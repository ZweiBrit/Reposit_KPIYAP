using System;
using System.Drawing;
using System.Windows.Forms;

public class MyForm : Form
{
    private TextBox textBox;
    private Button blockButton;
    private Button unblockButton;

    public MyForm()
    {
        textBox = new TextBox { Location = new Point(10, 10) };
        blockButton = new Button { Location = new Point(10, 40), Text = "блок" };
        unblockButton = new Button { Location = new Point(100, 40), Text = "разблок" };

        blockButton.Click += (sender, e) => textBox.Enabled = false;
        unblockButton.Click += (sender, e) => textBox.Enabled = true;
        this.Click += (sender, e) =>
        {
            this.BackColor = Color.Aqua;
            textBox.Visible = false;
            blockButton.Visible = false;
            unblockButton.Visible = false;
        };

        this.Controls.Add(textBox);
        this.Controls.Add(blockButton);
        this.Controls.Add(unblockButton);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MyForm());
    }
}
