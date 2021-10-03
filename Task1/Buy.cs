using System;
using System.Collections.Generic;
using System.Text;

namespace Task1 {
    class Buy {

        //Data

        private Product prod = new Product();
        private int amount;
        private double generalPrice;
        private double generalWeight;

        //Functions

        //Constructors
        public Buy()
        {
            prod.Name = "Noname";
            prod.Price = 0;
            prod.Weight = 0;
            amount = 0;
            generalPrice = 0;
            generalWeight = 0;
        }

        public Buy(Product _obj, int _amount)
        {
       
            this.prod.Name = _obj.Name;
            this.prod.Price = _obj.Price;
            this.prod.Weight = _obj.Weight;
            this.amount = _amount;
            this.generalPrice = prod.Price * _amount;
            this.generalWeight = prod.Weight * _amount;
        }

        //Propetries
        #region Propetries

     

        public int Amount
        {
            get {
                return amount;
            }
            set {
                if (value > 0)
                {
                    amount = value;
                    generalPrice = ProdPrice * amount;
                    generalWeight = ProdWeight * amount;
                }
                else
                {
                    amount = 0;
                    generalPrice = generalPrice * amount;
                    generalWeight = ProdWeight * amount;

                }
            }
        }



        public double GeneralPrice
        {
            get 
            {
                return generalPrice;
            }
            set
            {
                if(value > 0)
                {
                    generalPrice = value;
                }
                else
                {
                    generalPrice = 0;
                }


            }
        }

        

        public double GeneralWeight
        {
            get {
                return generalWeight; 
            
            }
            set {

                if (value > 0)
                {
                    generalWeight = value;
                }
                else
                {
                    generalWeight = 0;
                }


            }
        }



        public string ProdName
        {
            get { return prod.Name; }
            set { prod.Name = value; }
        }

        

        public double ProdWeight
        {
            get { return prod.Weight; }
            set 
            {
               
                if (value > 0)
                {
                    prod.Weight = value;
                    //if we change prod weight it also changes general weight
                    generalWeight = amount * prod.Weight;
                }
                else
                {
                    prod.Weight = 0;
                    generalWeight = amount * prod.Weight;
                }               
            }
        }

      

        public double ProdPrice
        {
            get { return prod.Price; }
            set
            { 
                if (value > 0)
                {
                    prod.Price = value;
                    //if we change prod price it also changes general price
                    generalPrice = amount * prod.Price;


                }
                else
                {
                    prod.Price = 0;
                    generalPrice = amount * prod.Price;
                }
            }
        }

        #endregion


        //General

        public  void ChangePrice(double percent)
        {
            double newPrice = prod.Price * (1 + percent);

            prod.Price = newPrice;
        }












        //Override
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override String ToString()
        {
            return $"({prod.Name}, {prod.Price}, {prod.Weight}, {amount}, {generalPrice}, {generalWeight})";
        }


        public Buy Copy()
        {
            return (Buy)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(prod);
            hash.Add(amount);
            hash.Add(generalPrice);
            hash.Add(generalWeight);
            hash.Add(Amount);
            hash.Add(GeneralPrice);
            hash.Add(GeneralWeight);
            hash.Add(ProdName);
            hash.Add(ProdWeight);
            hash.Add(ProdPrice);
            return hash.ToHashCode();
        }






        //Destructor
        ~Buy()
        {

        }





    }


     



























    
}
