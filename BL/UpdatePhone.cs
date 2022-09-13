using System;
using DAL;

namespace BL{
    public class UpdateBL{
        private string Quantity;
        private string Time;
        private string Price;

        public void UpdateQuantity(string ID){
            Console.Write("Input Quantity : ");
            Quantity = Console.ReadLine();
            UpdateDAL update = new UpdateDAL();
            update.UpdateQuantityDAL(Quantity , ID);
        }
        public void UpdateTime(string ID){
            Console.Write("Input Warranty Period : ");
            Time = Console.ReadLine();
            UpdateDAL update = new UpdateDAL();
            update.UpdateTimeDAL(Time , ID);
        }
        public void UpdatePrice(string ID){
            Console.Write("Input Price : ");
            Price = Console.ReadLine();
            UpdateDAL update = new UpdateDAL();
            update.UpdatePriceDAL(Price , ID);
            
        }   
    }
}