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
using System.Windows.Shapes;
using MySqlConnector;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для AdminDeepUser.xaml
    /// </summary>
    public partial class AdminDeepUser : Window
    {
        public AdminDeepUser(UserView uv)
        {
            InitializeComponent();
            userView = uv;
            IdPanel.Visibility = Visibility.Hidden;
        }

        User user { get; set; }
        bool _u = false;
        UserView userView { get; set; }
        public AdminDeepUser(UserView uv, User user)
        {
            InitializeComponent();
            userView = uv;
            this.user = user;
            Id.Text = Convert.ToString(user.Iduser);
            Login.Text = user.Login;
            Passport.Text = user.Passport;
            Password.Text = user.Password;
            FIO.Text = user.Fio;
            Adress.Text = user.Adress;
            Phone.Text = user.Phone;
            DateOfBirth.SelectedDate = user.Birth;
            _u = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if(Login.Text == "" | Passport.Text == ""|Password.Text == ""|
                FIO.Text == ""|Adress.Text == ""|Phone.Text == ""|Organ.Text==""|
                DateOfBirth.SelectedDate == null)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                    MySqlConnection con = new MySqlConnection(connStr);
                    con.Open();
                    MySqlCommand msqlc= new MySqlCommand();
                    if (_u)
                    {
                        msqlc = new MySqlCommand($"UPDATE Пользователь SET Логин='{Login.Text}'," +
                            $"Пароль='{Password.Text}',ФИО='{FIO.Text}'," +
                            $"ДатаРождения='{DateOfBirth.SelectedDate.Value.ToShortDateString()}',Адрес='{Adress.Text}'," +
                            $"НомерТелефона='{Phone.Text}',НомерПаспорта='{Passport.Text}'," +
                            $"ОрганВыдачи='{Organ.Text}' WHERE IDпользователя={user.Iduser}", con);
                    }
                    else
                    {
                        msqlc = new MySqlCommand($"INSERT Пользователь (Логин,Пароль,ФИО,ДатаРождения," +
                            $"Адрес,НомерТелефона,НомерПаспорта,ОрганВыдачи) " +
                            $"VALUES ('{Login.Text}','{Password.Text}','{FIO.Text}'," +
                            $"'{DateOfBirth.SelectedDate.Value.ToShortDateString()}','{Adress.Text}','{Phone.Text}'," +
                            $"'{Passport.Text}','{Organ.Text}');", con);
                    }
                    msqlc.ExecuteNonQuery();
                    con.Close();
                    userView.Refill();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
