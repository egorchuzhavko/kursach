using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using MySqlConnector;

namespace project.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для StatisticsView.xaml
    /// </summary>
    public partial class StatisticsView : UserControl
    {
        public StatisticsView()
        {
            InitializeComponent();
            FindPrice();
            CountOfItems();
        }

        public void CountOfItems()
        {
            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM Товар;", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count = Convert.ToInt32(dr.GetValue(0));
            }
            CountOfStaf.Text = count.ToString();
            con.Close();
            con.Open();
            MySqlCommand cmd1 = new MySqlCommand($"SELECT COUNT(*) FROM Товар WHERE Статус=0;", con);
            MySqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                count = Convert.ToInt32(dr1.GetValue(0));
            }
            CountOfStafInArend.Text=count.ToString();
        }

        public void FindPrice()
        {
            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT ДатаЗаключения,ДатаВозврата,ЦенаАренды FROM Договор;", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            DateTime ds;
            DateTime de;
            float price = 0;
            float totalPrice = 0;
            int qqq = 0;
            while (dr.Read()) {
                qqq++;
                ds = Convert.ToDateTime(dr.GetValue(0));
                de = Convert.ToDateTime(dr.GetValue(1));
                price = float.Parse(Convert.ToString(dr.GetValue(2)));
                if(DateTime.Now<=ds & DateTime.Now >= de)
                {
                    float temp = (de - ds).Days + 1;
                    totalPrice += (price / temp);
                }
            }
            ForDayPrice.Text=Convert.ToString(totalPrice);
            con.Close();
            con.Open();
            MySqlCommand qwe = new MySqlCommand($"SELECT SUM(ЦенаАренды) FROM Договор", con);
            int w = 0;
            MySqlDataReader dq = qwe.ExecuteReader();
            while (dq.Read()) 
            {
                w += Convert.ToInt32(dq.GetValue(0));
            }
            TotalPrice.Text=Convert.ToString(w);
        }
    }
}
