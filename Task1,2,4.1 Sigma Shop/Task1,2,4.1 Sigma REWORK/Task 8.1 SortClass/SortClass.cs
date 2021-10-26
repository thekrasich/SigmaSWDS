using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8._1_Sort
{
    class SortClass
    {
        public delegate bool Comparsion(Product firstProduct, Product secondProduct );



        public static void Sort(Product[] products, int amount , Comparsion comparsion)
        {
            Product temp = new Product();

            for(int i = 0;i < amount ;i++ )
            {
                for(int j = 0;j< amount-i-1 ;j++ )
                {
                    if (comparsion(products[j],products[j+1]))
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }


        static public bool PriceComparcion(Product firstProduct, Product secondProduct)
        {
            if (firstProduct.Price >= secondProduct.Price) { return true; }
            else { return false; }

        }
        static public  bool WeightComparcion(Product firstProduct, Product secondProduct)
        {
            if (firstProduct.Weight >= secondProduct.Weight) { return true; }
            else { return false; }

        }








    }
}
