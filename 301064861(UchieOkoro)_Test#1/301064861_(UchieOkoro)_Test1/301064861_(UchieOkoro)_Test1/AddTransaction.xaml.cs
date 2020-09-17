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
using System.Windows.Shapes;

namespace _301064861__UchieOkoro__Test1
{
    /// <summary>
    /// Interaction logic for AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        ObservableCollection<Product> allitems;
        ObservableCollection<TransactionDetails> transactionDetails = new ObservableCollection<TransactionDetails>();
        List<Product> ProductList = DataLayer.GetProducts();
        public AddTransaction()
        {
            InitializeComponent();
            idTXT.Text = MainWindow.salesPerson.ID;
            fnameTXT.Text = MainWindow.salesPerson.FirstName;
            lnameTXT.Text = MainWindow.salesPerson.LastName;
            salsInfogrd.ItemsSource = MainWindow.salesRecord;
            allitems = new ObservableCollection<Product>(DataLayer.GetProducts());
            //foreach (SalesDetails sale in MainWindow.salesRecord) 
            //{
            //    //if(sale.ProductID == ProductList.Select(a => a.Id == sale.ProductID))
            //    TransactionDetails td = new TransactionDetails(sale.TransactionID, sale.ProductID)
            //}
        }

        private void Product_Loaded(object sender, RoutedEventArgs e)
        {
            prod_combo.Items.Add("");
            foreach (Product prod in allitems)
            {
                prod_combo.Items.Add(prod.Name);//= queryLondonCustomers;
            }
            prod_combo.SelectedIndex = -1;
        }

        private void backtoMainBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            this.Hide();
            mn.Show();
        }

        private void addTransBTN_Click(object sender, RoutedEventArgs e)
        {
            string transID = transIDTXT.Text;
            string prodName = prod_combo.Text;
            string qty = qtyTXT.Text;
            string dateTran = transDateTXT.Text;

            SalesDetails sale = new SalesDetails();
            sale.TransactionID = transID;
            sale.EmployeeID = idTXT.Text;
            sale.ProductID = prodName;
            sale.Quantity = Int16.Parse(qty);
            sale.TransactionDate = Convert.ToDateTime(dateTran);
            MainWindow.salesRecord.Add(sale);


        }
    }
}
