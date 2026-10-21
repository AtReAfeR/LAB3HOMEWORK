namespace MethodCalculator;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        SuspendLayout();

        label1.AutoSize = true;
        label1.Location = new Point(40, 31);
        label1.Name = "label1";
        label1.Size = new Size(21, 20);
        label1.TabIndex = 0;
        label1.Text = "x:";

        label2.AutoSize = true;
        label2.Location = new Point(40, 82);
        label2.Name = "label2";
        label2.Size = new Size(21, 20);
        label2.TabIndex = 1;
        label2.Text = "y:";

        textBox1.Location = new Point(82, 28);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(285, 27);
        textBox1.TabIndex = 0;

        textBox2.Location = new Point(82, 79);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(285, 27);
        textBox2.TabIndex = 1;

        button1.Location = new Point(40, 135);
        button1.Name = "button1";
        button1.Size = new Size(77, 36);
        button1.TabIndex = 2;
        button1.Text = "Max";
        button1.UseVisualStyleBackColor = true;
        button1.Click += Max;

        button2.Location = new Point(123, 135);
        button2.Name = "button2";
        button2.Size = new Size(77, 36);
        button2.TabIndex = 3;
        button2.Text = "Power";
        button2.UseVisualStyleBackColor = true;
        button2.Click += Power;

        button3.Location = new Point(206, 135);
        button3.Name = "button3";
        button3.Size = new Size(77, 36);
        button3.TabIndex = 4;
        button3.Text = "IsPrime";
        button3.UseVisualStyleBackColor = true;
        button3.Click += IsPrime;

        button4.Location = new Point(289, 135);
        button4.Name = "button4";
        button4.Size = new Size(93, 36);
        button4.TabIndex = 5;
        button4.Text = "Factorial";
        button4.UseVisualStyleBackColor = true;
        button4.Click += Factorial;

        label3.AutoSize = true;
        label3.Location = new Point(40, 198);
        label3.Name = "label3";
        label3.Size = new Size(56, 20);
        label3.TabIndex = 6;
        label3.Text = "Result:";

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 253);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(textBox1);
        Controls.Add(textBox2);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(button3);
        Controls.Add(button4);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Method Calculator";
        ResumeLayout(false);
        PerformLayout();
    }
}
