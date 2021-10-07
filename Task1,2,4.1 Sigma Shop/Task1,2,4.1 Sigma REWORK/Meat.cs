using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2_4._1_Sigma_REWORK
{
    public enum Sort
    {
        FirstSort,
        SecondSort,
        HighestSort
    }
    public enum Kind
    {
        Mutton,
        Veal,
        Pork,
        Chicken

    }

    class Meat: Product
    {

        protected Kind _kind;
        protected Sort _sort;


        #region Constructors

        public Meat(string name, double weight, double price, string creationDate, int expirationDate, Kind kind, Sort sort):
            base(name, weight,price, creationDate, expirationDate)
        {
            _kind = kind;
            _sort = sort;
        }

        #endregion

        public override void ChangePrice(double percent)
        {
            double categoryPercent=0;

            if( _sort == Sort.HighestSort)
            {
                categoryPercent += 0.25;
            }
            else if(_sort == Sort.FirstSort)
            {
                categoryPercent += 0.15;
            }
            else if (_sort == Sort.SecondSort)
            {
                categoryPercent += 0.05;
            }


            Price *= (1 + percent+ categoryPercent);
        }


        public Sort Sort
        {
            get => _sort;
        }
        public Kind Kind
        {
            get => _kind;
        }







        public override String ToString()
        {
            return $"(Name: {_name}, Weight: {_weight}, Price: {_price}, MeatKind: {_kind}, MeatSort: {_sort},  CreationDate: {_creationDate.ToString("MM/dd/yyyy")}, ExpirationDate in: {_expirationDate} )";
        }

        public Meat Copy()
        {
            return (Meat)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight, Kind, Sort);
        }


        public override bool Equals(object another)
        {
            if (another == null || GetType() != another.GetType())
                return false;

            var product = (Meat)another;

            return Name == product.Name
                && Price == product.Price
                && Weight == product.Weight
                && Kind == product.Kind
                && Sort == product.Sort;
                
                
        }


    }
}
