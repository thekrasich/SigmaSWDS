using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2_4._1_Sigma_REWORK
{
    class Product
    {

      
        protected string _name;
        protected double _weight;
        protected double _price;
        protected int _expirationDate;
        protected DateTime _creationDate;



        #region Constructors

        //Constructors
        public Product()
        {

            _name = "Noname";
            _weight = 0;
            _price = 0;
            _creationDate = new DateTime();
            _expirationDate = 0;
        }
        public Product(string name, double weight, double price, string creationDate , int expirationDate)
        {

            _name = name;
            _weight = weight;
            _price = price;
            _creationDate = DateTime.Parse(creationDate);
            _expirationDate = expirationDate;
        }
        #endregion

        //Properties

        #region Properties


        public double Weight
        {
            get => _weight; 
            set {
               if(value > 0)
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
            get=>_name; 
            set=> _name = value; 
        }

        public double Price
        {
            get =>  _price; 
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

        public DateTime CreationDate
        {
            get => _creationDate;
            set
            {
                _creationDate = value;
            }
        }
        public int ExpirationDate
        {
            get => _expirationDate;
            set
            {
                if (value>0)
                {
                    _expirationDate = value;
                }
                else
                {
                    _expirationDate = 0;
                }
            }
        }
        #endregion


        //General

        #region Object override

        
        public override String ToString()
        {
            return $"(Name: {_name}, Weight: {_weight}, Price: {_price}, CreationDate: {_creationDate.ToString("MM/dd/yyyy")}, ExpirationDate in: {_expirationDate})";
        }

        public Product Copy()
        {
            return (Product)this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Weight,CreationDate, ExpirationDate);
        }


        public override bool Equals(object another)
        {
            if (another == null || GetType() != another.GetType())
                return false;

            var product = (Product)another;

            return Name == product.Name
                && Price == product.Price
                && Weight == product.Weight
                && CreationDate == product.CreationDate
                && ExpirationDate == product.ExpirationDate;
        }

        #endregion


        public virtual void ChangePrice(double percent)
        {
            Price *= (1 + percent);
        }

        public void Parse(string input)
        {
            //Format name.price.weight.creationdate(mm/dd/yyyy).expirationdate)
            string redStr ="";
            string[] infoStr = new string[5];
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    redStr += input[i];


                }
            }

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] !='.')
                {
                    infoStr[counter] += input[i];




                }
                else
                {
                    counter++;
                }

            }

            _name = infoStr[0];

            _price = Double.Parse(infoStr[1]);

            _weight = Double.Parse(infoStr[2]);

            _creationDate = Convert.ToDateTime(infoStr[3]);

            _expirationDate = Convert.ToInt32(infoStr[4]);







        }



    }
}
