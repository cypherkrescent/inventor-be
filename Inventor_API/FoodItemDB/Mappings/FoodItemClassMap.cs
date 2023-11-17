using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodItemClass;

namespace FoodItemDB.Mappings
{
    public class FoodItemClassMap : ClassMap<FoodItem>
    {
        public FoodItemClassMap() 
        {
            Id(food => food.Id);
            HasMany(food => food.Name);
            HasMany(food => food.Description);
            References(food => food.Price);

        }
    }
}
