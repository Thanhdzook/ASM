using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class Customer
    {
        public void DisplayOrder(string value)
        {
            MySqlConnection connection1 = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection1.Open();
            MySqlCommand command1 = new MySqlCommand("SELECT Name_Phone, Gia_Phone from mobilephone Where ID_Phone like '"+value+"';", connection1);
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    string row = $"Mobile Phone Name: {reader["Name_Phone"]}\nPrice:{reader["Gia_Phone"]}"; 
                    System.Console.WriteLine(row);
                }
                reader.Close();
            }
            connection1.Close();
        }
        public void AddCustomer(string name, string address, string TK)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("UPDATE tk_khachhang SET Name_Customer = '" + name + "', Address_Customer = '" + address + "' WHERE TK = '" + TK + "';", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Added account customer successfully");
                reader.Close();
            }
            connection.Close();
        }
        public int CheckValue(string TK)
        {
            int count = 0;
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(Name_Customer) FROM tk_khachhang where TK = '" + TK + "' ", connection))
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }

            connection.Close();
            return count;
        }
        public void UpdatePassword(string values2, string id)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update tk_khachhang set MK = '" + values2 + "' where TK = '" + id + "' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();
        }
        public void UpdatePhoneNumber(string values2, string id)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update tk_khachhang set Phone_Number = '" + values2 + "' where TK = '" + id + "' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();
        }
        public void UpdateAddress(string values2, string id)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update tk_khachhang set Address_Customer = '" + values2 + "' where TK = '" + id + "' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();

        }
        // public void AddOrder(string name_phone, string price, int quantity , string name_customer , string phoneNumber , string address){
        //     MySqlConnection connection = new MySqlConnection
        //     {
        //         ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
        //     };
        //     connection.Open();

        //     MySqlCommand command4 = new MySqlCommand("insert into receipt (name_phone ,amount_phone ,price,name_customer ,phoneNumber ) values ( '"+name_phone+"' , '+quantity+' ,'"+price+"', '"+name_customer+"', '"+phoneNumber+"', '"+address+"');", connection);
        //                 using (MySqlDataReader reader = command4.ExecuteReader())
        //                 {
        //                     Console.WriteLine("Added successfully");
        //                     reader.Close();
        //                 }
        //     connection.Close();
        // }
        public void AddOrder(string name_phone, string price, string quantity , string name_customer , string phoneNumber , string address , string status){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();

            MySqlCommand command4 = new MySqlCommand("insert into receipt (name_phone ,amount_phone ,price,name_customer ,phoneNumber , address , status ) values ( '"+name_phone+"' , '"+quantity+"' ,'"+price+"', '"+name_customer+"', '"+phoneNumber+"', '"+address+"' , '"+status+"');", connection);
                        using (MySqlDataReader reader = command4.ExecuteReader())
                        {
                            Console.WriteLine("Added successfully");
                            reader.Close();
                        }
            connection.Close();
        }
        public void DisplayCustomerInfo(string value)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("SELECT Name_Customer, Phone_Customer , Address_Customer from tk_khachhang Where TK like '"+value+"';", connection);
                using (MySqlDataReader reader = command4.ExecuteReader())
                {
                    while (reader.Read()){
                    string row = $"Name Customer : {reader["Name_Customer"]}\nPhone Number : {reader["Phone_Customer"]}\nAddress : {reader["Address_Customer"]}"; 
                    System.Console.WriteLine(row);
                    }
                    reader.Close();
                }
            connection.Close();
        }
        public int checkQuantity(string quantity , string id){
            int count = 0;
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid = root; password = Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM mobilephone WHERE ID_Phone = '"+id+"' and So_Luong_Phone >= '"+quantity+"';", connection))
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if (count != 0)
            {
                connection.Close();
                return 1;
            }
            else{
                return 0;
            }
        }
        public string CustomerInformation(string TK , int values){
            string name;
            string address ;
            string phone;
            MySqlConnection connection1 = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection1.Open();
            MySqlCommand command1 = new MySqlCommand("SELECT Name_Customer , Address_Customer , Phone_Customer from tk_khachhang Where TK like '"+TK+"';", connection1);
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                reader.Read();
                    name = $"{reader["Name_Customer"]}"; 
                    address = $"{reader["Address_Customer"]}";
                    phone = $"{reader["Phone_Customer"]}";
                    
                
                reader.Close();
            }
            connection1.Close();
            if(values == 1){
                return name;
            }
            else if(values == 2){
                return phone;
            }
            else{
                return address;
            }
        }
        public string PhoneInformation(string ID , int values){
            string name_phone ; 
            string price ;
            string quantity;
            MySqlConnection connection1 = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection1.Open();
            MySqlCommand command1 = new MySqlCommand("SELECT Name_Phone , Gia_Phone , So_Luong_Phone from mobilephone Where ID_Phone like '"+ID+"';", connection1);
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                    reader.Read();
                    name_phone = $"{reader["Name_Phone"]}"; 
                    price = $"{reader["Gia_Phone"]}";
                    quantity = $"{reader["So_Luong_Phone"]}";
                reader.Close();
            }
            connection1.Close();
            if(values == 1){
                return name_phone;
            }
            else if(values == 2){
                return price;
            }
            else{
                return quantity;
            }
        }
        public void UpdateQuantity(string ID , string value){
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = @"server=localhost;uid=root;password=Ttadhp2608. ;port=3306;database=mobilephoneshop;"
            };
            connection.Open();
            MySqlCommand command4 = new MySqlCommand("update mobilephone set So_Luong_Phone = ( So_Luong_Phone - '"+value+"') where ID_Phone = '"+ID+"' ", connection);
            using (MySqlDataReader reader = command4.ExecuteReader())
            {
                Console.WriteLine("Update successful");
                reader.Close();
            }
            connection.Close();
        }
    }
}