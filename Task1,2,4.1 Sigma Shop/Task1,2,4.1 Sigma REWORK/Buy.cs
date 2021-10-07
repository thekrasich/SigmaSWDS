using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2_4._1_Sigma_REWORK
{
    class Buy
    {

        private Product _product;
        private int _amount;
        

        #region Constructors
        //Constructors

        public Buy()
        {
            _amount = 0;
        }

        public Buy(int amount, Product product)
        {
            _product = product;
            Amount = amount;


        }

        #endregion

        #region Properties

        //Properties
        public int Amount
        {
            get => _amount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Amount cannot be negative", nameof(Amount));
                    
                }
                else
                {
                    _amount = value;
                }
            }
            
        }
        public Product Product => _product;

        public double GeneralPrice => _product.Price * Amount;

        public double GeneralWeight => _product.Weight * Amount;




        #endregion

        //General









        #region Object override
        //Object override
       
        public override bool Equals(object another)
        {
            if (another == null || GetType() != another.GetType())
                return false;

            var buy = (Buy)another;

            return Product == buy.Product
                && Amount == buy.Amount;
        }

        public override String ToString()
        {
            return $"({Product.Name}, {Product.Price}, {Product.Weight}, {Amount}, {GeneralPrice}, {GeneralWeight})";
        }

        public Buy Copy()
        {
            return (Buy)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Product);
            hash.Add(Amount);
            return hash.ToHashCode();
        }


        #endregion


    }

}
