using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class LoginDAL
    {
        // public string Account { get; set; }
        // public string Password { get; set; }
        public LoginDAL()
        {
        }
        //Dang nhap
        public string Login(string Account, string Password)
        {
            int count1 = 0;
            int count3 = 0;
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid = root; password = Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM admin Where TK = '" + Account + "' and MK = '" + Password + "' ", connection))
            {
                count1 = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if (count1 != 0)
            {
                connection.Close();
                return "1";
            }

            else
            {
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM tk_khachhang Where TK = '" + Account + "' and MK = '" + Password + "' ", connection))
                {
                    count3 = Convert.ToInt32(cmd.ExecuteScalar());
                }
                if (count3 != 0)
                {
                    connection.Close();
                    return $"{Account}";
                }
                else
                {
                    connection.Close();
                    return null;
                }
            }

        }

        public void SignIn(string username, string password, string phoneNumber)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();

            MySqlCommand command4 = new MySqlCommand("insert into tk_khachhang (TK ,MK , Phone_Customer) values ('" + username + "', '" + password + "','" + phoneNumber + "');", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Create Account Success");
                reader.Close();
            }
            connection.Close();

        }
    }
}