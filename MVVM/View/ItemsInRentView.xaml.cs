using project.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySqlConnector;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ItemsInRentView.xaml
    /// </summary>
    public partial class ItemsInRentView : UserControl
    {

        public List<Contract> contracts { get; set; }

        public ItemsInRentView()
        {
            InitializeComponent();
            contracts = new List<Contract>();
            FillContracts();
            ComboBoxSortOrders.SelectedIndex = 0;
        }

        public void FillContracts()
        {
            int idc;
            int idu;
            int ido;
            DateTime dtz;
            DateTime dtv;
            float price;
            string status;
            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Договор WHERE IDпользователя={MainWindow.user.Iduser};", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idu = Convert.ToInt32(reader.GetValue(0));
                idc = Convert.ToInt32(reader.GetValue(1));
                ido = Convert.ToInt32(reader.GetValue(2));
                dtz=Convert.ToDateTime(reader.GetValue(3));
                dtv= Convert.ToDateTime(reader.GetValue(4));
                price = float.Parse(Convert.ToString(reader.GetValue(5)));
                status = Convert.ToString(reader.GetValue(6));
                contracts.Add(new Contract(idc, idu, ido, dtz, dtv, price, status));
            }
            con.Close();
        }

        public void ReFillContracts()
        {
            contracts.Clear();
            FillContracts();
            OrdersList.ItemsSource = null;
            OrdersList.Items.Clear();
            OrdersList.ItemsSource = contracts;
        }

        private void OrdersList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CheckInfoAboutOrder window = new CheckInfoAboutOrder(contracts[OrdersList.SelectedIndex],this);
            window.ShowDialog();
        }

        private void SelectedAll_Selected(object sender, RoutedEventArgs e)
        {
            OrdersList.ItemsSource = null;
            OrdersList.Items.Clear();
            OrdersList.ItemsSource = contracts;
        }

        private void SelectedInArend_Selected(object sender, RoutedEventArgs e)
        {
            OrdersList.ItemsSource = null;
            OrdersList.Items.Clear();
            var obj = contracts.Where(p => p.Status == "В аренде").ToList();
            if (obj != null) OrdersList.ItemsSource = obj;
        }

        private void SelectedReturned_Selected(object sender, RoutedEventArgs e)
        {
            OrdersList.ItemsSource = null;
            OrdersList.Items.Clear();
            var obj = contracts.Where(p => p.Status == "Возвращено").ToList();
            if (obj != null) OrdersList.ItemsSource = obj;
        }

        private void SelectedWaiting_Selected(object sender, RoutedEventArgs e)
        {
            OrdersList.ItemsSource = null;
            OrdersList.Items.Clear();
            var obj = contracts.Where(p => p.Status == "Ожидание").ToList();
            if (obj != null) OrdersList.ItemsSource = obj;
        }

        private void SelecyedInReturn_Selected(object sender, RoutedEventArgs e)
        {
            OrdersList.ItemsSource = null;
            OrdersList.Items.Clear();
            var obj = contracts.Where(p => p.Status == "Ожидание на возврат").ToList();
            if (obj != null) OrdersList.ItemsSource = obj;
        }
    }
}
