using System;
using BL;
using DAL;
namespace PL
{
    public class CustomerMenu
    {
        private ConsoleKey keyPressed;
        public void DisplayCustomerMenu(string TK)
        {

            string[] options = { "Display Mobile Phone Information", "Update Profile", "Exit" };
            string title = "Customer Account";
            UpdateCustomer update = new UpdateCustomer();
            

            Keyboard keyboard = new Keyboard(title, options);
            int SelectedIndex;
            do
            {
                SelectedIndex = keyboard.Run();
                switch (SelectedIndex)
                {
                    case 0:
                        DisplayBL displayPhone = new DisplayBL();
                        displayPhone.Display(TK);
                        break;
                    case 1:
                        Customer check = new Customer();
                        int result = check.CheckValue(TK);
                        if (result == 1)
                        {
                            
                            update.DisplayUpdateCustomer(TK);
                        }
                        else
                        {
                            Console.WriteLine("Enter your name and address to continue! ");
                            CustomerBL customer = new CustomerBL();
                            customer.Add(TK);
                            update.DisplayUpdateCustomer(TK);    
                        }
                        break;
                    case 2:
                        break;
                }
            } while (SelectedIndex != 2);

        }


    }
}
