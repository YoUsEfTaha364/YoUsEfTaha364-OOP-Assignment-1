using System;
using System.Security.Principal;

namespace oop_refactoring;

public class OrderSystem
{
    private List<Order> _orders = new List<Order>();
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    private int FindCustomerIndexById(int id)
    {
        return _customers.FindIndex(customer => customer.CustomerId == id);
    }
    private int FindProductIndexById(int id)
    {
        return _products.FindIndex(product => product.ProductId == id);
    }
    private int FindOrderIndexById(int id)
    {
        return _orders.FindIndex(order => order.OrderId == id);
    }

    public void PrintTotalPaidOnlyOrders()
    {
        decimal sum=0;

        foreach(var order in _orders)
        {
            if(order.IsPaid==true)
             sum+=order.GetTotalPrice();
        }
      
       Console.WriteLine($"Total paid orders : {sum:c}");

    }


    public Order GetOrder(int id)
    {
        int OrderIndex = FindOrderIndexById(id);

        if (OrderIndex == -1)
        {
            throw new Exception("no order found");
        }

        var order = _orders[OrderIndex];
        return order;
    }

    public void CreateOrder(int order_id, DateTime date, int customer_id)
    {
        int customerIndex = FindCustomerIndexById(customer_id);
        if (customerIndex == -1)
        {
            throw new Exception("customer not found");
        }
        var order = new Order(order_id, date, _customers[customerIndex]);

        _orders.Add(order);
    }

    public void AddLineItem(int order_id, int product_id, int quantity)
    {
        int orderIndex = FindOrderIndexById(order_id);

        if (orderIndex == -1)
        {
            throw new Exception("order not found");
        }

        int productIndex = FindProductIndexById(product_id);

        if (productIndex == -1)
        {
            throw new Exception("product not found");
        }

        var order = _orders[orderIndex];
        var product = _products[productIndex];

        var orderLine = new OrderLine(product, quantity);

        order.AddOrderLine(orderLine);


    }

    public void PrintCustomers()
    {
        if (_customers.Count() == 0)
        {
            Console.WriteLine("no customers yet");

            return;
        }

        Console.WriteLine($"#{_customers.Count()}");
        foreach (var customer in _customers)
        {
            customer.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }

    public void PrintProducts()
    {
        if (_products.Count() == 0)
        {
            Console.WriteLine("no products yet");

            return;
        }

        Console.WriteLine($"#{_products.Count()}");
        foreach (var product in _products)
        {
            product.PrintInfo();

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

    }


    public void PrintOrders()
    {
        if (_orders.Count() == 0)
        {
            Console.WriteLine("no orders yet");
            return;
        }

        foreach (var order in _orders)
        {

            order.PrintInfo();

        }
    }




    public void PrintOrderById(int id)
    {
        int OrderIndex = FindOrderIndexById(id);

        if (OrderIndex == -1)
        {
            Console.WriteLine("no order found");
            return;
        }

        var order = _orders[OrderIndex];

       order.PrintInfo();



    }
}
