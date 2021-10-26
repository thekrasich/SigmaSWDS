using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7._2_Menu
{
    class Dish
    {
        public string name;
        public Dictionary<string, double> components = new Dictionary<string, double>();



        public Dish()
        {
            name = "Noname";
            components.Add("noname", 0);
        }

        public void AddComponent(string name, double weight)
        {

            components.Add(name, weight);

        }
       

        public string Name
        {
            set
            {
                name = value;
            }
        }
            


    }
}
