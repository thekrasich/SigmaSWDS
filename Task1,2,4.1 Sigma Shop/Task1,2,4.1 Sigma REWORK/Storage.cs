using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading.Tasks;

namespace Task1_2_4._1_Sigma_REWORK
{
    class Storage
    {

        protected Product[] _products;
        private int _capacity = 0;

        #region Constructors
        //Constructors
        public Storage(int capacity)
        {
            _capacity = capacity;
            _products = new Product[_capacity];
        }

        #endregion

        //General

        public Product this[int index]
        {
            get => _products[index];

        }

        public void StorageAddProduct(int index, string name, double weight, double price, string creationDate, int expirationDate)
        {
            _products[index] = new Product(name, weight, price, creationDate, expirationDate);
        }
        public void StorageAddDairyProduct(int index, string name, double weight, double price, string creationDate, int expirationDate)
        {
            _products[index] = new Dairy_products(name, weight, price, creationDate, expirationDate);
        }
        public void StorageAddMeat(int index, string name, double weight, double price, Sort sort, Kind kind, string creationDate, int expirationDate)
        {
            _products[index] = new Meat(name, weight, price, creationDate, expirationDate, kind, sort);
        }

        public void StorageConsolePrint(int index)
        {
            Check check = new Check();

            for (int i = 0; i < index; i++)
            {
                check.CheckPrint(_products[i]);
            }

        }

        public void StorageMeatFinder(int index)
        {

            for (int i = 0; i < index; i++)
            {
                if (_products[i] is Meat)
                {
                    Console.WriteLine($"Meat Product is Located at Position: {i}");


                }




            }

        }

        public void StorageAllPriceChange(int index, double percent)
        {
            for (int i = 0; i < index; i++)
            {
                _products[i].ChangePrice(percent);
            }


        }

        public void StorageFromFile(string filePath, StorageFiller filler)
        {
            using (TextReader reader = File.OpenText(filePath))
            {
                _capacity = int.Parse(reader.ReadLine());
                filler.Index = int.Parse(reader.ReadLine());

                if (_capacity < 0)
                {
                    _capacity = 1;
                }
                //Initialisation
                for (int i = 0; i < _capacity; i++)
                {
                    _products[i] = new Product();
                }



                for (int i = 0; i < filler.Index; i++)
                {
                    _products[i].Name = reader.ReadLine();
                    _products[i].Price = Double.Parse(reader.ReadLine());
                    _products[i].Weight = Double.Parse(reader.ReadLine());
                    _products[i].CreationDate = DateTime.Parse(reader.ReadLine());
                    _products[i].ExpirationDate = Int32.Parse(reader.ReadLine());
                }








            }







        }


        public void StorageFindExpired(StorageFiller filler)
        {
            string output = "";
            DateTime currentDate = DateTime.Now;
            TimeSpan value;
            double substract = 0;
            for (int i = 0; i < filler.Index; i++)
            {
                
                if (_products[i] is Dairy_products)
                {

                    value = currentDate.Subtract(_products[i].CreationDate);
                    substract = value.Days;
                    
                    if (substract >= _products[i].ExpirationDate)
                    {
                        Console.WriteLine($"Expired Dairy at positions {i}");
                    }
                    

                }
                





            }









        }


    }



















    
}
