using System;
using DAL;

namespace BL{
    public class AddBL{
        private string Id;
        private string Name;
        private string Color;
        private string Brand;
        private string CPU;
        private string Ram;
        private string Memory;
        private string Weight;
        private string Pin;
        private string Size;
        private string Quantity;
        private string Time;
        private string Price;
        public void Add(){
            Console.Write("Input Id : ");
            Id = Console.ReadLine();
            CheckID check = new CheckID();
            while(check.Check(Id) == 1){
                Console.WriteLine("ID already exists");
                Console.Write("Input Id : ");
                Id = Console.ReadLine();
            }
            Console.Write("Input Name : ");
            Name = Console.ReadLine();
            Console.Write("Input Color : ");
            Color = Console.ReadLine();
            Console.Write("Input Brand : ");
            Brand = Console.ReadLine();
            Console.Write("Input CPU : ");
            CPU = Console.ReadLine();
            Console.Write("Input RAM : ");
            Ram = Console.ReadLine();
            Console.Write("Input Memory : ");
            Memory = Console.ReadLine();
            Console.Write("Input Weight : ");
            Weight = Console.ReadLine();
            Console.Write("Input Pin : ");
            Pin = Console.ReadLine();
            Console.Write("Input Size : ");
            Size = Console.ReadLine();
            Console.Write("Input Quantity : ");
            Quantity = Console.ReadLine();
            Console.Write("Input Price : ");
            Price = Console.ReadLine();
            Console.Write("Input Time : ");
            Time = Console.ReadLine();
            AddDAL add = new AddDAL();
            add.Add(Id , Name , Color , Brand , CPU , Ram , Memory , Weight , Pin , Size , Quantity , Price , Time );
            
        }
        
    }
}