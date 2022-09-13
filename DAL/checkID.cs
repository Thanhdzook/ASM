using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL{
    public class CheckID{
        //tim kiem
        public int Check(string values){
            int count = 0;
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid = root; password = Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            using(var cmd = new MySqlCommand("SELECT COUNT(*) FROM mobilephone Where ID_Phone = '"+values+"'", connection))
            {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if(count != 0){
                connection.Close();
                return 1;
            }
            else{
                connection.Close();
                return 0;
            }
        }
    }
}