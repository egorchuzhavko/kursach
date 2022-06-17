using MySqlConnector;
using project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public partial class ItemView : UserControl
    {
        public List<Product> products { get; set; }
        public ItemView()
        {
            InitializeComponent();
            products = new List<Product>();
            FillStuf();
            ItemsList.ItemsSource = products;
        }

        private void ItemsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AdminDeepItem adi = new AdminDeepItem(this, products[ItemsList.SelectedIndex]);
            adi.ShowDialog();
        }

        public void FillStuf()
        {
            try
            {
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://google.ru");
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
                string n;
                int id;
                string description;
                bool status;
                string imagesource;
                float price;
                string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                MySqlConnection con = new MySqlConnection(connStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Товар", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = Convert.ToString(reader.GetValue(1));
                    id = Convert.ToInt32(reader.GetValue(0));
                    description = Convert.ToString(reader.GetValue(2));
                    imagesource = Convert.ToString(reader.GetValue(5));
                    price = float.Parse(Convert.ToString(reader.GetValue(3)));
                    status = Convert.ToBoolean(reader.GetValue(4));
                    products.Add(new Product(n, id, description, status, price, imagesource));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void RefillStuf()
        {
            products.Clear();
            ItemsList.ItemsSource = null;
            ItemsList.Items.Clear();
            FillStuf();
            ItemsList.ItemsSource = products;
        }

        private void AddStaf_Click(object sender, RoutedEventArgs e)
        {
            AdminDeepItem adi = new AdminDeepItem(this);
            adi.ShowDialog();
        }

        private void DeleteStaf_Click(object sender, RoutedEventArgs e)
        {
            Delete d = new Delete(this);
            d.ShowDialog();
        }
    }
}
