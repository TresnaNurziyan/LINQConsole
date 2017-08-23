using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Filtering
    {
        // Query syntax examples Filtering
        // Menambahkan where di query linq
        static void Main(string[] args)
        {
            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var emailPro = context.Person
            //        .Where(order => order.EmailPromotion == 2)
            //        .Select(s => new { s.BusinessEntityID, s.FirstName, s.LastName });

            //    foreach (var emailProm in emailPro)
            //    {
            //        Console.WriteLine("Bussiness ID: {0} Name: {1}, {2}",
            //            emailProm.BusinessEntityID,
            //            emailProm.FirstName,
            //            emailProm.LastName);
            //    }
            //    Console.ReadKey();
            //}

            //int orderQtyMin = 2;
            //int orderQtyMax = 6;
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = entities.WorkOrder
            //        .Where(order => order.OrderQty > orderQtyMin && order.OrderQty < orderQtyMax)
            //        .Select(s => new { s.WorkOrderID, s.OrderQty });

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Order ID: {0} Order quantity: {1}",
            //            order.WorkOrderID, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}

            //String color = "Silver";
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = entities.Product
            //        .Where(products => products.Color == color)
            //        .Select(p => new { p.Name, p.ProductNumber, p.ListPrice });

            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Name : {0}", product.Name);
            //        Console.WriteLine("Product Number : {0}", product.ProductNumber);
            //        Console.WriteLine("List Price : {0}", product.ListPrice);
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}
            
            // with date
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<SalesOrderHeader> query = entities.SalesOrderHeader
            //        .Where(order => order.OrderDate >= new DateTime(2003, 12, 1)).Take(10);

            //    Console.WriteLine("Orders that were made after December 1, 2003:");
            //    foreach (SalesOrderHeader order in query)
            //    {
            //        Console.WriteLine("Order ID {0} Order date: {1:d}",
            //            order.SalesOrderID, order.OrderDate);

            //        foreach(SalesOrderDetail orderDetail in order.SalesOrderDetail)
            //        {
            //            Console.WriteLine("  Product ID : {0} Unit Price {1}",
            //                orderDetail.ProductID, orderDetail.UnitPrice);
            //        }
            //    }
            //    Console.ReadKey();
            //}

            // Where....Contains 1
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    int?[] productModelIds = { 19, 26, 118, };
            //    var products = entities.Product
            //        .Where(p => productModelIds.Contains(p.ProductModelID));

            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("{0}: {1}", product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            // where....Contains 2
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var products = entities.Product.
                    Where(p => (new int?[] { 19, 26, 18 }).Contains(p.ProductModelID) ||
                    (new string[] { "L", "XL" }).Contains(p.Size));

                foreach (var product in products)
                {
                    Console.WriteLine("{0}: {1}, {2}", product.ProductID,
                                                       product.ProductModelID,
                                                       product.Size);
                }
                Console.ReadKey();
            }
        }
    }
}
