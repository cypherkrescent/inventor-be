namespace Inventor_API.Mappings
{
    public class RestuarantMap : ClassMap<Restuarant>
    {
        Id(res => res.Id);
        Map(food => food.Name);
        HasOneToMany(food => food.FoodItem);

    }
}
