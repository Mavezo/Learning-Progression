using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp22
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Transaction> Transations { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Transations = new ObservableCollection<Transaction>();
            Transations.Add(new Transaction("Зарплата", 100.5));
            Transations.Add(new Transaction("Оплата квартиры", -22.32));
            Transations.Add(new Transaction("Продукты", -27.1));
            Transations.Add(new Transaction("Оплата ЖКХ", -20.56));
            Transations.Add(new Transaction("Подработка", 25.5));
            MyList.ItemsSource = Transations;
            this.DataContext = Transations;
        }
    }


    public sealed class Transaction
    {
        public string Description { set; get; }
        public double Money { set; get; }
        public Transaction(string description, double money)
        {
            this.Description = description;
            this.Money = money;
        }
        public bool IsExpense => Money < 0.0;
        public bool IsIncome => Money > 0.0;

    }

}
