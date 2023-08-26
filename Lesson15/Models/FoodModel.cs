using Lesson14.Data.Models;

namespace Lesson14.Models;

public class FoodModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Food;
}
