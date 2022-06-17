using System;
using System.IO;
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
using System.Data.SqlClient;
using MySqlConnector;
using project.MVVM.Model;
using System.Text.RegularExpressions;

namespace project
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void BackFromReg_Click(object sender, RoutedEventArgs e)//"назад" из регистрации
        {
            FIO.Visibility = Visibility.Hidden;
            FIO.Text = "Ваше ФИО";
            Adress.Visibility = Visibility.Hidden;
            Adress.Text = "Ваш адрес проживания";
            BirthD.Visibility = Visibility.Hidden;
            BirthD.Text = "Ваша дата рождения";
            PhoneNumber.Visibility = Visibility.Hidden;
            PhoneNumber.Text = "Номер телефона";
            PassportNumber.Visibility = Visibility.Hidden;
            PassportNumber.Text = "Номер паспорта";
            OrganVidachi.Visibility = Visibility.Hidden;
            OrganVidachi.Text = "Орган выдачи паспорта";
            Login.Visibility = Visibility.Hidden;
            Login.Text = "Логин";
            Password.Visibility = Visibility.Hidden;
            Password.Text = "Пароль";
            SignUp.Visibility = Visibility.Hidden;
            BackFromReg.Visibility = Visibility.Hidden;
            Authorization.Visibility = Visibility.Visible;
            Registration.Visibility = Visibility.Visible;
            Admin.Visibility = Visibility.Visible;
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)//Процесс регистрации
        {
            if (FIO.Text != "" & BirthD.SelectedDate != null & Adress.Text != ""
                & PhoneNumber.Text != "" & PassportNumber.Text != "" & OrganVidachi.Text != ""
                & Login.Text != "" & Password.Text != "")
            {
                Regex r2 = new Regex(@"(AB|BM|HB|KH|MP|MC|KB|PP|ST|DT)\d{7}$");
                MatchCollection matches2 = r2.Matches(PassportNumber.Text);
                if (matches2.Count == 0)
                {
                    MessageBox.Show("Номер пасспорта введён в неверном формате!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Regex rph = new Regex(@"\+375\d{9}$");
                    MatchCollection matches = rph.Matches(PhoneNumber.Text);
                    if (matches.Count == 0)
                    {
                        MessageBox.Show("Номер телефона введён в неверном формате!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                        MySqlConnection con = new MySqlConnection(connStr);
                        con.Open();
                        MySqlCommand msqlc = new MySqlCommand($"INSERT Пользователь (Логин,Пароль,ФИО,ДатаРождения," +
                                                    $"Адрес,НомерТелефона,НомерПаспорта,ОрганВыдачи) " +
                                                    $"VALUES ('{Login.Text}','{Password.Text}','{FIO.Text}'," +
                                                    $"'{BirthD.SelectedDate.Value.Year.ToString()+ '-'+BirthD.SelectedDate.Value.Month.ToString()+'-'+ BirthD.SelectedDate.Value.Day.ToString()}','{Adress.Text}','{PhoneNumber.Text}'," +
                                                    $"'{PassportNumber.Text}','{OrganVidachi.Text}');", con);
                        msqlc.ExecuteNonQuery();
                        MessageBox.Show("Вы зарегистрировались успешно теперь войдите в аккаунт!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                        FIO.Visibility = Visibility.Hidden;
                        FIO.Text = "Ваше ФИО";
                        Adress.Visibility = Visibility.Hidden;
                        Adress.Text = "Ваш адрес проживания";
                        BirthD.Visibility = Visibility.Hidden;
                        PhoneNumber.Visibility = Visibility.Hidden;
                        PhoneNumber.Text = "Номер телефона";
                        PassportNumber.Visibility = Visibility.Hidden;
                        PassportNumber.Text = "Номер паспорта";
                        OrganVidachi.Visibility = Visibility.Hidden;
                        OrganVidachi.Text = "Орган выдачи паспорта";
                        Login.Visibility = Visibility.Hidden;
                        Login.Text = "Логин";
                        Password.Visibility = Visibility.Hidden;
                        Password.Text = "Пароль";
                        SignUp.Visibility = Visibility.Hidden;
                        BackFromReg.Visibility = Visibility.Hidden;
                        Authorization.Visibility = Visibility.Visible;
                        Registration.Visibility = Visibility.Visible;
                        Admin.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели все данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)//меню авторизации
        {
            Authorization.Visibility = Visibility.Hidden;
            Registration.Visibility = Visibility.Hidden;
            Admin.Visibility = Visibility.Hidden;
            AvtorizeLogin.Visibility = Visibility.Visible;
            AvtorizePassword.Visibility = Visibility.Visible;
            Authorize.Visibility = Visibility.Visible;
            BackFromAuthorize.Visibility = Visibility.Visible;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)//меню регистрации
        {
            Authorization.Visibility = Visibility.Hidden;
            Registration.Visibility = Visibility.Hidden;
            Admin.Visibility = Visibility.Hidden;
            FIO.Visibility = Visibility.Visible;
            Adress.Visibility = Visibility.Visible;
            BirthD.Visibility = Visibility.Visible;
            PhoneNumber.Visibility = Visibility.Visible;
            PassportNumber.Visibility = Visibility.Visible;
            OrganVidachi.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Visible;
            SignUp.Visibility = Visibility.Visible;
            BackFromReg.Visibility = Visibility.Visible;
        }

        private void BackFromAuthorize_Click(object sender, RoutedEventArgs e)//Назад из авторизации
        {
            Authorization.Visibility = Visibility.Visible;
            Registration.Visibility = Visibility.Visible;
            Admin.Visibility= Visibility.Visible;
            AvtorizeLogin.Visibility = Visibility.Hidden;
            AvtorizePassword.Visibility = Visibility.Hidden;
            Authorize.Visibility = Visibility.Hidden;
            BackFromAuthorize.Visibility = Visibility.Hidden;
            AvtorizeLogin.Text = "Введите логин";
            AvtorizePassword.Text = "Введите пароль";
        }

        private void Authorize_Click(object sender, RoutedEventArgs e)//Процесс авторизации
        {
            string login = AvtorizeLogin.Text, password = AvtorizePassword.Text;
            if (password != "" & login != "")
            {
                string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                MySqlConnection con = new MySqlConnection(connStr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Пользователь WHERE Логин='{login}' and Пароль='{password}';", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                int id = 0;
                string l = "";
                string p = "";
                string f = "";
                DateTime b = DateTime.Now;
                string a = "";
                string ph = "";
                string np = "";
                string ov = "";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(Convert.ToInt32(reader["IDпользователя"]));
                        l = Convert.ToString(Convert.ToString(reader["Логин"]));
                        p = Convert.ToString(Convert.ToString(reader["Пароль"]));
                        f = Convert.ToString(Convert.ToString(reader["ФИО"]));
                        b = Convert.ToDateTime(Convert.ToString(reader["ДатаРождения"]));
                        a = Convert.ToString(Convert.ToString(reader["Адрес"]));
                        ph = Convert.ToString(Convert.ToString(reader["НомерТелефона"]));
                        np = Convert.ToString(Convert.ToString(reader["НомерПаспорта"]));
                        ov = Convert.ToString(Convert.ToString(reader["ОрганВыдачи"]));
                    }
                    MessageBox.Show("Вы вошли успешно!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    User u = new User(id, l, p, f, a, ph, np, ov, b);
                    MainWindow mw = new MainWindow(u);
                    this.Hide();
                    mw.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                con.Close();
            }
            else
                MessageBox.Show("Вы ввели не все данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ClearBox(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            Authorization.Visibility = Visibility.Hidden;
            Registration.Visibility = Visibility.Hidden;
            Admin.Visibility = Visibility.Hidden;
            AdminLogin.Visibility = Visibility.Visible;
            AdminPassword.Visibility = Visibility.Visible;
            AdminAvtorize.Visibility = Visibility.Visible;
            BackFromAdmin.Visibility = Visibility.Visible;
        }

        private void AdminAvtorize_Click(object sender, RoutedEventArgs e)
        {
            if(AdminLogin.Text =="admin" & AdminPassword.Text == "password")
            {
                AdminWindow aw = new AdminWindow();
                this.Hide();
                aw.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка входа в админ панель!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackFromAdmin_Click(object sender, RoutedEventArgs e)
        {
            Authorization.Visibility = Visibility.Visible;
            Registration.Visibility = Visibility.Visible;
            Admin.Visibility = Visibility.Visible;
            AdminLogin.Text = "Введите логин";
            AdminPassword.Text = "Введите пароль";
            BackFromAdmin.Visibility = Visibility.Hidden;
            AdminAvtorize.Visibility = Visibility.Hidden;
            AdminLogin.Visibility = Visibility.Hidden;
            AdminPassword.Visibility = Visibility.Hidden;
        }
    }
}
