using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2_4._1_Sigma_REWORK
{
    class Dairy_products: Product
    {
     

      
        public Dairy_products(string name, double weight, double price, string creationDate, int expirationDate) : 
            base( name,  weight, price,creationDate, expirationDate)
        {
            _expirationDate = expirationDate;
        }

       


        public override String ToString()
        {
            return $"(Name: {_name}, Weight: {_weight}, Price: {_price}, CreationDate: {_creationDate.ToString("MM/dd/yyyy")} ExpirationDate: {_expirationDate} )";
        }


        public Dairy_products Copy()
        {
            return (Dairy_products)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight,CreationDate, ExpirationDate);
        }


        public override bool Equals(object another)
        {
            if (another == null || GetType() != another.GetType())
                return false;

            var product = (Dairy_products)another;

            return Name == product.Name
                && Price == product.Price
                && Weight == product.Weight
                && ExpirationDate == product.ExpirationDate
                && CreationDate == product.CreationDate;


        }







    }

}
