using System;

namespace PL
{
    public class CustomerManagerMenu
    {
        public void DisplayCustomerManager()
        {
            string[] options = { "Display Customer Information", "NGhI DE", "Exit" };
            string title = @"
░█████╗░██╗░░░██╗░██████╗████████╗░█████╗░███╗░░░███╗███████╗██████╗░
██╔══██╗██║░░░██║██╔════╝╚══██╔══╝██╔══██╗████╗░████║██╔════╝██╔══██╗
██║░░╚═╝██║░░░██║╚█████╗░░░░██║░░░██║░░██║██╔████╔██║█████╗░░██████╔╝
██║░░██╗██║░░░██║░╚═══██╗░░░██║░░░██║░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗
╚█████╔╝╚██████╔╝██████╔╝░░░██║░░░╚█████╔╝██║░╚═╝░██║███████╗██║░░██║
░╚════╝░░╚═════╝░╚═════╝░░░░╚═╝░░░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝

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

                        break;
                    case 1:

                        break;
                    case 2:
                        break;
                }
            } while (SelectedIndex != 2);
            

        }
    }
}