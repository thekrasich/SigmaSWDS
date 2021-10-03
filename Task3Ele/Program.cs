using System;

namespace Sigma_Task_3_electricity_accounting
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declaration

            //Household

            string filePath = @"D:\Study\C# Sigma University\Task 3\Sigma Task 3 electricity accounting\Sigma Task 3 electricity accounting\in.txt";

            Household[] households = new Household[50];
            Household flat = new Household();

            flat.ReadFromFile(filePath,households);
            int _amount = flat.amount;

            //Menu
            bool menuStatus = true;
            int menuChoice;
            int indexChoice;
            double price;
            flat.HouseHoldMenu();



            while (menuStatus)
            {
                Console.WriteLine("Enter command ");
                menuChoice = Int32.Parse(Console.ReadLine());

                switch (menuChoice)
                {

                    case 1:
                        flat.HouseholdsPrint(_amount, households);
                        break;
                    case 2:
                        Console.WriteLine("Enter index of household ");
                        indexChoice = Int32.Parse(Console.ReadLine());
                        if(indexChoice>0 && indexChoice <= _amount)
                        {

                            flat.HouseholdPrint(indexChoice, households);


                        }
                        else
                        {
                            break;
                        }

                        break;

                    case 3:

                        Console.WriteLine("Enter price of electicity: ");
                        price = Int32.Parse(Console.ReadLine());

                        flat.HouseholdsMaxDebd(_amount, households, price);

                        break;

                    case 4:

                        flat.HouseholdWithoutEnergyUsage(_amount, households);


                        break;


                    case 10:
                        Console.WriteLine("Exiting...");
                        menuStatus = false;
                        break;


                    default:
                        Console.WriteLine("Error! Enter command again: ");
                        menuChoice = Int32.Parse(Console.ReadLine());
                        break;
                }




            }













        }
    }
}
