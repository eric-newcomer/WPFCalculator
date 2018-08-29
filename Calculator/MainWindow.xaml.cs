using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CalcInput.Text.Contains("="))
            {
                CalcInput.Text = "";
            }
            Button b = (Button) sender;
            CalcInput.Text += b.Content.ToString();
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                CalcInput.Text = "Error!";
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (CalcInput.Text.Contains("+"))
            {
                iOp = CalcInput.Text.IndexOf("+");
            }
            else if (CalcInput.Text.Contains("-"))
            {
                iOp = CalcInput.Text.IndexOf("-");
            }
            else if (CalcInput.Text.Contains("*"))
            {
                iOp = CalcInput.Text.IndexOf("*");
            }
            else if (CalcInput.Text.Contains("/"))
            {
                iOp = CalcInput.Text.IndexOf("/");
            }
            else
            {
                //error!
            }

            op = CalcInput.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(CalcInput.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(CalcInput.Text.Substring(iOp + 1, CalcInput.Text.Length - iOp - 1));

            if (op == "+")
            {
                CalcInput.Text += " = " + (op1 + op2);
            }
            else if (op == "-")
            {
                CalcInput.Text += " = " + (op1 - op2);
            }
            else if (op == "*")
            {
                CalcInput.Text += " = " + (op1 * op2);
            }
            else 
            {
                CalcInput.Text += " = " + (op1 / op2);
            }
        }
    }
}
