using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Storage
    {


        //Data

        private Product[] array;
        private bool menuStatus= true;
        private int menuChoice;



        //Methods

        //Constructor
        public Storage()
        {
            array = new Product[100];
        }


        //General
        public Product this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }


        public void menu()
        {



            while (menuStatus)
            {
                Console.WriteLine("Enter a command: ");
                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {

                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;

                    case 0:
                        menuStatus = false;
                        Console.WriteLine("Exiting program");
                        break;

                }


            }




        }



        ~Storage() { }

    }
}
