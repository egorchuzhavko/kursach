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
    /// Логика взаимодействия для Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        ItemView iv { get; set; }
        bool _iv = false;
        public Delete(ItemView iv)
        {
            InitializeComponent();
            this.iv = iv;
            _iv = true;
        }

        UserView uv { get; set; }
        bool _uv = false;
        public Delete(UserView uv)
        {
            InitializeComponent();
            this.uv = uv;
            _uv = true;
        }

        ContractView cv { get; set; }
        bool _cv = false;
        public Delete(ContractView cv)
        {
            InitializeComponent();
            this.cv = cv;
            _cv = true;
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

        private void Удалить_Click(object sender, RoutedEventArgs e)
        {
            if (idtodelete.Text != "")
            {
                if (IsDigitsOnly(idtodelete.Text))
                {
                    try
                    {
                        if (_iv)
                        {
                            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                            MySqlConnection con = new MySqlConnection(connStr);
                            con.Open();
                            MySqlCommand cm = new MySqlCommand($"SELECT Статус FROM Товар WHERE  ID={Convert.ToInt32(idtodelete.Text)}", con);
                            MySqlDataReader dr = cm.ExecuteReader();
                            bool flag = false;
                            int qqq = 0;
                            while (dr.Read())
                            {
                                qqq++;
                                flag = Convert.ToBoolean(dr.GetValue(0));
                            }
                            con.Close();
                            if (flag)
                            {
                                con.Open();
                                MySqlCommand com = new MySqlCommand($"DELETE FROM Товар WHERE ID={Convert.ToInt32(idtodelete.Text)}", con);
                                com.ExecuteNonQuery();
                                iv.RefillStuf();
                                con.Close();
                                this.Close();
                            }
                            else
                            {
                                if (qqq == 0) MessageBox.Show("Товара с Таким ID нет!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                                else MessageBox.Show("Вы не можете удалить активный товар!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        if (_uv)
                        {
                            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                            MySqlConnection con = new MySqlConnection(connStr);
                            con.Open();
                            MySqlCommand msc = new MySqlCommand($"SELECT Статус FROM Договор WHERE IDпользователя={Convert.ToInt32(idtodelete.Text)}", con);
                            MySqlDataReader dr = msc.ExecuteReader();
                            bool flag = false;
                            int qqq = 0;
                            while (dr.Read())
                            {
                                qqq++;
                                string temp = Convert.ToString(dr.GetValue(0));
                                if (temp == "Ожидание на возврат" | temp == "Ожидание" | temp == "В аренде")
                                {
                                    MessageBox.Show("Вы не можете удалить пользователя с активным заказом!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                                    flag = true;
                                    break;
                                }
                            }
                            con.Close();
                            if(qqq==0) MessageBox.Show("Пользователя с таким ID нет!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                            else
                            {
                                if (!flag)
                                {
                                    try
                                    {
                                        MySqlCommand msqc1 = new MySqlCommand($"DELETE FROM Пользователь WHERE IDпользователя={Convert.ToInt32(idtodelete.Text)}", con);
                                        con.Open();
                                        msqc1.ExecuteNonQuery();
                                        con.Close();
                                        uv.Refill();
                                        this.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                }
                            }
                        }
                        if (_cv)
                        {
                            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                            MySqlConnection con = new MySqlConnection(connStr);
                            con.Open();
                            MySqlCommand msc = new MySqlCommand($"SELECT Статус FROM Договор WHERE НомерДоговора={Convert.ToInt32(idtodelete.Text)}", con);
                            MySqlDataReader dr = msc.ExecuteReader();
                            bool flag = false;
                            int qqq = 0;
                            while (dr.Read())
                            {
                                qqq++;
                                string temp = Convert.ToString(dr.GetValue(0));
                                if (temp == "Ожидание на возврат" | temp == "Ожидание" | temp == "В аренде")
                                {
                                    MessageBox.Show("Вы не можете удалить активный договор!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                                    flag = true;
                                    break;
                                }
                            }
                            con.Close();
                            if (qqq == 0) MessageBox.Show("Договора с таким ID нет!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                            else
                            {
                                if (!flag)
                                {
                                    try
                                    {
                                        MySqlCommand msqc1 = new MySqlCommand($"DELETE FROM Договор WHERE НомерДоговора={Convert.ToInt32(idtodelete.Text)}", con);
                                        con.Open();
                                        msqc1.ExecuteNonQuery();
                                        con.Close();
                                        MySqlCommand msqc2 = new MySqlCommand($"DELETE FROM IDзаказаннойЭкипировки WHERE Idаренда={Convert.ToInt32(idtodelete.Text)}", con);
                                        con.Open();
                                        msqc2.ExecuteNonQuery();
                                        con.Close();
                                        cv.Refill();
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели число!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели ничего!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
