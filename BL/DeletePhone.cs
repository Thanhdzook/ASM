using System;
using DAL;
namespace BL
{
    public class DeleteBL
    {
        private string id;
        public void Delete()
        {
            Console.Write("Input ID to delete : " );
            id = Console.ReadLine();
            DeleteDAL delete = new DeleteDAL();
            if (delete.Delete(id) == 1)
            {
                Console.WriteLine("Deleted successfully");
            }
            else
            {
                Console.WriteLine("Failed to delete");
            }
        }
    }
}