using System;

namespace Builder;

public class Invoice
{
    // Mandatory properties
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }

    public string BillingStreet { get; set; }
    public string BillingCity { get; set; }
    public string BillingCountry { get; set;}

    public string ShippingStreet { get; set; }
    public string ShippingCity { get; set; }
    public string ShippingCountry { get; set; }

    public DateTime OrderDate { get; set; }
    public string PaymentMethod { get; set; }
    public string Currency { get; set; }

    public decimal SubTotal { get; set; }
    public decimal TotalAmount { get;set; }

    // Optional properties
    public string CustomerPhone { get; private set; }

    public string BillingState { get; private set; }
    public string BillingZipCode { get; private set; }

    public string ShippingState { get; private set; }
    public string ShippingZipCode { get; private set; }

    public decimal DiscountAmount { get; private set; }
    public decimal TaxAmount { get; private set; }
    public void Print()
    {
        Console.WriteLine($"Invoice ID: {InvoiceId}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Customer Email: {CustomerEmail}");
        Console.WriteLine($"Billing Address: {BillingStreet}, {BillingCity}, {BillingState}, {BillingZipCode}, {BillingCountry}");
        Console.WriteLine($"Shipping Address: {ShippingStreet}, {ShippingCity}, {ShippingState}, {ShippingZipCode}, {ShippingCountry}");
        Console.WriteLine($"Order Date: {OrderDate}");
        Console.WriteLine($"Payment Method: {PaymentMethod}");
        Console.WriteLine($"Currency: {Currency}");
        Console.WriteLine($"SubTotal: {SubTotal:C}");
        Console.WriteLine($"Discount Amount: {DiscountAmount:C}");
        Console.WriteLine($"Tax Amount: {TaxAmount:C}");

    }
}

