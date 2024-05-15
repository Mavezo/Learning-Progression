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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int counter = 1;
            for (int i = 0, j = 0, type = 0; i < 1000 || j < 500;) {
                Button button = new Button();
                button.Content = counter.ToString();
                dock.Children.Add(button);
                if (type == 0)
                {
                    button.Background = Brushes.Black;
                    button.Width = i + 200;
                    i = i + 200;
                    DockPanel.SetDock(button, Dock.Left);
                }
                if(type == 1)
                {
                    button.Background = Brushes.Black;
                    button.Height = j + 100;
                    j = j + 100;
                    DockPanel.SetDock(button, Dock.Bottom);
                }
                if(type == 2)
                {
                    button.Background = Brushes.White;
                    button.Width = i + 200;
                    i = i + 200;
                    DockPanel.SetDock(button, Dock.Left);
                }



                counter++;
                type++;
            }
  
        }
    }
}
