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

namespace WpfApp13
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


        private void KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.LeftShift:
                    {
                        KeysLower();
                        break;
                    }
                case Key.RightShift:
                    {
                        KeysLower();
                        break;
                    }
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.LeftShift:
                    {
                        KeysUpper();
                        break;
                    }
                case Key.RightShift:
                    {
                        KeysUpper();
                        break;
                    }
            }
        }
        


        private void KeysLower()
        {
            Grid grid = this.Content as Grid;
            foreach (WrapPanel panel in grid.Children.OfType<WrapPanel>())
            {
                foreach (Button btn in panel.Children.OfType<Button>())
                {
                    switch (btn.Content.ToString())
                    {
                        case "!":
                            {
                                btn.Content = "1";
                                break;
                            }
                        case "@":
                            {
                                btn.Content = "2";
                                break;
                            }
                        case "#":
                            {
                                btn.Content = "3";
                                break;
                            }
                        case "$":
                            {
                                btn.Content = "4";
                                break;
                            }
                        case "%":
                            {
                                btn.Content = "5";
                                break;
                            }
                        case "^":
                            {
                                btn.Content = "6";
                                break;
                            }
                        case "&":
                            {
                                btn.Content = "7";
                                break;
                            }

                        case "*":
                            {
                                btn.Content = "8";
                                break;
                            }

                        case "(":
                            {
                                btn.Content = "9";
                                break;
                            }
                        case ")":
                            {
                                btn.Content = "0";
                                break;
                            }
                        case "_":
                            {
                                btn.Content = "-";
                                break;
                            }
                        case "+":
                            {
                                btn.Content = "=";
                                break;
                            }
                        case "~":
                            {
                                btn.Content = "`";
                                break;
                            }
                        case "{":
                            {
                                btn.Content = "[";
                                break;
                            }
                        case "}":
                            {
                                btn.Content = "]";
                                break;
                            }
                        case "|":
                            {
                                btn.Content = "\\";
                                break;
                            }
                        case ":":
                            {
                                btn.Content = $";";
                                break;
                            }
                        case "\"":
                            {
                                btn.Content = $"'";
                                break;
                            }
                        case "<":
                            {
                                btn.Content = $",";
                                break;
                            }
                        case ">":
                            {
                                btn.Content = $".";
                                break;
                            }
                        case "?":
                            {
                                btn.Content = "/";
                                break;
                            }

                        default:
                            {
                                if (btn.Content.ToString().Length == 1)
                                {
                                    btn.Content = btn.Content.ToString().ToLower();
                                }


                                break;
                            }
                    }
                }
            }
        }
        private void KeysUpper()
        {
           Grid grid = this.Content as Grid;
            foreach (WrapPanel panel in grid.Children.OfType<WrapPanel>())
            {
                foreach (Button btn in panel.Children.OfType<Button>())
                {
                    switch (btn.Content.ToString())
                    {
                        case "1":
                            {
                                btn.Content = "!";
                                break;
                            }
                        case "2":
                            {
                                btn.Content = "@";
                                break;
                            }
                        case "3":
                            {
                                btn.Content = "#";
                                break;
                            }
                        case "4":
                            {
                                btn.Content = "$";
                                break;
                            }
                        case "5":
                            {
                                btn.Content = "%";
                                break;
                            }
                        case "6":
                            {
                                btn.Content = "^";
                                break;
                            }
                        case "7":
                            {
                                btn.Content = "&";
                                break;
                            }

                        case "8":
                            {
                                btn.Content = "*";
                                break;
                            }

                        case "9":
                            {
                                btn.Content = "(";
                                break;
                            }
                        case "0":
                            {
                                btn.Content = ")";
                                break;
                            }
                        case "-":
                            {
                                btn.Content = "_";
                                break;
                            }
                        case "=":
                            {
                                btn.Content = "+";
                                break;
                            }
                        case "`":
                            {
                                btn.Content = "~";
                                break;
                            }
                        case "[":
                            {
                                btn.Content = "{";
                                break;
                            }
                        case "]":
                            {
                                btn.Content = "}";
                                break;
                            }
                        case "\\":
                            {
                                btn.Content = "|";
                                break;
                            }
                        case ";":
                            {
                                btn.Content = $":";
                                break;
                            }
                        case "'":
                            {
                                btn.Content = $"\"";
                                break;
                            }
                        case ",":
                            {
                                btn.Content = $"<";
                                break;
                            }
                        case ".":
                            {
                                btn.Content = $">";
                                break;
                            }
                        case "/":
                            {
                                btn.Content = "?";
                                break;
                            }

                        default:
                            {
                                if (btn.Content.ToString().Length == 1)
                                {
                                    btn.Content = btn.Content.ToString().ToUpper();
                                }


                                break;
                            }
                    }
                }
            }
        }


    }
}
