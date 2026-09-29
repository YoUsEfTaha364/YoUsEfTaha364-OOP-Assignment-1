namespace Builder;

public class InvoiceBuilder
{
    // Mandatory properties
    public int InvoiceId { get; }
    public string CustomerName { get; }
    public string CustomerEmail { get; }

    public string BillingStreet { get; }
    public string BillingCity { get; }
    public string BillingCountry { get; }

    public string ShippingStreet { get; }
    public string ShippingCity { get; }
    public string ShippingCountry { get; }

    public DateTime OrderDate { get; }
    public string PaymentMethod { get; }
    public string Currency { get; }

    public decimal SubTotal { get; }
    public decimal TotalAmount { get; }

    // Optional properties
    public string CustomerPhone { get; private set; } 

    public string BillingState { get; private set; } 
    public string BillingZipCode { get; private set; } 

    public string ShippingState { get; private set; } 
    public string ShippingZipCode { get; private set; } 

    public decimal DiscountAmount { get; private set; }
    public decimal TaxAmount { get; private set; }


    public InvoiceBuilder(
        int invoiceId,
        string customerName,
        string customerEmail,
        string billingStreet,
        string billingCity,
        string billingCountry,
        string shippingStreet,
        string shippingCity,
        string shippingCountry,
        DateTime orderDate,
        string paymentMethod,
        string currency,
        decimal subTotal,decimal totalAmount)
    {
        InvoiceId = invoiceId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;

        BillingStreet = billingStreet;
        BillingCity = billingCity;
        BillingCountry = billingCountry;

        ShippingStreet = shippingStreet;
        ShippingCity = shippingCity;
        ShippingCountry = shippingCountry;

        OrderDate = orderDate;
        PaymentMethod = paymentMethod;
        Currency = currency;

        SubTotal = subTotal;
        TotalAmount=totalAmount;
    }


    public InvoiceBuilder SetCustomerPhone(string phone)
    {
        CustomerPhone = phone;
        return this;
    }

    public InvoiceBuilder SetBillingState(string state)
    {
        BillingState = state;
        return this;
    }

    public InvoiceBuilder SetBillingZipCode(string zipCode)
    {
        BillingZipCode = zipCode;
        return this;
    }

    public InvoiceBuilder SetShippingState(string state)
    {
        ShippingState = state;
        return this;
    }

    public InvoiceBuilder SetShippingZipCode(string zipCode)
    {
        ShippingZipCode = zipCode;
        return this;
    }

    public InvoiceBuilder SetDiscountAmount(decimal amount)
    {
        DiscountAmount = amount;
        return this;
    }

    public InvoiceBuilder SetTaxAmount(decimal amount)
    {
        TaxAmount = amount;
        return this;
    }


    public Invoice Build()
    {
        return new Invoice
        {
            InvoiceId = this.InvoiceId,

            CustomerName = this.CustomerName,
            CustomerEmail = this.CustomerEmail,
           
            BillingStreet = this.BillingStreet,
            BillingCity = this.BillingCity,
           
            BillingCountry = this.BillingCountry,

            ShippingStreet = this.ShippingStreet,
            ShippingCity = this.ShippingCity,
          
            ShippingCountry = this.ShippingCountry,

            OrderDate = this.OrderDate,
            PaymentMethod = this.PaymentMethod,
            Currency = this.Currency,

            SubTotal = this.SubTotal,
            TotalAmount=this.TotalAmount
            

        };
    }
}