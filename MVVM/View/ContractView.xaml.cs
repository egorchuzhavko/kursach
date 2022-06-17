using MySqlConnector;
using project.MVVM.Model;
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

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ContractView.xaml
    /// </summary>
    public partial class ContractView : UserControl
    {
        public List<Contract> contracts { get; set; }
        public ContractView()
        {
            InitializeComponent();
            contracts = new List<Contract>();
            FillContracts();
            combobox.SelectedIndex = 0;
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
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Договор;", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idu = Convert.ToInt32(reader.GetValue(0));
                idc = Convert.ToInt32(reader.GetValue(1));
                ido = Convert.ToInt32(reader.GetValue(2));
                dtz = Convert.ToDateTime(reader.GetValue(3));
                dtv = Convert.ToDateTime(reader.GetValue(4));
                price = float.Parse(Convert.ToString(reader.GetValue(5)));
                status = Convert.ToString(reader.GetValue(6));
                contracts.Add(new Contract(idc, idu, ido, dtz, dtv, price, status));
            }
            con.Close();
        }

        public void Refill()
        {
            ContractsList.ItemsSource = null;
            ContractsList.Items.Clear();
            contracts.Clear();
            FillContracts();
            combobox.SelectedIndex = 1;
            combobox.SelectedIndex = 0;
        }

        private void ContractsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AdminDeepContract contract = new AdminDeepContract(this,contracts[ContractsList.SelectedIndex]);
            contract.Show();
        }

        private void SelectedAll_Selected(object sender, RoutedEventArgs e)
        {
            ContractsList.ItemsSource = null;
            ContractsList.Items.Clear();
            ContractsList.ItemsSource = contracts;
        }

        private void SelectedWaiting_Selected(object sender, RoutedEventArgs e)
        {
            ContractsList.ItemsSource = null;
            ContractsList.Items.Clear();
            ContractsList.ItemsSource = contracts.Where(p=>p.Status=="Ожидание");
        }

        private void SelectedInArend_Selected(object sender, RoutedEventArgs e)
        {
            ContractsList.ItemsSource = null;
            ContractsList.Items.Clear();
            ContractsList.ItemsSource = contracts.Where(p => p.Status == "В аренде");
        }

        private void SelecyedInReturn_Selected(object sender, RoutedEventArgs e)
        {
            ContractsList.ItemsSource = null;
            ContractsList.Items.Clear();
            ContractsList.ItemsSource = contracts.Where(p => p.Status == "Ожидание на возврат");
        }

        private void SelectedReturned_Selected(object sender, RoutedEventArgs e)
        {
            ContractsList.ItemsSource = null;
            ContractsList.Items.Clear();
            ContractsList.ItemsSource = contracts.Where(p => p.Status == "Возвращено");
        }

        private void AddContract_Click(object sender, RoutedEventArgs e)
        {
            AdminDeepContract contract = new AdminDeepContract(this);
            contract.Show();
        }

        private void DeleteContract_Click(object sender, RoutedEventArgs e)
        {
            Delete d = new Delete(this);
            d.ShowDialog();
        }
    }
}
