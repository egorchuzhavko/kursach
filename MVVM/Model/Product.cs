using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using project.MVVM.Model;

namespace project.Classes
{
    public class Product
    {
        private string _name;
        private int _id;
        private string _description;
        private bool status;
        private string _imagesource;
        private float _price;

        public string Name { get { return _name; } set { _name = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public float Price { get { return _price; } set { _price = value; } }
        public string Imagesource { get { return _imagesource; } set { _imagesource = value; } }

        public Product(string name, int id, string description, bool status, float price, string imagesource)
        {
            Name = name;
            Id = id;
            Description = description;
            Status = status;
            Price = price;
            Imagesource = imagesource;
        }

        public static List<Product> TakeItemsFromOrder(Contract cntrct)
        {
            var list = new List<Product>();
            string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand com1 = new MySqlCommand($"SELECT Idтовара FROM IDзаказаннойЭкипировки WHERE Idаренда={cntrct.IdContract}", con);
            MySqlDataReader dr1 = com1.ExecuteReader();
            List<int> ids = new List<int>();
            while (dr1.Read())
            {
                ids.Add(Convert.ToInt32(dr1.GetValue(0)));
            }
            con.Close();
            string n;
            int id;
            string description;
            bool status;
            string imagesource;
            float price;
            foreach(var item in ids)
            {
                con.Open();
                MySqlCommand com2 = new MySqlCommand($"SELECT * FROM Товар WHERE ID={item}", con);
                MySqlDataReader dr2 = com2.ExecuteReader();
                while (dr2.Read())
                {
                    n = Convert.ToString(dr2.GetValue(1));
                    id = Convert.ToInt32(dr2.GetValue(0));
                    description = Convert.ToString(dr2.GetValue(2));
                    imagesource = Convert.ToString(dr2.GetValue(5));
                    price = float.Parse(Convert.ToString(dr2.GetValue(3)));
                    status = Convert.ToBoolean(dr2.GetValue(4));
                    list.Add(new Product(n, id, description, status, price, imagesource));
                }
                con.Close();
            }
            return list;
        }
    }
}
