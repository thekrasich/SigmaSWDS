using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace Task_7._2_Menu
{
    class Menu
    {
        public Dish[] _dishes = new Dish[100];
        public int _amount;







        public void MenuFileRead(string path, Dish[] dishes, int amount)
        {
            using (TextReader reader = File.OpenText(path))
            {
                int amountOfComp;
                double weight;
                string dishName;
                string compName;


                amount = int.Parse(reader.ReadLine());
                if (amount < 0)
                {
                    amount = 1;
                }



                //Initialisation
                for (int i = 0; i < amount; i++)
                {
                    dishes[i] = new Dish();
                }






                for (int i = 0; i < amount; i++)
                {
                    dishes[i].name = reader.ReadLine();
                    amountOfComp = int.Parse(reader.ReadLine());

                    for (int j = 0; j < amountOfComp; j++)
                    {

                        compName = reader.ReadLine();
                        weight = Double.Parse(reader.ReadLine());
                        dishes[i].AddComponent(compName, weight);
                    }











                }










            }



        }
    }
}
