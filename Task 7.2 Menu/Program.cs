using System;

namespace Task_7._2_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Menu menu = new Menu();
            string path = @"D:\Study\C# Sigma University\Task 7.2 Menu\Task 7.2 Menu\DishIn.txt";
            menu.MenuFileRead(path, menu._dishes,menu._amount);
          
        }
    }
}
