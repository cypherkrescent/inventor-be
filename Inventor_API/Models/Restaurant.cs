using System.Xml.Linq;

namespace Inventor_API.Models
{
    public class Restaurant : BaseClass
    {
        public Restaurant ()
        {

        }

        public Restaurant (string name)
        {
            Name = name;
        }

        public virtual string? Name { get; set; }

        public IList<FoodItem> FoodItems { get; set; }
    }
}
