using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.MVVM.Model
{
    public class User
    {
        private int iduser;
        private string login;
        private string password;
        private string fio;
        private string adress;
        private string phone;
        private string passport;
        private string organ;
        private DateTime birth;

        public int Iduser { get { return iduser; } set { iduser = value; } }
        public string Login { get { return login; } set { login = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Fio { get { return fio; } set { fio = value;} }
        public string Adress { get { return adress; } set { adress = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Passport { get { return passport; } set { passport = value; } }
        public string Organ { get { return organ; } set { organ = value; } }
        public DateTime Birth { get { return birth; } set { birth = value; } }

        public User() { }

        public User(string login, string password, string fio, string adress, string phone, string passport, string organ, DateTime birth)
        {
            Login = login;
            Password = password;
            Fio = fio;
            Adress = adress;
            Phone = phone;
            Passport = passport;
            Organ = organ;
            Birth = birth;
        }

        public User(int iduser, string login, string password, string fio, string adress, string phone, string passport, string organ, DateTime birth)
        {
            Iduser = iduser;
            Login = login;
            Password = password;
            Fio = fio;
            Adress = adress;
            Phone = phone;
            Passport = passport;
            Organ = organ;
            Birth = birth;
        }

        public string BirthString
        {
            get
            {
                return Convert.ToString(Birth.Year) + "." + Convert.ToString(Birth.Month) + "." + Convert.ToString(Birth.Day);
            }
        }
    }
}
