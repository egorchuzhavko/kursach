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
using System.Windows.Shapes;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для AdminDeepContract.xaml
    /// </summary>
    public partial class AdminDeepContract : Window
    {
        ContractView contractView { get; set; }
        public AdminDeepContract(ContractView cv)
        {
            InitializeComponent();
            DateStart.DisplayDateStart = DateTime.Today;
            DateStart.SelectedDate = DateTime.Today;
            DateEnd.SelectedDate = DateTime.Today;
            DateEnd.DisplayDateStart = DateTime.Today;
            IdPanel.Visibility = Visibility.Hidden;
            contractView = cv;
        }

        Contract contract { get; set; }
        bool _contract = false;
        public AdminDeepContract(ContractView cw, Contract contract)
        {
            InitializeComponent();
            this.contract = contract;
            DateStart.DisplayDateStart = DateTime.Today;
            DateStart.SelectedDate = contract.DateofCustody;
            DateEnd.SelectedDate = contract.DateofEnd;
            DateEnd.DisplayDateStart = DateTime.Today;
            _contract = true;
            IdofUser.Text = Convert.ToString(contract.IdUser);
            IdofContract.Text = Convert.ToString(contract.IdContract);
            Price.Text = Convert.ToString(contract.Price);
            Status.Text=Convert.ToString(contract.Status);
            IdofStuf.Text = TakeIds(contract.IdContract);
            contractView = cw;
        }

        public string TakeIds(int id)
        {
            string ids = "";
            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand com = new MySqlCommand($"SELECT Idтовара FROM IDзаказаннойЭкипировки WHERE Idаренда = {id};", con);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ids += Convert.ToString(dr.GetValue(0)) + ',';
            }
            return ids.Remove(ids.Length - 1);
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
            if(DateStart.SelectedDate!=null | DateEnd.SelectedDate!=null|
                Price.Text!="" | Status.Text!="" | IdofStuf.Text != "" | IdofUser.Text!="")
            {
                if (IsDigitsOnly(Price.Text) & IsDigitsOnly(IdofUser.Text))
                {
                    if(Status.Text=="Ожидание на возврат" | Status.Text=="В аренде"|
                        Status.Text =="Возвращено" | Status.Text == "Ожидание")
                    {
                        string text = IdofStuf.Text;
                        string[] mas = text.Split(',');
                        try
                        {
                            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                            MySqlConnection con = new MySqlConnection(connStr);
                            if (_contract)
                            {
                                con.Open();
                                MySqlCommand cmd = new MySqlCommand($"UPDATE Договор SET ДатаЗаключения='{DateStart.SelectedDate.Value.ToShortDateString()}', ДатаВозврата='{DateEnd.SelectedDate.Value.ToShortDateString()}', ЦенаАренды={Convert.ToInt32(Price.Text)}, Статус='{Status.Text}' WHERE НомерДоговора={Convert.ToInt32(IdofContract.Text)};", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                con.Open();
                                MySqlCommand cmd1 = new MySqlCommand($"DELETE FROM IDзаказаннойЭкипировки WHERE Idаренда={IdofContract}", con);
                                con.Close();
                                if (Status.Text != "Возвращено")
                                {
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        con.Open();
                                        MySqlCommand cm = new MySqlCommand($"INSERT IDзаказаннойЭкипировки (Idаренда,Idтовара) VALUES ({IdofContract},{Convert.ToInt32(mas[i])});", con);
                                        cm.ExecuteNonQuery();
                                        con.Close();
                                        con.Open();
                                        MySqlCommand qwe = new MySqlCommand($"UPDATE Товар SET Статус=0 WHERE ID={Convert.ToInt32(mas[i])};", con);
                                        qwe.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        con.Open();
                                        MySqlCommand qwe = new MySqlCommand($"UPDATE Товар SET Статус=1 WHERE ID={Convert.ToInt32(mas[i])};", con);
                                        qwe.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                            }
                            else
                            {
                                con.Open();
                                MySqlCommand cmd = new MySqlCommand($"INSERT Договор " +
                    $"(IDпользователя,ДатаЗаключения,ДатаВозврата,ЦенаАренды,Статус) " +
                    $"VALUES ({Convert.ToInt32(IdofUser.Text)},'{DateStart.SelectedDate.Value.ToShortDateString()}'," +
                    $"'{DateEnd.SelectedDate.Value.ToShortDateString()}',{float.Parse(Price.Text)},'{Status.Text}');", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                con.Open();
                                MySqlCommand cmd1 = new MySqlCommand($"SELECT НомерДоговора FROM Договор " +
                                    $"WHERE IDпользователя={Convert.ToInt32(IdofUser.Text)}", con);
                                MySqlDataReader reader1 = cmd1.ExecuteReader();
                                int nomerd = 0;
                                while (reader1.Read())
                                {
                                    nomerd = Convert.ToInt32(reader1.GetValue(0));
                                }
                                con.Close();
                                for (int i = 0; i < mas.Length; i++)
                                {
                                    con.Open();
                                    MySqlCommand cm = new MySqlCommand($"INSERT IDзаказаннойЭкипировки (Idаренда,Idтовара) VALUES ({nomerd},{Convert.ToInt32(mas[i])});", con);
                                    cm.ExecuteNonQuery();
                                    con.Close();
                                    con.Open();
                                    MySqlCommand cm1 = new MySqlCommand($"UPDATE Товар SET Статус={0} WHERE ID={Convert.ToInt32(mas[i])};", con);
                                    cm1.ExecuteNonQuery();
                                    con.Close();
                                }
                                con.Open();
                                MySqlCommand q = new MySqlCommand($"UPDATE Договор SET IDзаказаЭкипировки={nomerd} WHERE НомерДоговора={nomerd}", con);
                                q.ExecuteNonQuery();
                            }
                            contractView.Refill();
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("В поле Статус введено некорректное значение! Доступные варианты:\n" +
                            "1)Ожидание на возврат\n" +
                            "2)В аренде\n" +
                            "3)Возвращено\n" +
                            "4)Ожидание", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("В поле Цена введены буквы/символы!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DateEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LocalCheck();
        }



        private void DateStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LocalCheck();
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
