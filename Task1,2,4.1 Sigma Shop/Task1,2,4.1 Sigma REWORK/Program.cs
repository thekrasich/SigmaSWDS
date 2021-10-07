using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;


namespace Task1_2_4._1_Sigma_REWORK
{
    class Program
    {
        static void Main(string[] args)
        {

            Storage storage = new Storage(20);
            string fileNameIn = @"D:\Study\C# Sigma University\REWORK\Task1,2,4.1 Sigma REWORK\Task1,2,4.1 Sigma REWORK\In.txt";
            Menu menu = new Menu();
            StorageFiller filler = new StorageFiller();
            
            storage.StorageFromFile(fileNameIn, filler);
         

            menu.MenuInitialisation(filler, storage);
            




        }
    }
}
