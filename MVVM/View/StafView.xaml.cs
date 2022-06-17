using project.Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySqlConnector;
using System.Net;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для StafView.xaml
    /// </summary>
    public partial class StafView : UserControl
    {
        public List<Product> products { get; set; }
        public int ind = 0;

        public StafView()
        {
            InitializeComponent();
            products = new List<Product>();
            FillStuf();
            DataContext = this;
            ListViewStuf.ItemsSource = products;
            ComboMode.SelectedIndex = 0;
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
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Товар WHERE Статус=1;", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = Convert.ToString(reader.GetValue(1));
                    id = Convert.ToInt32(reader.GetValue(0));
                    description = Convert.ToString(reader.GetValue(2));
                    imagesource = Convert.ToString(reader.GetValue(5));
                    price = float.Parse(Convert.ToString(reader.GetValue(3)));
                    status = Convert.ToBoolean(reader.GetValue(4));
                    if (status) products.Add(new Product(n, id, description, status, price, imagesource));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MonVib_Selected(object sender, RoutedEventArgs e)//Множественный выбор выделения элементов
        {
            ListViewStuf.SelectionMode = SelectionMode.Multiple;
        }

        private void OdVib_Selected(object sender, RoutedEventArgs e)//Одиночный выбор выделения элементов
        {
            ListViewStuf.SelectionMode = SelectionMode.Single;
        }

        private void ListViewStuf_MouseDoubleClick(object sender, MouseButtonEventArgs e)//даблклик на элемент списка
        {
            if (ComboMode.SelectedIndex == 0)
            {
                ind = ListViewStuf.SelectedIndex;
                ItemInfo check = new ItemInfo(products[ind]);
                check.ShowDialog();
            }
            else
            {
                MessageBox.Show("Переключите режим выборки на одиночный, чтобы смотреть информацию об предмете", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddToBasket_Click(object sender, RoutedEventArgs e) //кнопка добавления в корзину
        {
            foreach (var index in ListViewStuf.SelectedItems)
            {
                bool flag = false;
                foreach (var item in MainWindow.basket)
                {
                    if ((index as Product).Id == item.Id)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag) MainWindow.basket.Add(index as Product);
            }
        }
    }
}
