using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Dairy_products: Product
    {
        //data
        protected int expirationDate;

        //Functions 

        //Constructors

        public Dairy_products()
        {
            this.name = "Noname";
            this.weight = 0;
            this.price = 0;
            this.expirationDate = 0;
        
        }

        public Dairy_products(string _name, double _price, double _weight, int _expirationDate)
            :base(_name, _price,_weight)
        {

            this.expirationDate = _expirationDate;

        }

        //Properties

       
        public int ExpirationDate
        {
            get 
            {
                return expirationDate;
            }
            set 
            { 

                if(expirationDate > 0)
                {
                    expirationDate = value;
                }
                else
                {
                    expirationDate = 0;
                }



            }
        }

        //General

        public void ChangePrice(double percent, int _expirationDate)
        {
            double newPrice = price * (1 + percent+ (_expirationDate/10));

            price = newPrice;
        }



        //Override
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override String ToString()
        {
            return $"({name}, {price}, {weight}, {expirationDate})";
        }


        public Dairy_products Copy()
        {
            return (Dairy_products)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(name);
            hash.Add(price);
            hash.Add(weight);
            hash.Add(Name);
            hash.Add(Price);
            hash.Add(Weight);
            hash.Add(expirationDate);
            hash.Add(ExpirationDate);
            return hash.ToHashCode();
        }








        //Destructor
        ~Dairy_products() { }

    }
}
