using EFCoreIntro.Data;
using EFCoreIntro.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

using (var bookContext = new BookContext())
{
    var bookToChange = bookContext.Products.FirstOrDefault(book => book.Price > 10);
    if (bookToChange is not null)
    {
        bookToChange.Price = bookToChange.Price * 0.9m;
        bookContext.SaveChanges();
        Console.WriteLine("Changed the book's '{0}' price to '{1}'.", bookToChange.Name, bookToChange.Price);
    }
}

// Example code 1:
// Add 2 products to Products table
static void AddProducts()
{
    using (var bookContext = new BookContext())
    {
        // null-forgiving operator applie so that the compiler shuts the fuck up
        // at runtime it has no effect at all
        bookContext.SaveChangesFailed += LogError!;
        var products = new List<Product>
    {
        new Product()
        {
            Name = "Dale Carnegie: How to win friends, and influence people.",
            Price = 10.50m
        },
        new Product()
        {
            Name = "Dale Carnegie: How to stop worrying, and start living.",
            Price = 9.95m
        }
    };

        bookContext.Products.AddRange(products);
        bookContext.SaveChanges();

        LogAddedProducts(products);
    }
}

static void LogError(object _, SaveChangesFailedEventArgs eventArgs)
{
    if (eventArgs != null)
    {
        Console.WriteLine("An error occured during saving:\n{0}", eventArgs.Exception.Message);
    }
}

static void LogAddedProducts(IEnumerable<Product> products)
{
    // if no product is added, then we do nothing
    if (!products.Any())
    {
        return;
    }

    Console.WriteLine("The following products have been added to the database:");
    Console.WriteLine("ID\t\tName\t\tPrice");

    foreach (var product in products)
    {
        Console.WriteLine("{0}\t\t{1}\t\t{2}", product.Id, product.Name, product.Price);
    }
}

// Example code 2:
// 
