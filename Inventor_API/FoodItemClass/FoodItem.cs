using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoodItemClass
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public FoodItem(int id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price}");
        }

        public FoodItem()
        {
        }

        //public void FoodDisplay() 
        //{
        //    Console.WriteLine($"Id: {ID}");
        //    Console.WriteLine($"Name: {Name}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Price: {Price}");
        //}

    }

 
}
