namespace MethodCalculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Max(object sender, EventArgs e)
    {
        if (double.TryParse(textBox1.Text, out double x) && double.TryParse(textBox2.Text, out double y))
        {
            if (x > y)
            {
                label3.Text = "Max: " + x;
            }
            else
            {
                label3.Text = "Max: " + y;
            }
        }
        else
        {
            label3.Text = "Enter valid x and y";
        }
    }

    private void Power(object sender, EventArgs e)
    {
        if (double.TryParse(textBox1.Text, out double x) && double.TryParse(textBox2.Text, out double y))
        {
            double answer = Math.Pow(x, y);

            if (double.IsNaN(answer) || double.IsInfinity(answer))
            {
                label3.Text = "Invalid result";
            }
            else
            {
                label3.Text = "Power: " + answer;
            }
        }
        else
        {
            label3.Text = "Enter valid x and y";
        }
    }

    private void IsPrime(object sender, EventArgs e)
    {
        if (int.TryParse(textBox1.Text, out int x))
        {
            bool prime = true;

            if (x < 2)
            {
                prime = false;
            }

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                label3.Text = x + " is prime";
            }
            else
            {
                label3.Text = x + " is not prime";
            }
        }
        else
        {
            label3.Text = "Enter a whole number in x";
        }
    }

    private void Factorial(object sender, EventArgs e)
    {
        if (int.TryParse(textBox1.Text, out int x) && x >= 0 && x <= 20)
        {
            long answer = 1;

            for (int i = 1; i <= x; i++)
            {
                answer = answer * i;
            }

            label3.Text = "Factorial: " + answer;
        }
        else
        {
            label3.Text = "Enter a whole number from 0 to 20 in x";
        }
    }
}
