using System;
using DAL;
using static System.Console;

namespace BL{
    public class DisplayBL{
        private ConsoleKey keyPressed;
        private int countId;
        public void SetDisplay(int id){
            DisplayPhone displayPhone = new DisplayPhone();
            displayPhone.Display(id , id + 11);
        }
        public void Display(string TK){
            countId = 0;
            int count = 1;
            int CountPhone;
            DisplayPhone countPhone = new DisplayPhone();
            if(countPhone.CountPhone()%10 != 0 ){
                CountPhone = countPhone.CountPhone() / 10 + 1;
            }
            else{
                CountPhone = countPhone.CountPhone() / 10;
            }
            do{
                Console.Clear();
                SetDisplay(countId);
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t    <   [{0}/{1}]   >" , count , (CountPhone));
                Console.WriteLine("\n");
                Console.WriteLine(" ● Press 'S' to search by name.");
                Console.WriteLine(" ● Press 'O' create Order.");
                Console.WriteLine(" ● Press 'Esc' to exit.");
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if(keyPressed == ConsoleKey.RightArrow){
                    countId = countId + 10;
                    count++;
                    if(count > CountPhone){
                        countId = countId - 10;
                        count--;
                    }
                }
                else if(keyPressed == ConsoleKey.LeftArrow){
                    countId = countId - 10;
                        count--;
                    if(count == 0){
                        countId = countId + 10;
                        count++;
                    }
                }
                else if (keyPressed == ConsoleKey.S)
                {
                    SearchBL searchBL = new SearchBL();
                    searchBL.Search();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (keyPressed == ConsoleKey.O)
                {
                    CustomerBL order = new CustomerBL();
                    order.CreateOrder(TK);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }while(keyPressed != ConsoleKey.Escape);
        }
    }
}