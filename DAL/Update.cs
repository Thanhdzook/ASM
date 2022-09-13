using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL{
    public class UpdateDAL{
        public void UpdateQuantityDAL( string values2 , string id){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update mobilephone set So_Luong_Phone = '"+values2+"' where ID_Phone = '"+id+"' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();
        }
        public void UpdateTimeDAL( string values2 , string id){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update mobilephone set Time_Bao_Hanh = '"+values2+"' where ID_Phone = '"+id+"' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();
        }
        public void UpdatePriceDAL( string values2 , string id){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update mobilephone set Gia_Phone = '"+values2+"' where ID_Phone = '"+id+"' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();
        }
    }
}