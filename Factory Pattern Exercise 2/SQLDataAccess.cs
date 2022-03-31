using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise_2
{
    class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Nintendo Switch", Price = 400},
            new Product(){Name = "Taylormade Driver", Price = 400},
            new Product(){Name = "Xbox", Price = 350},
            new Product(){Name = "Piano", Price = 1000},


        };

        public List <Product> LoadData()
        {
            Console.WriteLine($"I am reading data from the SQL Data Access");
            return Products;

        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to the SQL data access");
        }
    }
}
