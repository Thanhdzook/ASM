using System;
using static System.Console;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL{
    public class DisplayPhone{
        public void Display(int values1 , int values2){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM mobilephone where ID_Phone > "+values1+" and ID_Phone < "+values2+";", connection);
                        using (MySqlDataReader reader = command4.ExecuteReader())
                        {
                            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                                                                                             ║");
                            ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("║                                  {0, -20}                                   ║", "Information Mobile Phone");
                            ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║                                                                                             ║");
                            Console.WriteLine("╠═══════╦═══════════════════════════╦═════════════╦══════════╦═════════╦══════════════════════╣");
                            
                            Console.WriteLine("║ {0, -5} ║ {1, -25} ║ {2, -10} ║ {3, -8} ║ {4, -7} ║ {5, -20} ║", "ID", "Mobile Phone Name", "Manufactory", "CPU","RAM","Price (VND)");
                            while (reader.Read())
                            {
                                ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("╠═══════╬═══════════════════════════╬═════════════╬══════════╬═════════╬══════════════════════╣");
                                
                                Console.WriteLine("║ {0, -5} ║ {1, -25} ║ {2, -11} ║ {3, -8} ║ {4, -7} ║ {5, -20} ║", reader["ID_Phone"], reader["Name_Phone"], reader["Hang_Phone"], reader["CPU_Phone"], reader["RAM_Phone"], reader["Gia_Phone"]);
                            }
                                Console.WriteLine("╚═══════╩═══════════════════════════╩═════════════╩══════════╩═════════╩══════════════════════╝");
                            reader.Close();
                        }
            connection.Close();
        }

        public int CountPhone(){
            int count1 = 0;
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            using(var cmd = new MySqlCommand("SELECT COUNT(*) FROM mobilephone", connection))
            {
                    count1 = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count1;
        }
    }
}