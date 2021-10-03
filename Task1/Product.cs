using System;
using System.Collections.Generic;
using System.Text;

namespace Task1{

    class Product{

        //Data
        protected string name;
        protected double price;
        protected double weight;

        //Functions

        //Constructors
        #region Constructors

     
        public Product(){

            name = "NoName";
            price =  0;
            weight = 0;

        }
        public Product(string _name, double _price, double _weight)
        {
            this.name = _name;
            this.price = _price;
            this.weight = _weight;

        }

        //Properties

        public string Name
        {
            get 
            {
                return name; 
            }
            set 
            { 
                name = value;
            }
        }

     
        public double Price
        {
            get {
                return price; 
            }
            set {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

    

        public double Weight
        {
            get {
                return weight; 
            }
            set {

                if (value > 0)
                {

                    weight = value;

                }
                else
                {
                    weight = 0;
                }
            }
        }



        #endregion



        //General
        public virtual void ChangePrice(double percent)
        {
            double newPrice = price * (1 + percent);

            Price = newPrice;
        }







        //Object Override

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override String ToString()
        {
            return $"({name}, {price}, {weight})";
        }

        
        public Product Copy()
        {
            return (Product)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, price, weight, Name, Price, Weight);
        }


        //Destructor
        ~Product()
        {

        }



























    }
}
