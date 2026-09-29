
using System;
using Builder;
   
        //
  // var invoice = new InvoiceBuilder(1, "John Doe", "john.doe@example.com", "123 Main St", "Anytown", "USA", "456 Oak Ave", "AnotherTown", "USA", DateTime.Now, "Credit Card", "USD", 100.00m,100)
  //               .SetBillingState("CA")
  //               .SetBillingZipCode("12345")
  //               .SetShippingState("NY")
  //               .SetShippingZipCode("67890")
  //               .SetDiscountAmount(10.00m)
  //               .SetTaxAmount(12.00m)
  //               .Build();


  //    invoice.Print();


     var order=new OrderBuilder(1,"yousef","john.doe@example.com",DateTime.Now,"credit card","USA",100,100);

     var shippingAddress=new AddressBuilder("kjdjfdj 123","elsh","egy").SetState("jdh").SetZipCode("1111111111111");
     var billingAddress=new AddressBuilder("123 Main St","elsharqia","Egypt").SetState("jdjdlls").SetZipCode("111124571111111");


  var invoice=new ComposedInvoiceBuilder().SetBillingAddress(billingAddress).SetShippingAddress(shippingAddress).SetOrder(order).Build();

      invoice.Print();
