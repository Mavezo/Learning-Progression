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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool oper = false;
        double value1 = 0;
        double value2 = 0;
        char? znak = null;
        bool cleared = false;

        private void Clear_All(object sender, RoutedEventArgs e)
        {
            oper = false;
            value1 = 0;
            value2 = 0;
            znak = null;
            textbox1.Text = "";
            textbox2.Text = "0";
        }

        private void Clear_Line(object sender, RoutedEventArgs e)
        {
            textbox2.Text = "0";
        }

        private void Clear_Last(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text.Length > 0 && textbox2.Text != "0")
            {
                textbox2.Text = textbox2.Text.Substring(0, textbox2.Text.Length - 1);
            }
            if (textbox2.Text == "0" && oper == true)
            {
                znak = null;
                oper = false;
                cleared = true;
                textbox1.Text = textbox1.Text.Substring(0, textbox1.Text.Length - 3);

            }
            if (textbox2.Text.Length == 0)
            {
                textbox2.Text = $"{0}";
            }
      
        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            if(oper != false)
            {
                value2 = double.Parse(textbox2.Text);
                textbox1.Text += $"{value2} = ";

                switch (znak)
                {
                    case '/':
                        if (value2 == 0)
                        {
                            textbox2.Text += $"can't divide by zero!";
                        }
                        else
                        {
                            textbox2.Text = $"{Math.Round((value1 / value2), 5)}";
                        }
                        break;

                    case '*':
                            textbox2.Text = $"{Math.Round((value1 * value2), 5)}";
                        break;

                    case '+':
                        textbox2.Text = $"{Math.Round((value1 + value2), 5)}";
                        break;

                    case '-':
                        textbox2.Text = $"{Math.Round((value1 - value2), 5)}";
                        break;

                    default:
                        textbox1.Text = $"{value1} = ";
                        break;

                }






                oper = false;
            }

            else
            {
                if(double.TryParse(textbox1.Text, out value1))
                {
                    textbox1.Text = $"{value1} = ";
                    textbox2.Text = $"{value1}";
                    return;
                }
                value1 = double.Parse(textbox2.Text);
                textbox1.Text = $"{value1} = ";

            }
        }

        private void Dot(object sender, RoutedEventArgs e)
        {

        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            if (oper)
            {
                Equals(sender, e);
            }
            znak = '/';
            if (cleared)
            {
                oper = true;
                textbox1.Text += $" / ";
                textbox2.Text = "0";
                return;
            }
            value1 = double.Parse(textbox2.Text);
            oper = true;
            textbox2.Text = "0";
            textbox1.Text = $"{value1} / ";
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            if (oper)
            {
                Equals(sender, e);
            }
            znak = '*';
            if (cleared)
            {
                oper = true;
                textbox1.Text += $" * ";
                textbox2.Text = "0";
                return;
            }
            value1 = double.Parse(textbox2.Text);
            oper = true;
            textbox2.Text = "0";
            textbox1.Text = $"{value1} * ";

        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            if (oper)
            {
                Equals(sender, e);
            }
            znak = '-';
            if (cleared)
            {
                oper = true;
                textbox1.Text += $" - ";
                textbox2.Text = "0";
                return;
            }
            value1 = double.Parse(textbox2.Text);
            oper = true;
            textbox2.Text = "0";
            textbox1.Text = $"{value1} - ";

        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            if (oper)
            {
                Equals(sender, e);
            }
            znak = '+';
            if (cleared)
            {
                oper = true;
                textbox1.Text += $" + ";
                textbox2.Text = "0";
                return;
            }
            value1 = double.Parse(textbox2.Text);
            oper = true;
            textbox2.Text = "0";
            textbox1.Text = $"{value1} + ";
        }

        private void Nine(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{9}";
            }
            else textbox2.Text += $"{9}";
        }
        private void Eight(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{8}";
            }
            else textbox2.Text += $"{8}";
        }
        private void Seven(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{7}";
            }
            else textbox2.Text += $"{7}";
        }
        private void Six(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{6}";
            }
            else textbox2.Text += $"{6}";
        }
        private void Five(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{5}";
            }
            else textbox2.Text += $"{5}";
        }
        private void Four(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{4}";
            }
            else textbox2.Text += $"{4}";
        }
        private void Three(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{3}";
            }
            else textbox2.Text += $"{3}";
        }
        private void Two(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{2}";
            }
            else textbox2.Text += $"{2}";
        }
        private void One(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{1}";
            }
            else textbox2.Text += $"{1}";
        }
        private void Zero(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "0")
            {
                textbox2.Text = $"{0}";
            }
            else textbox2.Text += $"{0}";
        }


    }
}
