namespace Inventor_API.Models
{
    public class FoodItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public FoodItem(string name, string description, double price)
        {

            Name = name;
            Description = description;



        }

        public FoodItem()
        {
        }
    }
}