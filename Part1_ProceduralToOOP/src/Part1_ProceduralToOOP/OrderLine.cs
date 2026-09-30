using System;

namespace oop_refactoring;

public class OrderLine
{


   static private int _counter=0;
    public int OrderLineId { get; }
    public Product Product {get;}
    public int Quantity {get;}

    public OrderLine( Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;

         _counter++;
        OrderLineId=_counter;
    }


    public decimal SubTotal()
    {
        return Product.ProductPrice * Quantity;
    }

    public void PrintInfo()
{
    Console.WriteLine($"Order Line ID : {OrderLineId}");
    Console.WriteLine($"Product       : {Product.ProductName}");
    Console.WriteLine($"Quantity      : {Quantity}");
    Console.WriteLine($"Unit Price    : {Product.ProductPrice:C}");
    Console.WriteLine($"Line Total    : {SubTotal():C}");
}


}
