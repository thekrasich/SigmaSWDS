using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{

    public enum Sort
    {
        first=1,
        second=2
    }
    public enum Kind
    {
        lamb=0,
        veal=1,
        pork=2,
        chicken=3
    }

    class Meat: Product
    {


        //Data
       
        protected Sort sort;
        protected Kind kind;

        //Functions


        //Constructors

        public Meat()
        {
            this.name = "Noname";
            this.weight = 0;
            this.price = 0;
            this.sort = (Sort)1;
            this.kind = (Kind)2;
            

        }

        public Meat(string _name, double _price, double _weight, Sort _sort , Kind _kind )
            :base(_name,_price, _weight)
        {

            this.sort = _sort;
            this.kind = _kind;

        }


        //Properties
        #region Properties

       
        public Sort Psort
        {
            get
            {
                return sort;
            }
            set
            {

                if (value == Sort.first || value == Sort.second)
                {
                    sort = value;
                }
                else
                {
                    
                    sort = Sort.first; ;
                }
              
            
            
            }
        }


        public Kind Pkind
        {
            get
            {
                return kind;
            }
            set
            { 

                if(value>=Kind.lamb && value <= Kind.chicken)
                {

                    kind = value;
                }
                else
                {
                    kind = Kind.chicken;
                }
                
            
            
            
            }
        }

        #endregion


        //General


        public void ChangePrice(double percent, Sort sort )
        {
            double sortPercent = 0;

            if(sort == Sort.first)
            {
                sortPercent = 1.1;
            }
            if (sort == Sort.second)
            {
                sortPercent = 1.2;
            }


            double newPrice = price * (1 + percent * sortPercent  );

            price = newPrice;
        }








        //Override
        public override bool Equals(object obj)
        {


            if (obj.GetType() == this.GetType())
            {
                var p = (Meat)obj;
                if (p.name == this.name && p.price == this.price && p.weight == this.weight && p.sort==this.sort && p.kind ==this.kind)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            { return false; }

            
            
            
            
          
        }



        public override String ToString()
        {
            return $"({name}, {price}, {weight}, {sort},{kind})";
        }


        public Meat Copy()
        {
            return (Meat)this.MemberwiseClone();
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
            hash.Add(sort);
            hash.Add(kind);
            hash.Add(Psort);
            hash.Add(Pkind);
            return hash.ToHashCode();
        }


        //Destructor
        ~Meat() { }


    }
}
