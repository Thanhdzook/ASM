using System;
using DAL;
using BL;

namespace PL
{
    public class PhoneManagerMenu
    {
        public void DiaplayPhoneManager()
        {
            DisplayDAL displayDAL = new DisplayDAL();
            AddBL addMobilePhone = new AddBL();
            SearchBL searchMobilePhone = new SearchBL();
            UpdateMobilePhoneMenu updateMobilePhoneMenu = new UpdateMobilePhoneMenu();
            string[] options = { "Display Mobile Phone Information", "Add Mobile Phone", "Search Mobile Phone", "Update Mobile Phone", "Delete Mobile Phone" , "Exit" };
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
                        Console.Clear();
                        displayDAL.Display();
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        addMobilePhone.Add();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        searchMobilePhone.Search();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        string id = searchMobilePhone.SearchUpdate();
                        if(id != null){
                            updateMobilePhoneMenu.DiaplayUpdateMobilePhoneMenu(id);
                        }
                        else{
                            Console.WriteLine("ID not found !");
                        }
                        Console.ReadKey();
                        break;
                        
                    case 4:
                        Console.Clear();
                        DeleteBL deleteMobilePhone = new DeleteBL();
                        deleteMobilePhone.Delete();
                        Console.ReadKey();
                        break;
                }
            } while (SelectedIndex != 5);

        }
    }
}