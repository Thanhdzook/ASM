using System;
using BL;

namespace PL
{
    public class Program
    {
        public static void Main()
        {
            LoginAndSignInBLL loginAndSignIn = new LoginAndSignInBLL();
            string[] options = { "Login", "Sign In", "Exit" };
            string title = @"
░█████╗░████████╗  ░██████╗████████╗░█████╗░██████╗░███████╗
██╔══██╗╚══██╔══╝  ██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝░░░██║░░░  ╚█████╗░░░░██║░░░██║░░██║██████╔╝█████╗░░
██║░░██╗░░░██║░░░  ░╚═══██╗░░░██║░░░██║░░██║██╔══██╗██╔══╝░░
╚█████╔╝░░░██║░░░  ██████╔╝░░░██║░░░╚█████╔╝██║░░██║███████╗
░╚════╝░░░░╚═╝░░░  ╚═════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚══════╝";
            Keyboard keyboard = new Keyboard(title, options);       
            int SelectedIndex;
            do
            {
                SelectedIndex = keyboard.Run();
                switch (SelectedIndex)
                {
                    case 0:
                        string checkLoginSignIn = loginAndSignIn.login();
                        if(checkLoginSignIn == "1"){
                            Console.Clear();
                            AdminMenu adminMenu = new AdminMenu();
                            adminMenu.DisplayAdminMenu();
                        }
                        else if(checkLoginSignIn != "1" && checkLoginSignIn != null){
                            Console.Clear();
                            CustomerMenu customerMenu = new CustomerMenu();
                            customerMenu.DisplayCustomerMenu(checkLoginSignIn);
                        }
                        else {
                            Console.Clear();
                            Console.WriteLine("login false");
                            Console.ReadKey();
                        }
                        break;
                    case 1:
                        loginAndSignIn.SignIn();
                        Console.ReadKey();
                        break;
                    case 2:
                        
                        loginAndSignIn.exit();
                        break;
                }
            } while (SelectedIndex != 2);
        }
    }
}