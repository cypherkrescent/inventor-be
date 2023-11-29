namespace Inventor_API.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        Id(cate => cate.Id);
        Map(cate => cate.Name);
        HasOneToMany(cate => cate.Category);
    }
}
