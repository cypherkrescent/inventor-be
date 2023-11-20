using FluentNHibernate.Mapping;

namespace Inventor_API.Models
{
    public class FoodItemMap : ClassMap<FoodItem>
    {
        public FoodItemMap()
        {
            Id(food => food.Id);
            Map(food => food.Name);
            Map(food => food.Description);


        }
    }
}
