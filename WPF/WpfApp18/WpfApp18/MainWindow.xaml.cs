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
using System.Threading;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp18
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
        char[,] data = new char[3,3];
        bool TwoPlayer = false;
        bool whoseMove = false;
        int counter;

        private void Textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            int i = 0;
            int j = 0;
            switch ((sender as TextBlock).Name)
            {
                case "zero_zero":
                  {
                        i = 0;
                        j = 0;
                        break;
                }
                case "zero_one":
                   {
                        i = 0;
                        j = 1;
                        break;
                    }
                case "zero_two":
                    {
                        i = 0;
                        j = 2;
                        break;
                    }
                case "one_zero":
                    {
                        i = 1;
                        j = 0;
                        break;
                    }
                case "one_one":
                    {
                        i = 1;
                        j = 1;
                        break;
                    }
                case "one_two":
                    {
                        i = 1;
                        j = 2;
                        break;
                    }
                case "two_zero":
                    {
                        i = 2;
                        j = 0;
                        break;
                    }
                case "two_one":
                    {
                        i = 2;
                        j = 1;
                        break;
                    }
                case "two_two":
                    {
                        i = 2;
                        j = 2;
                        break;
                    }
            }
            if (data[i, j] == '\0' && counter != 9)
            {
                if (whoseMove)
                {
                    (sender as TextBlock).Background = this.Resources["x_brush"] as DrawingBrush;
                    data[i, j] = 'x';
                    counter++;
                    if (CheckWinner() == true)
                    {
                        Clear();
                        return;
                    }
                    else if(CheckWinner() == false)
                    {
                        Clear();
                        return;
                    }
                    if(TwoPlayer)
                    whoseMove = !whoseMove;
  
                }
                else
                {
                    (sender as TextBlock).Background = this.Resources["o_brush"] as DrawingBrush;
                    data[i, j] = 'o';
                    counter++;
                    if (CheckWinner() == true)
                    {
                        Clear();
                        return;
                    }
                    else if (CheckWinner() == false)
                    {
                        Clear();
                        return;
                    }
                    if (TwoPlayer)
                        whoseMove = !whoseMove;
                }


                if (!TwoPlayer)
                {
                    Random rd = new Random();
                    i = rd.Next(0, 3);
                    j = rd.Next(0, 3);
                    while (data[i, j] != '\0' && counter != 9)
                    {
                        i = rd.Next(0, 3);
                        j = rd.Next(0, 3);
                    }
                    string str1 = "null";
                    string str2 = "null";
                    switch (i)
                    {
                        case 0:
                            str1 = "zero";
                            break;
                        case 1:
                            str1 = "one";
                            break;
                        case 2:
                            str1 = "two";
                            break;
                    }
                    switch (j)
                    {
                        case 0:
                            str2 = "zero";
                            break;
                        case 1:
                            str2 = "one";
                            break;
                        case 2:
                            str2 = "two";
                            break;
                    }
                    if (str1 != "null" && str2 != "null" && data[i, j] == '\0' && counter != 9)
                    {
                        ((TextBlock)this.FindName(str1 + "_" + str2)).Background = this.Resources["o_brush"] as DrawingBrush;
                        data[i, j] = 'o';
                        counter++;
                        if (CheckWinner() == true)
                        {
                            Clear();
                            return;
                        }
                        else if (CheckWinner() == false)
                        { 
                            Clear();
                            return;
                        }
                    }
                }
            }
        }

        private bool? CheckWinner()
        {
            if(data[2,0] == 'x' &&  data[2, 1] == 'x' && data[2, 2] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[2, 0] == 'o' && data[2, 1] == 'o' && data[2, 2] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }

            if (data[1, 0] == 'x' && data[1, 1] == 'x' && data[1, 2] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[1, 0] == 'o' && data[1, 1] == 'o' && data[1, 2] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }

            if (data[0, 0] == 'x' && data[0, 1] == 'x' && data[0, 2] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[0, 0] == 'o' && data[0, 1] == 'o' && data[0, 2] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }


            if (data[2, 0] == 'x' && data[1, 0] == 'x' && data[0, 0] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[2, 0] == 'o' && data[1, 0] == 'o' && data[0, 0] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }

            if (data[2, 1] == 'x' && data[1, 1] == 'x' && data[0, 1] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[2, 1] == 'o' && data[1, 1] == 'o' && data[0, 1] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }

            if (data[2, 2] == 'x' && data[1, 2] == 'x' && data[0, 2] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[2, 2] == 'o' && data[1, 2] == 'o' && data[0, 2] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }


            if (data[2, 0] == 'x' && data[1, 1] == 'x' && data[0, 2] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[2, 0] == 'o' && data[1, 1] == 'o' && data[0, 2] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }

            if (data[0, 0] == 'x' && data[1, 1] == 'x' && data[2, 2] == 'x')
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            if (data[0, 0] == 'o' && data[1, 1] == 'o' && data[2, 2] == 'o')
            {
                MessageBox.Show("Player O win!");
                return false;
            }

            if(counter == 9)
            {
                MessageBox.Show("Draw!");
                Clear();
            }

            return null;
        }

        private void Clear()
        {
            foreach (var item in MainGrid.Children.OfType<TextBlock>())
            {
                item.Background = null;
            }
           for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    data[i, j] = '\0';
                }
           }
            counter = 0;


        }


    }
}
