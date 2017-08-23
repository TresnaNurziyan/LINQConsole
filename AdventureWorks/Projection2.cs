using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Projection2
    {
        static void Main(string[] args)
        {
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Product> productsQuery = from product in entities.Product
            //                                        select product;

            //    Console.WriteLine("Product Names:");
            //    foreach (var prod in productsQuery)
            //    {
            //        Console.WriteLine(prod.Name);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<string> productNames = from p in entities.Product
            //                                      select p.Name;

            //    Console.WriteLine("Product Names:");
            //    foreach (String productName in productNames)
            //    {
            //        Console.WriteLine(productName);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = from product in entities.Product
            //                select new
            //                {
            //                    ProductId = product.ProductID,
            //                    ProductName = product.Name
            //                };

            //    Console.WriteLine("Product Info:");
            //    foreach (var productInfo in query)
            //    {
            //        Console.WriteLine("Product Id: {0} Product name: {1} ",
            //            productInfo.ProductId, productInfo.ProductName);
            //    }
            //    Console.ReadKey();
            //}

            // From … From … (SelectMany)
            // decimal totalDue = 500.00M;
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var customers = entities.Customer;
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from customer in customers
            //                from order in orders
            //                where customer.CustomerID == order.Customer.CustomerID && order.TotalDue < totalDue
            //                select new
            //                {
            //                    CustomerID = customer.CustomerID,
            //                    LastName = customer.Person.LastName,
            //                    FirstName = customer.Person.FirstName,
            //                    OrderID = order.SalesOrderID,
            //                    Total = order.TotalDue
            //                }).Take(10);

            //    foreach (var smallOrder in query)
            //    {
            //        Console.WriteLine("Customer ID: {0} Name: {1}, {2} Order ID: {3} Total Due: ${4} ",
            //            smallOrder.CustomerID, smallOrder.LastName, smallOrder.FirstName,
            //            smallOrder.OrderID, smallOrder.Total);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var customers = entities.Customer;
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from customer in customers
            //                 from order in orders
            //                 where customer.CustomerID == order.Customer.CustomerID && order.OrderDate >= new DateTime(2002, 10, 1)
            //                 select new
            //                 {
            //                     CustomerID = customer.CustomerID,
            //                     LastName = customer.Person.LastName,
            //                     FirstName = customer.Person.FirstName,
            //                     OrderID = order.SalesOrderID,
            //                     OrderDate = order.OrderDate
            //                 }).Take(10);

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Customer ID: {0} Name: {1}, {2} Order ID: {3} Order Date: {4:d}",
            //            order.CustomerID, order.LastName, order.FirstName,
            //            order.OrderID, order.OrderDate);
            //    }
            //    Console.ReadKey();
            //}

            decimal totalDue = 10000.0M;
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var customers = entities.Customer;
                var orders = entities.SalesOrderHeader;

                var query = (from customer in customers
                             from order in orders
                             let total = order.TotalDue
                             where customer.CustomerID == order.Customer.CustomerID && total >= totalDue
                             select new
                             {
                                 CustomerID = customer.CustomerID,
                                 LastName = customer.Person.LastName,
                                 OrderID = order.SalesOrderID,
                                 total
                             }).Take(20);

                foreach (var order in query)
                {
                    Console.WriteLine("Customer ID: {0} Last name: {1} Order ID: {2} Total: {3}",
                        order.CustomerID, order.LastName, order.OrderID, order.total);
                }
                Console.ReadKey();
            }
        }
    }
}
