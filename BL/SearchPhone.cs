using System;
using DAL;

namespace BL{
    public class SearchBL{
        private string Id;
        public void Search()
        {
            Console.Write("Input Id to search : ");
            Id = Console.ReadLine();
            SearchDAL search = new SearchDAL();
            if (search.Search(Id) == 1)
            {
                search.Display(Id);
            }
            else
            {
                Console.WriteLine("ID not found !");
            }
        }
        public string SearchUpdate()
        {
            Console.Write("Input Id to Update : ");
            Id = Console.ReadLine();
            SearchDAL search = new SearchDAL();
            if (search.Search(Id) == 1)
            {
                return $"{Id}";
            }
            else
            {
                return null;
            }
        }
    }
}