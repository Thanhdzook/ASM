using System;
using DAL;

namespace BL
{
    public class LoginAndSignInBLL
    {
        private string Account;
        private string Password;

        private string PhoneNumber;


        public string login()
        {
            Console.Clear();
            Console.Write("ImPort Account  : ");
            Account = Console.ReadLine();
            Console.Write("Import Password : ");
            Password = Console.ReadLine();
            LoginDAL login = new LoginDAL();
            if (login.Login(Account, Password) == "1")
            {
                return "1";
            }
            else if (login.Login(Account, Password) != "1" && login.Login(Account, Password) != null)
            {
                return $"{login.Login(Account, Password)}";
            }
            else
            {
                return null;
            }
        }
        public void SignIn()
        {
            Console.Write("Input User Name : ");
            Account = Console.ReadLine();
            Console.Write("Input Password : ");
            Password = Console.ReadLine();
            Console.Write("Input Phone Number : ");
            PhoneNumber = Console.ReadLine();
            LoginDAL login = new LoginDAL();
            if (login.Login(Account, Password) == "1")
            {
                Console.WriteLine("Username already used !");
            }
            else if (login.Login(Account, Password) != "1" && login.Login(Account, Password) != null)
            {
                Console.WriteLine("Username already used !");
            }
            else
            {
                Console.WriteLine("Sign Up Success");
                LoginDAL signIn = new LoginDAL();
                signIn.SignIn(Account, Password, PhoneNumber);
            }
            
        }
        public void exit()
        {
            Console.WriteLine("Press any key to exit ... ");
            Console.ReadKey();
        }
    }

}