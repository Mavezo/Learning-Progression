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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(mainBtn.Content as string);
            mainBtn.Content = "Good day!";
            if(Grid.GetRow(mainBtn) > 0)
            Grid.SetRow(mainBtn, Grid.GetRow(mainBtn) - 1);
            else
                Grid.SetRow(mainBtn, Grid.GetRow(mainBtn) + 1);
        }
    }
}
