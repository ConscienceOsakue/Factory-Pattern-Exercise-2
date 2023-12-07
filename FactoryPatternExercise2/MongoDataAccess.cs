using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name = "Xbox", Price = 350},
            new Product (){ Name = "Shoe", Price = 450},
            new Product (){ Name = "Bags", Price = 500},
            new Product (){ Name = "Makeup", Price = 300},

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from my Mongo Data Access");
        }

    }
}

