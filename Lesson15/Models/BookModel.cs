using Lesson14.Data.Models;

namespace Lesson14.Models;

public class BookModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Book;
}
