using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Partitioning2
    {
        static void Main(string[] args)
        {
            // SKIP
            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var addresses = context.Address;
            //    var orders = context.SalesOrderHeader;

            //    //LINQ to Entities only supports Skip on ordered collections.
            //    var query = (from address in addresses
            //                 from order in orders
            //                 where address.AddressID == order.Address.AddressID && address.City == "Seattle"
            //                 orderby order.SalesOrderID
            //                 select new
            //                 {
            //                     City = address.City,
            //                     OrderID = order.SalesOrderID,
            //                     OrderDate = order.OrderDate
            //                 }).Skip(2);

            //    Console.WriteLine("All but first 2 orders in Seattle:");
            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("City: {0} Order ID: {1} Total Due: {2:d}",
            //            order.City, order.OrderID, order.OrderDate);
            //    }
            //    Console.ReadKey();
            //}

            // TAKE
            String city = "Seattle";
            using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            {
                var addresses = context.Address;
                var orders = context.SalesOrderHeader;

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
                    Console.WriteLine("City: {0} Order ID: {1} Total Due: {2:d}",
                        order.City, order.OrderID, order.OrderDate);
                }
                Console.ReadKey();
            }
        }
    }
}
