using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DisplayCusTormerDAL
    {
        public void Display()
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM tk_khachhang ;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                System.Console.WriteLine("Account\tPassword"); while (reader.Read())
                {
                    string row = $"{reader["TK"]}\t\t{reader["MK"]}"; System.Console.WriteLine(row);
                }
                reader.Close();
            }
            connection.Close();

            MySqlConnection connection1 = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection1.Open();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM khachhang;", connection1);
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                System.Console.WriteLine("Name\tPhone Number\tAddress"); while (reader.Read())
                {
                    string row = $"{reader["name"]}\t\t{reader["phoneNumber"]}\t\t{reader["address"]}"; System.Console.WriteLine(row);
                }
                reader.Close();
            }
            connection1.Close();
            

        }
    }
}