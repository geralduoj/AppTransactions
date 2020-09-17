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

namespace _301064861__UchieOkoro__Test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<SalesDetails> AllSales = new List<SalesDetails>();
        public static ObservableCollection<SalesDetails> salesRecord = new ObservableCollection<SalesDetails>();
        public static SalesPerson salesPerson;

        public MainWindow()
        {
            InitializeComponent();
            salesgrd.ItemsSource = DataLayer.GetSales();
        }

        private void ShowTransaction(object sender, MouseButtonEventArgs e)
        {
            salesPerson = salesgrd.SelectedItem as SalesPerson;
            foreach(SalesDetails sale in DataLayer.GetSalesRecords()) 
            {
                if (sale.EmployeeID == salesPerson.ID) 
                {
                    AllSales.Add(sale);
                }
            }
            foreach (SalesDetails sale in AllSales)
            {
                salesRecord.Add(sale);
            }
            AddTransaction addTransaction = new AddTransaction();
            this.Hide();
            addTransaction.Show();

        }
    }
}
