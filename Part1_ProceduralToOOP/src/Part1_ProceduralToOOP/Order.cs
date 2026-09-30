using System;

namespace oop_refactoring;

public class Order
{

    public int OrderId { get; }
    public DateTime Date { get; set; }
    public Customer Customer {get;set;}
    public List<OrderLine> OrderItems { get; } =new List<OrderLine>();


        public Order(int orderId, DateTime date, Customer customer)
    {
        OrderId = orderId;
        Date = date;
        Customer = customer;
    }



   public bool IsPaid { get; set; }

   public void AddOrderLine(OrderLine order_line)
    {
        OrderItems.Add(order_line);
    }

    public decimal GetTotalPrice()
    {
        decimal sum=0;

        foreach(var item in OrderItems)
        {
            sum+=item.SubTotal();
        }
        return sum;

    }
    
    public void PrintInfo()
    {
        Console.WriteLine("========================================");
            Console.WriteLine("               ORDER");
            Console.WriteLine("========================================");

            Console.WriteLine($"Order ID   : {OrderId}");
            Console.WriteLine($"Date       : {Date:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Customer   : {Customer.CustomerName}");
            Console.WriteLine($"IsPaid   : {(IsPaid==true ? "paid" : "notpaid")}");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Order Items");
            Console.WriteLine("----------------------------------------");

            foreach (var item in OrderItems)
            {
                item.PrintInfo();
                 Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Total Price: {GetTotalPrice():C}");
            
            Console.WriteLine("========================================");
    }
}
