using System;

namespace Builder;

public class ComposedInvoiceBuilder
{

    private AddressBuilder _billinAddress;
    private AddressBuilder _shippingAddress;
    private OrderBuilder _order;


    public ComposedInvoiceBuilder SetBillingAddress(AddressBuilder billingddress)
    {
        _billinAddress=billingddress;

        return this;
    }
    public ComposedInvoiceBuilder SetShippingAddress(AddressBuilder shippingaddress)
    {
       
        _shippingAddress=shippingaddress;
        return this;
    }
    
    public ComposedInvoiceBuilder SetOrder(OrderBuilder order)
    {
        _order=order;
        return this;
    }


    public Invoice Build()
    {
        return new Invoice
        {
            InvoiceId=_order.InvoiceId,
            CustomerName = _order.CustomerName,
            CustomerEmail = _order.CustomerEmail,
           
            BillingStreet = _billinAddress.Street,
            BillingCity = _billinAddress.City,
           
            BillingCountry = _billinAddress.Country,

            ShippingStreet = _shippingAddress.Street,
            ShippingCity = _shippingAddress.City,
          
            ShippingCountry = _shippingAddress.Country,

            OrderDate = _order.OrderDate,
            PaymentMethod = _order.PaymentMethod,
            Currency = _order.Currency,

            SubTotal = _order.SubTotal,
            TotalAmount=_order.TotalAmount
            
        };
    }
    
}
