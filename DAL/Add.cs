using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL{
    public class AddDAL{
        // public string Id {set; get;}
        // public string Name {set; get;}
        // public string Color {set; get;}
        // public string Brand {set; get;}
        // public string CPU {set; get;}
        // public string Ram   {set; get;}
        // public string Memory {set; get;}
        // public string weight {set; get;}
        // public string Pin {set; get;}
        // public string Size {set; get;}
        // public string Quantity {set; get;}
        // public string Price {set; get;}
        // public string Time {set; get;}

        public void Add(string Id , string Name , string Color , string Brand , string CPU , string Ram , string Memory , string Weight , string Pin , string Size , string Quantity , string Price , string Time){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();

            MySqlCommand command4 = new MySqlCommand("insert into mobilephone (ID_Phone ,Name_Phone ,Mau_Phone ,Hang_Phone ,CPU_Phone, Ram_Phone ,Bo_nho_Phone , Can_nang_Phone , Pin_Phone , Size_Phone , So_Luong_Phone , Gia_Phone , Time_Bao_Hanh ) values ( '"+Id+"' , '"+Name+"' ,'"+Color+"', '"+Brand+"', '"+CPU+"', '"+Ram+"', '"+Memory+"' , '"+Weight+"' , '"+Pin+"', '"+Size+"' , '"+Quantity+"','"+Price+"' , '"+Time+"');", connection);
                        using (MySqlDataReader reader = command4.ExecuteReader())
                        {
                            Console.WriteLine("Added successfully");
                            reader.Close();
                        }
            connection.Close();
        }
    }
}