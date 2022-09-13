using System;
using static System.Console;
using BL;
namespace PL
{
    public class Keyboard
    {
        private int SelectedIndex;
        private string[] Options;
        private string Title;
        
        public Keyboard(string title, string[] options)
        {
            Title = title;
            Options = options;
            SelectedIndex = 0;
        }
       
        
        private void DisplayOptions()
        {
            Console.WriteLine(Title);
            Console.WriteLine("\n");
            for (int i = 0; i < Options.Length; i++)
            {
                
                string currentIndex = Options[i];
                string prefex;
                if (i == SelectedIndex)
                {
                    prefex = ">";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefex = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($" {prefex} << {currentIndex} >>");
            }
            ResetColor();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                
            }while(keyPressed != ConsoleKey.Enter);
            
            return SelectedIndex;
        }
    }
}