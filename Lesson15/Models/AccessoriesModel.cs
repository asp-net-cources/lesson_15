using Lesson14.Data.Models;

namespace Lesson14.Models;

public class AccessoriesModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Accessories;
}
