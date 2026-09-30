using System;
using System.Runtime.InteropServices;

namespace oop_refactoring;

public class Customer
{

    public int CustomerId { get;  }
    public string CustomerName { get; }
    public string CustomerEmail { get; }
    public string CustomerCity { get; }
    public bool IsVip { get; }

        public Customer(int customerId, string customerName, string customerEmail, string customerCity, bool isVip)
    {
        CustomerId = customerId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerCity = customerCity;
        IsVip=isVip;
    }




  public void PrintInfo()
{
    Console.WriteLine($"Customer ID    : {CustomerId}");
    Console.WriteLine($"Name           : {CustomerName}");
    Console.WriteLine($"Email          : {CustomerEmail}");
    Console.WriteLine($"City           : {CustomerCity}");
    Console.WriteLine($"VIP            : {(IsVip ? "Yes" : "No")}");
}



    
}
