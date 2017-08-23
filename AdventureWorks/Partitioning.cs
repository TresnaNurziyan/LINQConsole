using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Partitioning
    {
        static void Main(string[] args)
        {
            // SKIP
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    // LINQ to Entities only support Skip on ordered collections.
            //    IOrderedQueryable<Product> products = entities.Product
            //        .OrderBy(p => p.ListPrice);

            //    IQueryable<Product> allButFirst3Products = products.Skip(3);

            //    Console.WriteLine("All but first 3 products: ");
            //    foreach (Product product in allButFirst3Products)
            //    {
            //        Console.WriteLine("Name: {0} \t ID: {1}", product.Name, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var addresses = entities.Address;
            //    var orders = entities.SalesOrderHeader;

            //    // LINQ to Entities only supports Skip on ordered collections.
            //    var query = (from address in addresses
            //                 from order in orders
            //                 where address.AddressID == order.Address.AddressID && address.City == "Seattle"
            //                 orderby order.SalesOrderID
            //                 select new
            //                 {
            //                     City = address.City,
            //                     OrderID = order.SalesOrderID,
            //                     OrderDate = order.OrderDate
            //                 }).Skip(2).Take(10); // <-- This for limit (.Take(10))

            //    Console.WriteLine("All but first 2 orders in Seattle");
            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("City: {0} Order ID: {1} Total Due: {2:d}",
            //            order.City, order.OrderID, order.OrderDate);
            //    }
            //    Console.ReadKey();
            //}

            // TAKE
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Person> firstPerson = entities.Person.Take(5);

            //    Console.WriteLine("First 5 persons :");
            //    foreach(Person person in firstPerson)
            //    {
            //        Console.WriteLine("Title = {0} \t FirstName = {1} \t LastName = {2}",
            //            person.Title,
            //            person.FirstName,
            //            person.LastName);
            //    }
            //    Console.ReadKey();
            //}

            String city = "Seattle";
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var addresses = entities.Address;
                var orders = entities.SalesOrderHeader;

                var query = (from address in addresses
                             from order in orders
                             where address.AddressID == order.Address.AddressID && address.City == city
                             select new
                             {
                                 City = address.City,
                                 OrderID = order.SalesOrderID,
                                 OrderDate = order.OrderDate
                             }).Take(3);
                Console.WriteLine("First 3 orders in Seattle:");
                foreach (var order in query)
                {
                    Console.WriteLine("City: {0} Order ID: {1} Order Date {2:d}",
                        order.City, order.OrderID, order.OrderDate);
                }
                Console.ReadKey();
            }
        }
    }
}
