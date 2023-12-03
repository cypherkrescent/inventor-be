namespace Inventor_API.Models
{
    public class FoodItem
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Quantity { get; set; }

        public virtual List<Category> Category { get; set; }


        public FoodItem(string name, int quantity, List<Category> category)
        {

            Name = name;
            Quantity = quantity;
            Category = category;
        }

        public FoodItem()
        {
        }
    }
}
