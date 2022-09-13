using System;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DeleteDAL
    {
        public int Delete(string id){
            SearchDAL searchDAL = new SearchDAL();
            if(searchDAL.Search(id) == 1){
                MySqlConnection connection = new MySqlConnection
                {
                    ConnectionString = @"server=localhost;uid = root; password = Ttadhp2608. ;port=3306;database=mobilephoneshop;"
                };
                connection.Open();
                MySqlCommand command4 = new MySqlCommand("delete from mobilephone where ID_Phone = '"+id+"'", connection);
                using (MySqlDataReader reader = command4.ExecuteReader())
                {
                }
                connection.Close();
                return 1;
            }
            else{
                return 0;
            }
            
        }

    }
}