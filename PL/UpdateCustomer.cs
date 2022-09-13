using System;
using BL;

namespace PL
{
    public class UpdateCustomer
    {
        public void DisplayUpdateCustomer(string id)
        {
            CustomerBL customer = new CustomerBL();
            string[] options = { "Update Password", "Update Phone Number", "Update Address", "Exit" };
            string title = "Update Customer";

            Keyboard keyboard = new Keyboard(title, options);       
            int SelectedIndex;
            do
            {
                SelectedIndex = keyboard.Run();
                switch (SelectedIndex)
                {
                    case 0:
                        customer.UpdatePassword(id);
                        Console.ReadKey();
                        break;
                    case 1:
                        customer.UpdatePhoneNumber(id);
                        Console.ReadKey();
                        break;
                    case 2:
                        customer.UpdateAddress(id);
                        Console.ReadKey();
                        break;
                }
            } while (SelectedIndex != 3);

        }
    }
}