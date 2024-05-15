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

namespace WpfApp23
{
    /// <summary>
    /// Логика взаимодействия для NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDown : UserControl
    {

        private int step = 1;

        public int Step
        {
            get { return step; }
            set { step = value; }
        }





        private double value;

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }





        public NumericUpDown()
        {
            InitializeComponent();
        }

        private void lower_Btn_Click(object sender, RoutedEventArgs e)
        {
            Value += Step;
            textbox.Text = Value.ToString();
        }

        private void upper_btn_Click(object sender, RoutedEventArgs e)
        {
            Value -= Step;
            textbox.Text = Value.ToString();
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!double.TryParse(textbox.Text, out value))
            {
                MessageBox.Show("Must be number!");
                textbox.Text = Value.ToString();
            }
        }
    }
}
