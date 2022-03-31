﻿using System;

namespace Factory_Pattern_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What database would you like to work with?");
            Console.WriteLine($"Type : List?");
            Console.WriteLine($"Type : SQL?");
            Console.WriteLine($"Type : Mongo?");

            var userInput = Console.ReadLine();
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var item in products)
            {
                Console.WriteLine($"Name : {item.Name}, Price : {item.Price}, ");
            }



        }
    }
}
