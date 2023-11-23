namespace Inventor_API.Models
{
    public class FoodItem
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }


        public FoodItem(string name, string description)
        {

            Name = name;
            Description = description;

        }

        public FoodItem()
        {
        }
    }
}
