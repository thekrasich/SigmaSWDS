using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8._1_Sort
{
    class Product
    {
        protected string _name;
        protected double _weight;
        protected double _price;

        #region Prop

        
        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 0;
                }
            }
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0;
                }
            }
        }
        #endregion

       public Product()
       {
            _name = "noname";
            _weight = 0;
            _price = 0;

       }
        public Product(string name, double weight, double price)
        {
            _name = name;
            _weight = weight;
            _price = price;

        }

       


    }
}
