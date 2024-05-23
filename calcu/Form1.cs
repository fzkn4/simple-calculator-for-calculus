using Guna.UI2.WinForms;
using System.Configuration;

namespace calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (input.Text.Length !> 0)
            {
                calculate_statement(input.Text);
                statement.Text = input.Text;
                input.Clear();
                valueOfX.Clear();
            }
            else
            {
                input.Clear();
                valueOfX.Clear();
                result.Text = "0";
                statement.Text = "0";
            }
            copy_to_clipboard.Enabled = true;


        }

        private void calculate_statement(string statement)
        {
            string[] s = statement.Split(' ');

            double ans = calc_helper(s[0], Convert.ToDouble(valueOfX.Text));
            double carry = calc_helper(s[2], Convert.ToDouble(valueOfX.Text));
            for (int i = 1; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    carry = calc_helper(s[i], Convert.ToDouble(valueOfX.Text));
                }
                else
                {
                    ans = operation(ans, carry, Convert.ToChar(s[i]));
                }
            }

            result.Text = ans.ToString();
        }
        private double calc_helper(string statement, double x_value)
        {
            string carry = "";
            double result = 0;
            if (statement.All(char.IsDigit))
            {
                return Convert.ToDouble(statement);
            }
            else
            {
                for (int i = 0; i < statement.Length; i++)
                {
                    if (statement[i] == '^') break;
                    carry += statement[i];
                }


                if (statement.IndexOf('^') != -1)
                {

                    result = Math.Pow(calculates(carry, x_value), Convert.ToDouble(statement[statement.Length - 1].ToString()));
                }
                else
                {
                    result = calculates(statement, x_value);
                }
            }

            return result;

        }
        private double calculates(string statement, double xvalue)
        {
            string carry = "";
            for (int i = 0; i < statement.Length; i++)
            {
                if (statement[i] == 'x') break;
                carry += statement[i];

            }
            return Convert.ToDouble(carry) * xvalue;
        }

        private double operation(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                    break;
                case '-':
                    return num1 - num2;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void calculate_fraction()
        {

        }

        private void copy_to_clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(statement.Text);
            copy_to_clipboard.Enabled = false;
        }
    }
}
