namespace Inventor_API.Models
{
    public class Category : BaseClass

    {
        public Category () 
        {

        }

        public Category (string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }

        public IList<FoodItem> FoodItems { get; set; }
    }
}
