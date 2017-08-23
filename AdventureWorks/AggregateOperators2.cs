using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class AggregateOperators2
    {
        static void Main(string[] args)
        {
            // USING AVERAGE
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var products = entities.Product;

            //    var query = (from product in products
            //                 group product by product.Style into g
            //                 select new
            //                 {
            //                     Style = g.Key,
            //                     AverageListPrice = g.Average(product => product.ListPrice)
            //                 });

            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Product style: {0} Average list price: {1}",
            //            product.Style, product.AverageListPrice);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from order in orders
            //                group order by order.Customer.CustomerID into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    averageTotalDue = g.Average(order => order.TotalDue)
            //                }).Take(20);

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("ContactID = {0} \t Average TotalDue = {1}",
            //            order.Category, order.averageTotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from order in orders
            //                group order by order.Customer.CustomerID into g
            //                let averageTotalDue = g.Average(order => order.TotalDue)
            //                select new
            //                {
            //                    Category = g.Key,
            //                    CheapestProducts = g.Where(order => order.TotalDue == averageTotalDue)
            //                }).Take(20);

            //    foreach (var orderGroup in query)
            //    {
            //        Console.WriteLine("ContactID: {0}", orderGroup.Category);
            //        foreach (var order in orderGroup.CheapestProducts)
            //        {
            //            Console.WriteLine("Average total due for SalesOrderID {1} is: {0}",
            //                order.TotalDue, order.SalesOrderID);
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.ReadKey();
            //}

            // COUNT
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var customers = entities.Customer;

            //    var query = (from customer in customers
            //                select new
            //                {
            //                    CustomerID = customer.CustomerID,
            //                    OrderCount = customer.SalesOrderHeader.Count()
            //                });

            //    foreach (var customer in query)
            //    {
            //        Console.WriteLine("CustomerID = {0} \t OrderCount = {1}",
            //            customer.CustomerID, customer.OrderCount);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var products = entities.Product;

            //    var query = from product in products
            //                group product by product.Color into g
            //                select new { Color = g.Key, ProductCount = g.Count() };

            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Color = {0} \t ProductCount = {1}",
            //            product.Color, product.ProductCount);
            //    }
            //    Console.ReadKey();
            //}

            // MAX
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from order in orders
            //                group order by order.Customer.CustomerID into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    maxTotalDue = g.Max(order => order.TotalDue)
            //                }).Take(20);

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("CustomerID = {0} \t Maximum TotalDue = {1}",
            //            order.Category, order.maxTotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from order in orders
            //                group order by order.Customer.CustomerID into g
            //                let maxTotalDue = g.Max(order => order.TotalDue)
            //                select new
            //                {
            //                    Category = g.Key,
            //                    CheapestProducts = g.Where(order => order.TotalDue == maxTotalDue)
            //                }).Take(20);

            //    foreach (var orderGroup in query)
            //    {
            //        Console.WriteLine("CustomerID: {0}", orderGroup.Category);
            //        foreach (var order in orderGroup.CheapestProducts)
            //        {
            //            Console.WriteLine("MaxTotalDue {0} for SalesOrderID {1}: ",
            //                order.TotalDue, order.SalesOrderID);
            //        }
            //    }
            //    Console.ReadKey();
            //}

            // MIN
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = (from order in orders
            //                group order by order.Customer.CustomerID into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    smallestTotalDue = g.Min(order => order.TotalDue)
            //                }).Take(20);

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("CustomerID = {0} \t Minimum TotalDue = {1}",
            //            order.Category, order.smallestTotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var orders = context.SalesOrderHeader;

            //    var query = (from order in orders
            //                group order by order.Customer.CustomerID into g
            //                let minTotalDue = g.Min(order => order.TotalDue)
            //                select new
            //                {
            //                    Category = g.Key,
            //                    smallestTotalDue = g.Where(order => order.TotalDue == minTotalDue)
            //                }).Take(20);


            //    foreach (var orderGroup in query)
            //    {
            //        Console.WriteLine("ContactID: {0}", orderGroup.Category);
            //        foreach (var order in orderGroup.smallestTotalDue)
            //        {
            //            Console.WriteLine("Mininum TotalDue {0} for SalesOrderID {1}: ",
            //                order.TotalDue, order.SalesOrderID);
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.ReadKey();
            //}

            // SUM
            using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            {
                var orders = context.SalesOrderHeader;

                var query = (from order in orders
                            group order by order.Customer.CustomerID into g
                            select new
                            {
                                Category = g.Key,
                                TotalDue = g.Sum(order => order.TotalDue)
                            }).Take(20);

                foreach (var order in query)
                {
                    Console.WriteLine("ContactID = {0} \t TotalDue sum = {1}",
                        order.Category, order.TotalDue);
                }
                Console.ReadKey();
            }
        }
    }
}
