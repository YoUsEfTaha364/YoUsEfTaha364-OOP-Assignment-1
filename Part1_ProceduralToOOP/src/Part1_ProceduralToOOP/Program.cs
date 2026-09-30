using System;
using System.Diagnostics.Metrics;
using oop_refactoring;

var OrderSystem = new OrderSystem();

AddCustomers();
AddProducts();

while(true){

Console.WriteLine();
Console.WriteLine("---------- MENU ----------");
Console.WriteLine("1) Print customers");
Console.WriteLine("2) Print products");
Console.WriteLine("3) Print all orders");
Console.WriteLine("4) Print one order by id");
Console.WriteLine("5) Create order");
Console.WriteLine("6) Add line to order");
Console.WriteLine("7) Mark order paid");
Console.WriteLine("8) Show paid sales total");
Console.WriteLine("0) Exit");
Console.Write("Choice: ");

int choice=GetEnteredInteger();

switch (choice)
{
    case 1:
        OrderSystem.PrintCustomers();
        break;

    case 2:
        OrderSystem.PrintProducts();
        break;

    case 3:

        OrderSystem.PrintOrders();
        break;

    case 4:

    Console.Write("Enter orderId:");

    var id=GetEnteredInteger();

    OrderSystem.PrintOrderById(id);

    break;

    case 5:
    Console.Write("Enter order id:");
    int oid=GetEnteredInteger();
    Console.Write("Enter customer id:");
    int cid=GetEnteredInteger();
    Console.Write("Date (YYYY-MM-DD): ");
    string? str=Console.ReadLine();
    var date= DateTime.ParseExact(str!,"yyyy-MM-dd",null);
    OrderSystem.CreateOrder(oid,date,cid);


    break;

    case 6:

    Console.Write("Enter order id:");
    int orderid=GetEnteredInteger();
    Console.Write("Enter product id:");
    int productid=GetEnteredInteger();
    Console.Write("Enter quantity:");
    int quantity=GetEnteredInteger();

    OrderSystem.AddLineItem(orderid,productid,quantity);


    break;

    case 7:
    
    Console.Write("Enter order id:");

    int getorderid=GetEnteredInteger();

   var order= OrderSystem.GetOrder(getorderid);

   order.IsPaid=true;

    break;

    case 8:
    OrderSystem.PrintTotalPaidOnlyOrders();
    break;


   default:
   Console.WriteLine("un know choice");
   break;




}

if(choice==0)
break;

}




static int GetEnteredInteger()
{
    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        return choice;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }

    return -1;


}


 void AddCustomers()
{
    
var customer1 = new Customer(
    1,
    "Ahmed Hassan",
    "ahmed@gmail.com",
    "Cairo",
    false
);

var customer2 = new Customer(
    2,
    "Omar Ali",
    "omar@gmail.com",
    "Giza",
    true
);

var customer3 = new Customer(
    3,
    "Youssef Mohamed",
    "youssef@gmail.com",
    "Zagazig",
    false
);

var customer4 = new Customer(
    4,
    "Mahmoud Samir",
    "mahmoud@gmail.com",
    "Alexandria",
    false
);

var customer5 = new Customer(
    5,
    "Mostafa Ahmed",
    "mostafa@gmail.com",
    "Mansoura",
    true
);

var customer6 = new Customer(
    6,
    "Karim Adel",
    "karim@gmail.com",
    "Tanta",
    false
);

OrderSystem.AddCustomer(customer1);
OrderSystem.AddCustomer(customer2);
OrderSystem.AddCustomer(customer3);
OrderSystem.AddCustomer(customer4);
OrderSystem.AddCustomer(customer5);
OrderSystem.AddCustomer(customer6);
    
}



void AddProducts()
{
    var product1 = new Product(
   1,
   "Laptop",
   35000m,
   10
);

var product2 = new Product(
    2,
    "Mechanical Keyboard",
    2500m,
    25
);

var product3 = new Product(
    3,
    "Wireless Mouse",
    1200m,
    40
);

var product4 = new Product(
    4,
    "27-inch Monitor",
    8500m,
    15
);

var product5 = new Product(
    5,
    "USB-C Hub",
    1800m,
    30
);

var product6 = new Product(
    6,
    "Headphones",
    3200m,
    20
);


OrderSystem.AddProduct(product1);
OrderSystem.AddProduct(product2);
OrderSystem.AddProduct(product3);
OrderSystem.AddProduct(product4);
OrderSystem.AddProduct(product5);
OrderSystem.AddProduct(product6);
}


