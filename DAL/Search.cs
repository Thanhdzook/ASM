using System;
using MySql.Data;
using static System.Console;
using MySql.Data.MySqlClient;

namespace DAL{
    public class SearchDAL{
        //tim kiem
        public int Search(string values){
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
        public void Display(string values)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid = root; password = Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command2 = new MySqlCommand("select Id_Phone , Name_Phone, Hang_Phone , CPU_Phone , RAM_Phone, Gia_Phone from mobilephone where ID_Phone like '"+values+"' " , connection);
            using (MySqlDataReader reader = command2.ExecuteReader())
                        {
                            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────┐");
                            Console.WriteLine("│                                                                                             │");
                            ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("│                                  {0, -20}                                   │", "Information Mobile Phone");
                            ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("│                                                                                             │");
                            Console.WriteLine("├───────┬───────────────────────────┬─────────────┬──────────┬─────────┬──────────────────────┤");
                            
                            Console.WriteLine("│ {0, -5} │ {1, -25} │ {2, -10} │ {3, -8} │ {4, -7} │ {5, -20} │", "ID", "Mobile Phone Name", "Manufactory", "CPU","RAM","Price (VND)");
                            while (reader.Read())
                            {
                                ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("├───────┼───────────────────────────┼─────────────┼──────────┼─────────┼──────────────────────┤");
                                
                                Console.WriteLine("│ {0, -5} │ {1, -25} │ {2, -11} │ {3, -8} │ {4, -7} │ {5, -20} │", reader["ID_Phone"], reader["Name_Phone"], reader["Hang_Phone"], reader["CPU_Phone"], reader["RAM_Phone"], reader["Gia_Phone"]);
                            }
                                Console.WriteLine("└───────┴───────────────────────────┴─────────────┴──────────┴─────────┴──────────────────────┘");
                            reader.Close();
                        }
            connection.Close();
        }
    }
}