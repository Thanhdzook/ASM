using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL{
    public class DisplayDAL{
        public void Display(){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM mobilephone;", connection);
                        using (MySqlDataReader reader = command4.ExecuteReader())
                        {
                            System.Console.WriteLine("ID_Phone\tName_Phone\tMau_Phone\tHang_Phone\tCPU_Phone\tRam_Phone\tBo_nho_Phone\tCan_nang_Phone\tPin_Phone\tSize_Phone\t     So_Luong_Phone       Gia_Phone"); while (reader.Read())
                            {
                                string row =$"{reader["ID_Phone"]}\t\t{reader["Name_Phone"]}\t\t{reader["Mau_Phone"]}\t\t{reader["Hang_Phone"]}\t\t{reader["CPU_Phone"]}\t\t{reader["Ram_Phone"]}\t\t{reader["Bo_nho_Phone"]}\t\t{reader["Can_nang_Phone"]}\t\t{reader["Pin_Phone"]}\t\t{reader["Size_Phone"]}  {reader["So_Luong_Phone"]}                   {reader["Gia_Phone"]}"; System.Console.WriteLine(row);
                            }
                            reader.Close();
                        }
            connection.Close();
        }
    }
}