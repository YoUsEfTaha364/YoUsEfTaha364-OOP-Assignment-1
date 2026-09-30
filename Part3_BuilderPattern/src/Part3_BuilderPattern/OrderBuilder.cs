using System;

namespace Builder;

public class OrderBuilder
{
 
    // mandatory
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public DateTime OrderDate { get; set; }
    public string PaymentMethod { get; set; }
    public string Currency { get; set; }

    public decimal SubTotal { get; set; }
    public decimal TotalAmount { get; set; }

    //optional

    public string CustomerPhone { get; private set; }
    public decimal DiscountAmount { get; private set; }
    public decimal TaxAmount { get; private set; }


       public OrderBuilder(int invoiceId, string customerName, string customerEmail, DateTime orderDate, string paymentMethod, string currency, decimal subTotal, decimal totalAmount)
    {
        InvoiceId = invoiceId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        OrderDate = orderDate;
        PaymentMethod = paymentMethod;
        Currency = currency;
        SubTotal = subTotal;
        TotalAmount = totalAmount;
    }

    public OrderBuilder SetCustomerPhone(string phone)
    {
        CustomerPhone=phone;
        return this;
    }
    public OrderBuilder SetDiscountAmount(decimal discountamount)
    {
        DiscountAmount=discountamount;
        return this;
    }
    public OrderBuilder SetTaxAmount(decimal taxamount)
    {
        TaxAmount=taxamount;
        return this;
    }


    



}
