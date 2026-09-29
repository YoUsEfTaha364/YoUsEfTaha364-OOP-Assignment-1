using System;

namespace oop_refactoring;

public class Product
{


    public int ProductId { get;  }
    public string ProductName { get; }
    public decimal ProductPrice { get; }
    public int ProductStock { get; }

        public Product(int productId, string productName, decimal productPrice, int productStock)
    {
        ProductId = productId;
        ProductName = productName;
        ProductPrice = productPrice;
        ProductStock = productStock;
    }

   public void PrintInfo()
{
    Console.WriteLine($"Product ID    : {ProductId}");
    Console.WriteLine($"Name          : {ProductName}");
    Console.WriteLine($"Price         : {ProductPrice:C}");
    Console.WriteLine($"Stock         : {ProductStock}");
}
}
