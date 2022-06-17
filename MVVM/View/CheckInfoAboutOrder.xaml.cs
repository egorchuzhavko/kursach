using project.Classes;
using project.MVVM.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using MySqlConnector;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для CheckInfoAboutOrder.xaml
    /// </summary>
    public partial class CheckInfoAboutOrder : Window
    {
        public static List<Product> prdcts { get; set; }
        Contract cntrct;
        ItemsInRentView iirv;
        public CheckInfoAboutOrder(Contract contract, ItemsInRentView iirv)
        {
            InitializeComponent();
            prdcts = Product.TakeItemsFromOrder(contract);
            PriceOfOrder.Text = contract.Price.ToString() + " руб";
            OrderNumber.Text = contract.IdContract.ToString();
            DateStart.Text = contract.DateOfCustody;
            DateEnd.Text = contract.DateOfEnd;
            OrderItemsList.ItemsSource = prdcts;
            cntrct = contract;
            this.iirv = iirv;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GiveBackStuf_Click(object sender, RoutedEventArgs e)
        {
            if (cntrct.Status == "В аренде")
            {
                string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                MySqlConnection con = new MySqlConnection(connStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE Договор SET Статус='Ожидание на возврат' WHERE НомерДоговора={cntrct.IdContract}", con);
                int q = cmd.ExecuteNonQuery();
                if (q == 1)
                    MessageBox.Show("Запрос на возврат отправлен!", "Возврат!", MessageBoxButton.OK, MessageBoxImage.Information);
                iirv.ReFillContracts();
            }
            else
                MessageBox.Show("Запрос на возврат не отправлен! Статус заказа некорректный для возврата товара.", "Возврат!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void TakeDoc_Click(object sender, RoutedEventArgs e)
        {
            cntrct.ProductsList = prdcts;
            cntrct.MakeKviranciya();
        }

        private void OrderItemsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ItemInfo ii = new ItemInfo(prdcts[OrderItemsList.SelectedIndex]);
            ii.ShowDialog();
        }
    }
}
