using System;
using DAL;
namespace BL
{
    public class CustomerBL
    {
        private string Id;
        private string Name;
        private string PhoneNumber;
        private string Address;
        private string Quantity;
        private string Password;



        public void CreateOrder(string TK)
        {
            do{
                Customer check1 = new Customer();
                int result = check1.CheckValue(TK);
                if (result != 1)
                {
                    Console.WriteLine("Enter your name and address to continue! ");
                    CustomerBL customer = new CustomerBL();
                    customer.Add(TK);
                }
                Console.Clear();
                Console.Write("Input Id (input 0 to cancel): ");
                Id = Console.ReadLine();
                CheckID check = new CheckID();
                if (check.Check(Id) == 1)
                {
                    Customer order = new Customer();
                    order.DisplayOrder(Id);
                    Console.Write("Input Quantity : ");
                    Quantity = Console.ReadLine();
                    if (check1.checkQuantity(Quantity,Id) == 1)
                    {
                        check1.AddOrder(check1.PhoneInformation(Id , 1) , check1.PhoneInformation(Id , 2) , check1.PhoneInformation(Id , 3) , check1.CustomerInformation(TK , 1), check1.CustomerInformation(TK , 2), check1.CustomerInformation(TK , 3) , "unpaid");
                        Console.WriteLine("Customer Information  ");
                        check1.DisplayCustomerInfo(TK);
                        if(check1.PhoneInformation(Id , 3) == Quantity){
                            DeleteDAL delete = new DeleteDAL();
                            delete.Delete(Id);
                        }
                        check1.UpdateQuantity(Id , Quantity);
                        Console.ReadKey();
                    }
                    else{
                        Console.WriteLine("the number of phones in the store is not enough");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("id not found");
                }
            }while ( Id != "0" );

        }
        public void Add(string TK)
        {
            Console.Write("Input Name : ");
            Name = Console.ReadLine();
            Console.Write("Input Address : ");
            Address = Console.ReadLine();
            Customer add = new Customer();
            add.AddCustomer(Name, Address, TK);

        }
        public void UpdatePassword(string tk)
        {
            Console.Write("Input Quantity : ");
            Password = Console.ReadLine();
            Customer update = new Customer();
            update.UpdatePassword(Password, tk);
        }
        public void UpdatePhoneNumber(string tk)
        {
            Console.Write("Input Phone Number : ");
            PhoneNumber = Console.ReadLine();
            Customer update = new Customer();
            update.UpdatePassword(PhoneNumber, tk);
        }
        public void UpdateAddress(string tk)
        {
            Console.Write("Input Address : ");
            Address = Console.ReadLine();
            Customer update = new Customer();
            update.UpdatePassword(Address, tk);
        }
    }
}