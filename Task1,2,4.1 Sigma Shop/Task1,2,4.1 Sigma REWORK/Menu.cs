using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2_4._1_Sigma_REWORK
{
    class Menu
    {
        public bool menuStatus = true;
        public string menuChoice;
        double submenuChoise;
        public Menu()
        {
            menuStatus = true;
        }

        //General
        public void MenuInitialisation(StorageFiller filler, Storage storage)
        {
           
            MenuChoicesConsolePrint();


            while (menuStatus)
            {
                Console.WriteLine("Enter a command: ");
                
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {

                    case "1":
                        //Storage filler
                        MenuStorageFillerChoice();
                        menuChoice = Console.ReadLine();
                        filler.StorageAddItem(storage,menuChoice);
                        break;
                    case "2":
                        storage.StorageConsolePrint(filler.Index);
                        break;
                    case "3":

                        storage.StorageMeatFinder(filler.Index);

                        break;
                    case "4":

                        Console.WriteLine("Enter percent of change: ");
                        submenuChoise = Double.Parse(Console.ReadLine());


                        storage.StorageAllPriceChange(filler.Index, submenuChoise);

                        break;

                    case "5":
                        Console.WriteLine("Enter info in format: Name.Price.Weight.CreationDate(mm/dd/yyyy).expirationDate");
                        string input = Console.ReadLine();
                        Product example = new Product();
                        example.Parse(input);

                        break;

                    case "6":

                        storage.StorageFindExpired(filler);



                        break;
                    case "0":
                        menuStatus = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Error! Enter command again;");
                        break;

                }
            }

        }
        public void MenuChoicesConsolePrint()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Add a Product to a Storage;");
            Console.WriteLine("2. Print All Products in Storage;");
            Console.WriteLine("3. Finds All Meat Products in Storage;");
            Console.WriteLine("4. Change Price for All Products in Storage");
            Console.WriteLine("5. Product.Parse Example");
            Console.WriteLine("6. Find Expired Dairy Products");
            Console.WriteLine("0. Finish the Program ");
        }

        public void MenuStorageFillerChoice()
        {
            Console.WriteLine("Choose Type of Product: ");
            Console.WriteLine("p - Casual Product;");
            Console.WriteLine("m - Meat;");
            Console.WriteLine("d - Dairy Product");
        }


    }

   


}