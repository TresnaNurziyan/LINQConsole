using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class AggregateOperatros
    {
        static void Main(string[] args)
        {
            // AVERAGE
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var products = entities.Product;

            //    Decimal averageListPrice = products.Average(product => product.ListPrice);

            //    Console.WriteLine("The average list price of all the products is ${0}",
            //        averageListPrice);

            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var products = entities.Product;

            //    var query = from product in products
            //                group product by product.Style into g
            //                select new
            //                {
            //                    Style = g.Key,
            //                    AverageListPrice = g.Average(product => product.ListPrice)
            //                };

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

            //    Decimal averageTotalDue = orders.Average(order => order.TotalDue);
            //    Console.WriteLine("The average TotalDue is {0}.", averageTotalDue);

            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = from order in orders
            //                group order by order.AccountNumber into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    averageTotalDue = g.Average(order => order.TotalDue)
            //                };

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("AccountNumber = {0} \t Average TotalDue = {1}",
            //            order.Category, order.averageTotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = from order in orders
            //                group order by order.Customer.PersonID into g
            //                let averageTotalDue = g.Average(order => order.TotalDue)
            //                select new
            //                {
            //                    Category = g.Key,
            //                    CheapestProducts = 
            //                            g.Where(order => order.TotalDue == averageTotalDue)
            //                };

            //    foreach (var orderGroup in query)
            //    {
            //        Console.WriteLine("PersonID: {0}", orderGroup.Category);
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
            //    var products = entities.Product;

            //    int numProducts = products.Count();

            //    Console.WriteLine("There are {0} products.", numProducts);

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
            //            product.Color,
            //            product.ProductCount);
            //    }
            //    Console.ReadKey();
            //}

            // LONG COUNT
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var persons = entities.Person;

            //    long numberOfPerson = persons.LongCount();
            //    Console.WriteLine("There are {0} Persons", numberOfPerson);

            //    Console.ReadKey();
            //}

            // MAX
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    Decimal maxTotalDue = orders.Max(w => w.TotalDue);
            //    Console.WriteLine("The maximum TotalDue is {0}.", maxTotalDue);

            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = from order in orders
            //                group order by order.Customer.PersonID into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    maxTotalDue = g.Max(order => order.TotalDue)
            //                };

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("PersonID = {0} \t Maximum TotalDue = {1}",
            //            order.Category, order.maxTotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = from order in orders
            //                group order by order.Customer.PersonID into g
            //                let maxTotalDue = g.Max(order => order.TotalDue)
            //                select new
            //                {
            //                    Category = g.Key,
            //                    CheapestProducts = g.Where(order => order.TotalDue == maxTotalDue)
            //                };

            //    foreach (var orderGroup in query)
            //    {
            //        Console.WriteLine("PersonID: {0}", orderGroup.Category);
            //        foreach (var order in orderGroup.CheapestProducts)
            //        {
            //            Console.WriteLine("MaxTotalDue {0} for SalesOrderID {1}: ",
            //                order.TotalDue,
            //                order.SalesOrderID);
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.ReadKey();
            //}

            // MIN
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    Decimal smallestTotalDue = orders.Min(totalDue => totalDue.TotalDue);
            //    Console.WriteLine("The smallest TotalDue is {0}.",
            //        smallestTotalDue);

            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = from order in orders
            //                group order by order.Customer.PersonID into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    smallestTotalDue = g.Min(order => order.TotalDue)
            //                };

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("PersonID = {0} \t Minimum TotalDue = {1}",
            //            order.Category, order.smallestTotalDue);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;

            //    var query = from order in orders
            //                group order by order.Customer.PersonID into g
            //                let minTotalDue = g.Min(order => order.TotalDue)
            //                select new
            //                {
            //                    Category = g.Key,
            //                    smallestTotalDue = g.Where(order => order.TotalDue == minTotalDue)
            //                };

            //    foreach (var orderGroup in query)
            //    {
            //        Console.WriteLine("PersonID: {0}", orderGroup.Category);
            //        foreach (var order in orderGroup.smallestTotalDue)
            //        {
            //            Console.WriteLine("Minimum TotalDue {0} for SalesOrderID {1}: ",
            //                order.TotalDue,
            //                order.SalesOrderID);
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.ReadKey();
            //}

            // SUM
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderDetail;

            //    double totalOrderQty = orders.Sum(o => o.OrderQty);
            //    Console.WriteLine("There are a total of {0} OrderQty.",
            //        totalOrderQty);
            //    Console.ReadKey();
            //}

            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var orders = entities.SalesOrderHeader;

                var query = from order in orders
                            group order by order.Customer.PersonID into g
                            select new
                            {
                                Category = g.Key,
                                TotalDue = g.Sum(order => order.TotalDue)
                            };

                foreach (var order in query)
                {
                    Console.WriteLine("PersonID = {0} \t TotalDue sum = {1}",
                        order.Category, order.TotalDue);
                }
                Console.ReadKey();
            }
        }
    }
}
