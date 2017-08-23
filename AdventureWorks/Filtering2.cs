using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Filtering2
    {
        static void Main(string[] args)
        {
            // WHERE
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var onlineOrders = (from order in entities.SalesOrderHeader
            //                        where order.OnlineOrderFlag == true
            //                        select new
            //                        {
            //                            SalesOrderID = order.SalesOrderID,
            //                            OrderDate = order.OrderDate,
            //                            SalesOrderNumber = order.SalesOrderNumber
            //                        }).Take(20);

            //    foreach (var onlineOrder in onlineOrders)
            //    {
            //        Console.WriteLine("Order ID: {0} Order Date: {1:d} Order Number: {2}",
            //            onlineOrder.SalesOrderID, onlineOrder.OrderDate, onlineOrder.SalesOrderNumber);
            //    }
            //    Console.ReadKey();
            //}

            int orderQtyMin = 2;
            int orderQtyMax = 6;
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = (from order in entities.SalesOrderDetail
            //                 where order.OrderQty > orderQtyMin && order.OrderQty < orderQtyMax
            //                 select new
            //                 {
            //                     SalesOrderID = order.SalesOrderID,
            //                     OrderQty = order.OrderQty
            //                 }).Take(20);

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Order ID: {0} Order Quantity: {1}",
            //            order.SalesOrderID, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}

            String color = "Red";
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = (from product in entities.Product
            //                where product.Color == color
            //                select new
            //                {
            //                    Name = product.Name,
            //                    ProductNumber = product.ProductNumber,
            //                    ListPrice = product.ListPrice
            //                }).Take(10);

            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Name: {0}", product.Name);
            //        Console.WriteLine("Product number: {0}", product.ProductNumber);
            //        Console.WriteLine("List price: ${0}", product.ListPrice);
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            // WHERE...CONTAINS
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<SalesOrderHeader> query = (from order in entities.SalesOrderHeader
            //                                         where order.OrderDate >= new DateTime(2003, 12, 1)
            //                                         select order).Take(10);

            //    Console.WriteLine("Orders that were made after December 1, 2003:");
            //    foreach (SalesOrderHeader order in query)
            //    {
            //        Console.WriteLine("OrderID {0} Order date: {1:d} ",
            //            order.SalesOrderID, order.OrderDate);
            //        foreach (SalesOrderDetail orderDetail in order.SalesOrderDetail)
            //        {
            //            Console.WriteLine("  Product ID: {0} Unit Price {1}",
            //                orderDetail.ProductID, orderDetail.UnitPrice);
            //        }
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    int?[] productModelIds = { 19, 26, 118 };
            //    var products = from p in entities.Product
            //                   where productModelIds.Contains(p.ProductModelID)
            //                   select p;

            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("{0}: {1}", product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var products = from p in entities.Product
                               where (new int?[] { 19, 26, 18 }).Contains(p.ProductModelID) ||
                                     (new string[] { "L", "XL" }).Contains(p.Size)
                               select p;

                foreach (var product in products)
                {
                    Console.WriteLine("{0}: {1}, {2}", product.ProductID, product.ProductModelID, product.Size);
                }
                Console.ReadKey();
            }
        }
    }
}
