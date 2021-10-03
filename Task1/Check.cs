using System;
using System.Collections.Generic;
using System.Text;

namespace Task1{
    class Check{

        //Data
        //Nothing


        //Functions
        
        //For Buy class
        public void show(Buy obj)
        {
            Console.WriteLine("Name of Product: ");
            Console.WriteLine(obj.ProdName);
            Console.WriteLine("Weigth of 1 unit of Product: ");
            Console.WriteLine(obj.ProdWeight);
            Console.WriteLine("Price of 1 unit of Product: ");
            Console.WriteLine(obj.ProdPrice);
            Console.WriteLine("Amount of Products: ");
            Console.WriteLine(obj.Amount);
            Console.WriteLine("General Price: ");
            Console.WriteLine(obj.GeneralPrice);
            Console.WriteLine("General Weight: ");
            Console.WriteLine(obj.GeneralWeight);

        }

        //For Product Class
        public void show(Product obj)
        {
            Console.WriteLine("Name of Product: ");
            Console.WriteLine(obj.Name);
            Console.WriteLine("Weigth of 1 unit of Product: ");
            Console.WriteLine(obj.Weight);
            Console.WriteLine("Price of 1 unit of Product: ");
            Console.WriteLine(obj.Price);
          

        }

        //For Meat Class

        public void show(Meat obj)
        {
            Console.WriteLine("Name of Product: ");
            Console.WriteLine(obj.Name);
            Console.WriteLine("Weigth of 1 unit of Product: ");
            Console.WriteLine(obj.Weight);
            Console.WriteLine("Price of 1 unit of Product: ");
            Console.WriteLine(obj.Price);
            Console.WriteLine("Sort of Meat: ");
            Console.WriteLine(obj.Psort);
            Console.WriteLine("Kind of Meat: ");
            Console.WriteLine(obj.Pkind);
        }



        //Destructor
        ~Check()
        {

        }

    }
}
