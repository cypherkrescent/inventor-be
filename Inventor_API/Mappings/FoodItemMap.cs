
using Inventor_API.Models;

namespace Inventor_API.Mappings
{
    public class FoodItemMap : ClassMap<FoodItem>
    {
        public FoodItemMap()
        {
            Id(food => food.Id);
            Map(food => food.Name);
            HasOneToMany(food => food.Category);


        }
    }
}
