using project.Classes;
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
using System.Windows.Shapes;
using MySqlConnector;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для AdminDeepItem.xaml
    /// </summary>
    public partial class AdminDeepItem : Window
    {
        public Product product { get; set; }
        public ItemView iv { get; set; }
        bool flagofcreate = false;
        public AdminDeepItem(ItemView iv)
        {
            InitializeComponent();
            this.iv = iv;
            SaveChanges.Content = "Добавить";
            IdText.Visibility = Visibility.Hidden;
            IdTovara.Visibility = Visibility.Hidden;
            flagofcreate = true;

        }

        public AdminDeepItem(ItemView iv,Product product)
        {
            InitializeComponent();
            this.product = product;
            IdTovara.Text = Convert.ToString(product.Id);
            NameOfItem.Text = Convert.ToString(product.Name);
            Description.Text= Convert.ToString(product.Description);
            PriceOfItem.Text = Convert.ToString(product.Price);
            StatusOfItem.Text = Convert.ToString(product.Status);
            LinkToPhoto.Text = product.Imagesource;
            this.iv = iv;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (NameOfItem.Text!="" & Description.Text!=""&PriceOfItem.Text!=""&StatusOfItem.Text!=""&LinkToPhoto.Text!="")
            {
                if (IsDigitsOnly(PriceOfItem.Text))
                {
                    if (StatusOfItem.Text == "True" | StatusOfItem.Text == "False")
                    {
                        try
                        {
                            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                            MySqlConnection con = new MySqlConnection(connStr);
                            con.Open();
                            MySqlCommand com = new MySqlCommand();
                            if (!flagofcreate)
                                com = new MySqlCommand($"UPDATE Товар SET Название='{NameOfItem.Text}',Описание='{Description.Text}'," +
                                    $"`Цена за аренду`={float.Parse(PriceOfItem.Text)},Статус={Convert.ToBoolean(StatusOfItem.Text)}," +
                                    $"Фото='{LinkToPhoto.Text}' WHERE ID={product.Id}", con);
                            else
                                com = new MySqlCommand($"INSERT Товар (Название,Описание,`Цена за аренду`,Статус,Фото) " +
                                    $"VALUES ('{NameOfItem.Text}','{Description.Text}'," +
                                    $"{float.Parse(PriceOfItem.Text)},{Convert.ToBoolean(StatusOfItem.Text)}," +
                                    $"'{LinkToPhoto.Text}')", con);
                            com.ExecuteNonQuery();
                            iv.RefillStuf();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("В поле Статус необходимо писать либо True, либо False", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("В поле Цена необходимо писать число!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
