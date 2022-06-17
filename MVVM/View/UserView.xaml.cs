using MySqlConnector;
using project.MVVM.Model;
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
    /// <summary>
    /// Логика взаимодействия для UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public List<User> _users { get; set; }
        public UserView()
        {
            InitializeComponent();
            _users = new List<User>();
            FillUsers();
            UsersList.ItemsSource = _users;
        }

        public void FillUsers()
        {
            try
            {
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://google.ru");
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
                string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                MySqlConnection con = new MySqlConnection(connStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Пользователь", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                int id = 0;
                string log = "";
                string pass = "";
                string fio = "";
                DateTime birth=new DateTime();
                string adr = "";
                string phone = "";
                string passport = "";
                string organ = "test";
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                    log = Convert.ToString(reader.GetValue(1));
                    pass = Convert.ToString(reader.GetValue(2));
                    fio = Convert.ToString(reader.GetValue(3));
                    birth = Convert.ToDateTime(reader.GetValue(4));
                    adr = Convert.ToString(reader.GetValue(5));
                    phone = Convert.ToString(reader.GetValue(6));
                    passport = Convert.ToString(reader.GetValue(7));
                    organ = Convert.ToString(reader.GetValue(8));
                    _users.Add(new User(id,log, pass, fio, adr, phone, passport, organ, birth));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void Refill()
        {
            _users.Clear();
            UsersList.ItemsSource = null;
            UsersList.Items.Clear();
            FillUsers();
            UsersList.ItemsSource = _users;
        }

        private void UsersList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AdminDeepUser adu = new AdminDeepUser(this,_users[UsersList.SelectedIndex]);
            adu.ShowDialog();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            AdminDeepUser adu = new AdminDeepUser(this);
            adu.ShowDialog();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            Delete dv = new Delete(this);
            dv.ShowDialog();
        }
    }
}
