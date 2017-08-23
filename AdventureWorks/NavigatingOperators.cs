using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class NavigatingOperators
    {
        static void Main(string[] args)
        {
            string lastName = "Zhou";
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<SalesOrderHeader> ordersQuery = entities.Customer
            //        .Where(c => c.Person.LastName == lastName)
            //        .SelectMany(c => c.SalesOrderHeader);

            //    foreach (var order in ordersQuery)
            //    {
            //        Console.WriteLine("Order ID: {0}, Order Date: {1}, Total Due: {2}",
            //            order.SalesOrderID, order.OrderDate, order.TotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var ordersQuery = entities.Customer
            //        .Where(c => c.Person.LastName == lastName)
            //        .Select(c => new
            //        {
            //            CustomerID = c.CustomerID,
            //            Total = c.SalesOrderHeader.Sum(o => o.TotalDue)
            //        });

            //    foreach (var customer in ordersQuery)
            //    {
            //        Console.WriteLine("Customer ID: {0} Orders total: {1}", customer.CustomerID, customer.Total);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var ordersQuery = entities.Customer
            //        .Where(c => c.Person.LastName == lastName)
            //        .Select(c => new
            //        {
            //            LastName = c.Person.LastName,
            //            Orders = c.SalesOrderHeader
            //        });

            //    foreach (var order in ordersQuery)
            //    {
            //        Console.WriteLine("Name: {0}", order.LastName);
            //        foreach (SalesOrderHeader orderInfo in order.Orders)
            //        {
            //            Console.WriteLine("Order ID: {0}, Order date: {1}, Total Due: {2}",
            //                orderInfo.SalesOrderID, orderInfo.OrderDate, orderInfo.TotalDue);
            //        }
            //        Console.Write("");
            //    }
            //    Console.ReadKey();
            //}

            string city = "Seattle";
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var ordersQuery = entities.SalesOrderHeader
            //        .Where(o => o.Address.City == city)
            //        .Select(o => new
            //        {
            //            CustomerLastName = o.Customer.Person.LastName,
            //            CustomerFirstName = o.Customer.Person.FirstName,
            //            StreetAddress = o.Address.AddressLine1,
            //            OrderNumber = o.SalesOrderNumber,
            //            TotalDue = o.TotalDue
            //        });

            //    foreach (var orderInfo in ordersQuery)
            //    {
            //        Console.WriteLine("Name: {0}, {1}", orderInfo.CustomerLastName, orderInfo.CustomerFirstName);
            //        Console.WriteLine("Street address: {0}", orderInfo.StreetAddress);
            //        Console.WriteLine("Order number: {0}", orderInfo.OrderNumber);
            //        Console.WriteLine("Total Due: {0}", orderInfo.TotalDue);
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            {
                IQueryable<SalesOrderHeader> query =
                    (from order in context.SalesOrderHeader
                    where order.OrderDate >= new DateTime(2003, 12, 1)
                    select order).Take(20);


                Console.WriteLine("Orders that were made after December 1, 2003:");
                foreach (SalesOrderHeader order in query)
                {
                    Console.WriteLine("OrderID {0} Order date: {1:d} ",
                        order.SalesOrderID, order.OrderDate);
                    foreach (SalesOrderDetail orderDetail in order.SalesOrderDetail)
                    {
                        Console.WriteLine("  Product ID: {0} Unit Price {1}",
                            orderDetail.ProductID, orderDetail.UnitPrice);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
