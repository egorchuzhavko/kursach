using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using MySqlConnector;
using project.MVVM.Model;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для MakeOrder.xaml
    /// </summary>
    public partial class MakeOrder : Window
    {
        KorzinaView obj;
        public MakeOrder(KorzinaView obj)
        {
            InitializeComponent();
            this.obj = obj;
            DateStart.DisplayDateStart = DateTime.Today;
            DateStart.SelectedDate = DateTime.Today;
            DateEnd.SelectedDate = DateTime.Today;
            DateEnd.DisplayDateStart = DateTime.Today;
            OrderItemsList.ItemsSource = KorzinaView.basketproducts;
            CountPrice();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CountPrice()
        {
            int days = 0;
            if (DateStart.SelectedDate.Value == DateEnd.SelectedDate.Value)
                days = 1;
            else
                days = (DateEnd.SelectedDate.Value - DateStart.SelectedDate.Value).Days + 1;
            float price = 0;
            foreach(var item in KorzinaView.basketproducts)
            {
                price += item.Price;
            }
            Price.Text = Convert.ToString(price * (float)days);
        }

        private void DateEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LocalCheck();
            CountPrice();
        }



        private void DateStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LocalCheck();
            CountPrice();
        }

        private void LocalCheck()
        {
            if (DateEnd == null)
            {
                DateEnd = new DatePicker();
                DateEnd.SelectedDate = DateTime.Today;
            }
            if (DateStart == null)
            {
                DateStart = new DatePicker();
                DateStart.SelectedDate = DateTime.Today;
            }
            if (DateStart.SelectedDate.Value > DateEnd.SelectedDate.Value)
                DateEnd.SelectedDate = DateStart.SelectedDate;
        }

        private void MakeOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://google.ru");
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
                string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                MySqlConnection con = new MySqlConnection(connStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO Договор " +
                    $"(IDпользователя,ДатаЗаключения,ДатаВозврата,ЦенаАренды,Статус) " +
                    $"VALUES ({MainWindow.user.Iduser},'{DateStart.SelectedDate.Value.ToShortDateString()}','{DateEnd.SelectedDate.Value.ToShortDateString()}',{float.Parse(Price.Text)},'Ожидание');", con);
                cmd.ExecuteReader();
                con.Close();
                con.Open();
                MySqlCommand cmd1 = new MySqlCommand($"SELECT НомерДоговора FROM Договор " +
                    $"WHERE IDпользователя={MainWindow.user.Iduser}", con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                int nomerd = 0;
                while (reader1.Read())
                {
                    nomerd = Convert.ToInt32(reader1.GetValue(0));
                }
                con.Close();
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand($"UPDATE Договор SET IDзаказаЭкипировки={nomerd} WHERE НомерДоговора={nomerd} ", con);
                cmd2.ExecuteReader();
                foreach (var item in KorzinaView.basketproducts)
                {
                    con.Close();
                    con.Open();
                    MySqlCommand cmd3 = new MySqlCommand($"INSERT IDзаказаннойЭкипировки (Idаренда,Idтовара) VALUES ({nomerd},{item.Id})", con);
                    MySqlCommand cmd4 = new MySqlCommand($"UPDATE Товар SET Статус=0 WHERE ID={item.Id}", con);
                    cmd3.ExecuteReader();
                    con.Close();
                    con.Open();
                    cmd4.ExecuteReader();
                }
                con.Close();
                Contract cntrct = new Contract(nomerd, MainWindow.user.Iduser, nomerd, DateStart.SelectedDate.Value, DateEnd.SelectedDate.Value, float.Parse(Price.Text), "Ожидание");
                cntrct.ProductsList = KorzinaView.basketproducts;
                cntrct.MakeKviranciya();
                KorzinaView.basketproducts.Clear();
                obj.BasketList.ItemsSource = null;
                obj.BasketList.Items.Clear();
                obj.BasketList.ItemsSource = KorzinaView.basketproducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.Close();
        }
    }
}
