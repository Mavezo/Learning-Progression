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

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int counter = 1;
            int i = 0, j = 0;
            for (int type = 0; i < 1000 || j < 500; type++) { 
                Button button = new Button();
                button.Content = counter.ToString();
                dock.Children.Add(button);
                if (type == 0)
                {
                    button.Background = Brushes.Black;
                    button.Width = 1 + 2;
                    i = i + 2;
                    DockPanel.SetDock(button, Dock.Left);
                }
                if (type == 1)
                {
                    button.Background = Brushes.White;
                    button.Height= 1 + 1;
                    j = j + 1;
                    DockPanel.SetDock(button, Dock.Top);
                }
                if (type == 2)
                {
                    button.Background = Brushes.Black;
                    button.Height = 1 + 1;
                    j = j + 1;
                    DockPanel.SetDock(button, Dock.Bottom);
                }
                if (type == 3)
                {
                    button.Background = Brushes.White;
                    button.Width = 1 + 2;
                    i = i + 2;
                    DockPanel.SetDock(button, Dock.Left);
                }
                if (type == 4)
                {
                    button.Background = Brushes.Black;
                    button.Width = 1 +2;
                    i = i + 2;
                    DockPanel.SetDock(button, Dock.Right);
                }
                if (type == 5)
                {
                    button.Background = Brushes.White;
                    button.Height = 1 + 1;
                    j = j + 1;
                    DockPanel.SetDock(button, Dock.Bottom);
                }
                if (type == 6)
                {
                    button.Background = Brushes.Black;
                    button.Height = 1 + 1;
                    j = j + 1;
                    DockPanel.SetDock(button, Dock.Top);
              
                }
                if (type == 7)
                {
                    button.Background = Brushes.White;
                    button.Width= 1 + 2;
                    i = i + 2;
                    DockPanel.SetDock(button, Dock.Right);
                    type = -1;
                }

                counter++;

            }

       }
    }
}