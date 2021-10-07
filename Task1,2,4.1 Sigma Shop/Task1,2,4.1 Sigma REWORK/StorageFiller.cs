using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2_4._1_Sigma_REWORK
{
    class StorageFiller
    {
        private int _index = 0 ;
        public StorageFiller() { }

        public int Index
        { get => _index;
            set { if (value >= 0) { value = _index; }  }
        }


        public void StorageAddItem(Storage storage, string typeOfProduct )
        {

            




            if(typeOfProduct == "m")
            {

                System.Console.WriteLine("What Kind of Meat:");
                fillerMeatKindChoice();
                string meatKind = System.Console.ReadLine();
                Kind kind = (Kind)Convert.ToInt32(meatKind);


                System.Console.WriteLine("What Sort of Meat:");
                fillerMeatSortChoice();
                string meatSort = System.Console.ReadLine();
                Sort sort = (Sort)Convert.ToInt32(meatSort);



                Console.WriteLine("Enter name of product:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price of product:");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter weight of product:");
                double weight = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Creation Date of Product: (mm/dd/yyyy)");
                string creationDate = Console.ReadLine();
                Console.WriteLine("Enter name of product:");
                int expirationDate =Int32.Parse(Console.ReadLine());
                storage.StorageAddMeat(_index, name, weight, price,sort, kind,creationDate,expirationDate);
                _index++;
            }
            else if (typeOfProduct == "p")
            {

                Console.WriteLine("Enter name of product:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price of product:");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter weight of product:");
                double weight = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Creation Date of product: (mm/dd/yyyy)");
                string creationDate = Console.ReadLine();
                Console.WriteLine("Enter Expiration Date of product:");
                 int expirationDate =Int32.Parse(Console.ReadLine());

                storage.StorageAddProduct(_index, name, weight, price,creationDate,expirationDate);
                _index++;
            }
            else if (typeOfProduct =="d")
            {

                Console.WriteLine("Enter name of product:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price of product:");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter weight of product:");
                double weight = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Creation Date:");
                string creationDate = Console.ReadLine();
                Console.WriteLine("Enter Expiration Date: (mm/dd/yyyy)");
                int expirationDate = Int32.Parse(Console.ReadLine());

                storage.StorageAddDairyProduct(_index, name, weight, price,creationDate,expirationDate);
                _index++;

            }



           




        }



        public void fillerMeatKindChoice()
        {

            Console.WriteLine("0 - Mutton");
            Console.WriteLine("1 - Veal ");
            Console.WriteLine("2 - Pork ");
            Console.WriteLine("3 - Chicken ");
        }
        public void fillerMeatSortChoice()
        {
            Console.WriteLine("0 - FirstSort");
            Console.WriteLine("1 - SecondSort");
            Console.WriteLine("2 - HighestSort");

        }

    }
}
