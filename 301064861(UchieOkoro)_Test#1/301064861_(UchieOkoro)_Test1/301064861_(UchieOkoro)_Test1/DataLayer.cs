using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301064861__UchieOkoro__Test1
{
    class DataLayer
    {
        static List<SalesDetails> SalesRecords = new List<SalesDetails>();
        static List<Product> ProductList = new List<Product>();

        public static List<Product> GetProducts()
        {
            ProductList.Add(new Product { Id = "0000100", Name = "Samsung Led monitor", UnitPrice = 129.99m });
            ProductList.Add(new Product { Id = "0000101", Name = "Asus tablet", UnitPrice = 168.99m });
            ProductList.Add(new Product { Id = "0000102", Name = "Kinston Solidstate Drive", UnitPrice = 329.99m });
            ProductList.Add(new Product { Id = "0000103", Name = "HP Pavillion Desktop", UnitPrice = 599.99m });
            ProductList.Add(new Product { Id = "0000104", Name = "Macbook Pro", UnitPrice = 1899.99m });
            ProductList.Add(new Product { Id = "0000105", Name = "LG Led Screen", UnitPrice = 189.99m });
            ProductList.Add(new Product { Id = "0000106", Name = "Pinnacle BlueRay Drive", UnitPrice = 149.99m });
            ProductList.Add(new Product { Id = "0000107", Name = "Kinston Solidstate Drive", UnitPrice = 329.99m });
            ProductList.Add(new Product { Id = "0000108", Name = "Asus Vivobook", UnitPrice = 429.99m });
            ProductList.Add(new Product { Id = "0000109", Name = "HP Stream 14 Labtop", UnitPrice = 299.99m });
            return ProductList;
        }
        public static List<SalesDetails> GetSalesRecords()
        {
            if (SalesRecords.Count == 0)
            {
                SalesRecords.Add(new SalesDetails { TransactionID = "17-001", EmployeeID = "300111222", ProductID = "0000109", Quantity = 9, TransactionDate = new DateTime(2017, 01, 23) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-002", EmployeeID = "300111222", ProductID = "0000101", Quantity = 5, TransactionDate = new DateTime(2017, 04, 20) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-003", EmployeeID = "300222333", ProductID = "0000102", Quantity = 10, TransactionDate = new DateTime(2017, 05, 11) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-004", EmployeeID = "300222333", ProductID = "0000103", Quantity = 30, TransactionDate = new DateTime(2017, 06, 27) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-005", EmployeeID = "300222333", ProductID = "0000103", Quantity = 25, TransactionDate = new DateTime(2017, 7, 27) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-006", EmployeeID = "300222333", ProductID = "0000102", Quantity = 12, TransactionDate = new DateTime(2017, 8, 27) });

                SalesRecords.Add(new SalesDetails { TransactionID = "17-007", EmployeeID = "300333444", ProductID = "0000102", Quantity = 12, TransactionDate = new DateTime(2017, 8, 28) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-008", EmployeeID = "300333444", ProductID = "0000103", Quantity = 15, TransactionDate = new DateTime(2017, 8, 30) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-010", EmployeeID = "300333444", ProductID = "0000104", Quantity = 30, TransactionDate = new DateTime(2017, 9, 3) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-011", EmployeeID = "300333444", ProductID = "0000106", Quantity = 50, TransactionDate = new DateTime(2017, 9, 5) });

                SalesRecords.Add(new SalesDetails { TransactionID = "18-001", EmployeeID = "300444555", ProductID = "0000105", Quantity = 40, TransactionDate = new DateTime(2018, 1, 22) });
                SalesRecords.Add(new SalesDetails { TransactionID = "18-002", EmployeeID = "300444555", ProductID = "0000107", Quantity = 80, TransactionDate = new DateTime(2018, 2, 12) });
                SalesRecords.Add(new SalesDetails { TransactionID = "19-001", EmployeeID = "300444555", ProductID = "0000109", Quantity = 30, TransactionDate = new DateTime(2019, 2, 12) });
                SalesRecords.Add(new SalesDetails { TransactionID = "2020-001", EmployeeID = "300444555", ProductID = "0000108", Quantity = 45, TransactionDate = new DateTime(2020, 1, 15) });

                SalesRecords.Add(new SalesDetails { TransactionID = "17-012", EmployeeID = "300555666", ProductID = "0000107", Quantity = 45, TransactionDate = new DateTime(2017, 9, 15) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-013", EmployeeID = "300555666", ProductID = "0000105", Quantity = 10, TransactionDate = new DateTime(2017, 10, 2) });
                SalesRecords.Add(new SalesDetails { TransactionID = "18-003", EmployeeID = "300555666", ProductID = "0000104", Quantity = 20, TransactionDate = new DateTime(2018, 3, 2) });
                SalesRecords.Add(new SalesDetails { TransactionID = "19-002", EmployeeID = "300555666", ProductID = "0000103", Quantity = 10, TransactionDate = new DateTime(2019, 3, 2) });

                SalesRecords.Add(new SalesDetails { TransactionID = "17-014", EmployeeID = "300666777", ProductID = "0000102", Quantity = 35, TransactionDate = new DateTime(2017, 10, 25) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-015", EmployeeID = "300666777", ProductID = "0000103", Quantity = 50, TransactionDate = new DateTime(2017, 11, 3) });
                SalesRecords.Add(new SalesDetails { TransactionID = "18-004", EmployeeID = "300666777", ProductID = "0000105", Quantity = 20, TransactionDate = new DateTime(2018, 3, 2) });
                SalesRecords.Add(new SalesDetails { TransactionID = "18-005", EmployeeID = "300666777", ProductID = "0000106", Quantity = 40, TransactionDate = new DateTime(2018, 4, 20) });

                SalesRecords.Add(new SalesDetails { TransactionID = "19-004", EmployeeID = "300777888", ProductID = "0000105", Quantity = 15, TransactionDate = new DateTime(2019, 4, 2) });
                SalesRecords.Add(new SalesDetails { TransactionID = "19-005", EmployeeID = "300777888", ProductID = "0000107", Quantity = 20, TransactionDate = new DateTime(2019, 6, 12) });
                SalesRecords.Add(new SalesDetails { TransactionID = "2020-002", EmployeeID = "300777888", ProductID = "0000109", Quantity = 30, TransactionDate = new DateTime(2020, 2, 5) });
                SalesRecords.Add(new SalesDetails { TransactionID = "2020-003", EmployeeID = "300777888", ProductID = "0000106", Quantity = 35, TransactionDate = new DateTime(2020, 2, 7) });

                SalesRecords.Add(new SalesDetails { TransactionID = "17-016", EmployeeID = "300888999", ProductID = "0000104", Quantity = 55, TransactionDate = new DateTime(2017, 11, 13) });
                SalesRecords.Add(new SalesDetails { TransactionID = "17-017", EmployeeID = "300888999", ProductID = "0000102", Quantity = 15, TransactionDate = new DateTime(2017, 12, 23) });
                SalesRecords.Add(new SalesDetails { TransactionID = "18-006", EmployeeID = "300888999", ProductID = "0000101", Quantity = 10, TransactionDate = new DateTime(2018, 6, 23) });
                SalesRecords.Add(new SalesDetails { TransactionID = "18-007", EmployeeID = "300888999", ProductID = "0000103", Quantity = 22, TransactionDate = new DateTime(2018, 8, 20) });

                SalesRecords.Add(new SalesDetails { TransactionID = "18-008", EmployeeID = "300999000", ProductID = "0000109", Quantity = 35, TransactionDate = new DateTime(2018, 9, 20) });
                SalesRecords.Add(new SalesDetails { TransactionID = "19-006", EmployeeID = "300999000", ProductID = "0000108", Quantity = 20, TransactionDate = new DateTime(2019, 9, 12) });
                SalesRecords.Add(new SalesDetails { TransactionID = "19-007", EmployeeID = "300999000", ProductID = "0000109", Quantity = 12, TransactionDate = new DateTime(2019, 10, 24) });
                SalesRecords.Add(new SalesDetails { TransactionID = "2020-004", EmployeeID = "300999000", ProductID = "0000107", Quantity = 22, TransactionDate = new DateTime(2020, 2, 15) });
            }

            return SalesRecords;
        }

        public static ObservableCollection<SalesPerson> GetSales()
        {
            ObservableCollection<SalesPerson> salesList = new ObservableCollection<SalesPerson>();
            salesList.Add(new SalesPerson { ID = "300111222", FirstName = "Lois", LastName = "Cortez", Email = "lcortez@abccompany.com", ContactNo = "(416) 123456789-100" });
            salesList.Add(new SalesPerson { ID = "300222333", FirstName = "Daria", LastName = "Rice", Email = "drice@abccompany.com", ContactNo = "(416) 123456789-101" });
            salesList.Add(new SalesPerson { ID = "300333444", FirstName = "Acton", LastName = "Keller", Email = "akeller@abccompany.com", ContactNo = "(416) 123456789-102" });
            salesList.Add(new SalesPerson { ID = "300444555", FirstName = "Galena", LastName = "Collier", Email = "gcollier@abccompany.com", ContactNo = "(416) 123456789-103" });
            salesList.Add(new SalesPerson { ID = "300555666", FirstName = "Nissim", LastName = "Mercer", Email = "nmercer@abccompany.com", ContactNo = "(416) 123456789-104" });
            salesList.Add(new SalesPerson { ID = "300666777", FirstName = "Edward", LastName = "Hayden", Email = "ehayden@abccompany.com", ContactNo = "(416) 123456789-105" });
            salesList.Add(new SalesPerson { ID = "300777888", FirstName = "Hop", LastName = "Carrillo", Email = "hcarrillo@abccompany.com", ContactNo = "(416) 123456789-106" });
            salesList.Add(new SalesPerson { ID = "300888999", FirstName = "Lisandra", LastName = "Clayton", Email = "lclayton@abccompany.com", ContactNo = "(416) 123456789-107" });
            salesList.Add(new SalesPerson { ID = "300999000", FirstName = "Nerea", LastName = "Fox", Email = "nfox@abccompany.com", ContactNo = "(416) 123456789-108" });

            return salesList;
        }
    }
}
