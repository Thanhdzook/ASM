using System;
using BL;

namespace PL
{
    public class UpdateMobilePhoneMenu
    {
        public void DiaplayUpdateMobilePhoneMenu(string id)
        {
            UpdateBL updateMobilePhone = new UpdateBL();
            string[] options = { "Update Quantity", "Update Repair Warranty Period", "Update Price", "Exit" };
            string title = @"
███╗░░░███╗░█████╗░██████╗░██╗██╗░░░░░███████╗  ██████╗░██╗░░██╗░█████╗░███╗░░██╗███████╗
████╗░████║██╔══██╗██╔══██╗██║██║░░░░░██╔════╝  ██╔══██╗██║░░██║██╔══██╗████╗░██║██╔════╝
██╔████╔██║██║░░██║██████╦╝██║██║░░░░░█████╗░░  ██████╔╝███████║██║░░██║██╔██╗██║█████╗░░
██║╚██╔╝██║██║░░██║██╔══██╗██║██║░░░░░██╔══╝░░  ██╔═══╝░██╔══██║██║░░██║██║╚████║██╔══╝░░
██║░╚═╝░██║╚█████╔╝██████╦╝██║███████╗███████╗  ██║░░░░░██║░░██║╚█████╔╝██║░╚███║███████╗
╚═╝░░░░░╚═╝░╚════╝░╚═════╝░╚═╝╚══════╝╚══════╝  ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝░░╚══╝╚══════╝

███╗░░░███╗░█████╗░███╗░░██╗░█████╗░░██████╗░███████╗██████╗░
████╗░████║██╔══██╗████╗░██║██╔══██╗██╔════╝░██╔════╝██╔══██╗
██╔████╔██║███████║██╔██╗██║███████║██║░░██╗░█████╗░░██████╔╝
██║╚██╔╝██║██╔══██║██║╚████║██╔══██║██║░░╚██╗██╔══╝░░██╔══██╗
██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║╚██████╔╝███████╗██║░░██║
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚═╝";

            Keyboard keyboard = new Keyboard(title, options);       
            int SelectedIndex;
            do
            {
                SelectedIndex = keyboard.Run();
                switch (SelectedIndex)
                {
                    case 0:
                        updateMobilePhone.UpdateQuantity(id);
                        Console.ReadKey();
                        break;
                    case 1:
                        updateMobilePhone.UpdateTime(id);
                        Console.ReadKey();
                        break;
                    case 2:
                        updateMobilePhone.UpdatePrice(id);
                        Console.ReadKey();
                        break;
                }
            } while (SelectedIndex != 3);

        }
    }
}