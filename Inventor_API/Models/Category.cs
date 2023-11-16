namespace Inventor_API.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FoodItem> FoodItems { get; set; } = new List<FoodItem>();
    }
}
