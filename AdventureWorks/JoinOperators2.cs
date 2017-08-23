using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class JoinOperators2
    {
        static void Main(string[] args)
        {
            // GROUPJOIN
            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var orders = context.SalesOrderHeader;
            //    var details = context.SalesOrderDetail;

            //    var query = (from order in orders
            //                join detail in details
            //                on order.SalesOrderID
            //                equals detail.SalesOrderID into orderGroup
            //                select new
            //                {
            //                    CustomerID = order.SalesOrderID,
            //                    OrderCount = orderGroup.Count()
            //                }).Take(20);

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("CustomerID: {0}  Orders Count: {1}",
            //            order.CustomerID, order.OrderCount);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var customers = context.Customer;
            //    var orders = context.SalesOrderHeader;

            //    var query = (from customer in customers
            //                join order in orders
            //                on customer.CustomerID
            //                equals order.Customer.CustomerID into customerGroup
            //                select new
            //                {
            //                    CustomerID = customer.CustomerID,
            //                    OrderCount = customerGroup.Count(),
            //                    Orders = customerGroup
            //                }).Take(20);

            //    foreach (var group in query)
            //    {
            //        Console.WriteLine("ContactID: {0}", group.CustomerID);
            //        Console.WriteLine("Order count: {0}", group.OrderCount);
            //        foreach (var orderInfo in group.Orders)
            //        {
            //            Console.WriteLine("   Sale ID: {0}", orderInfo.SalesOrderID);
            //        }
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var customers = context.Customer;
            //    var orders = context.SalesOrderHeader;

            //    var query = (from customer in customers
            //                join order in orders
            //                on customer.CustomerID
            //                equals order.Customer.CustomerID into customerGroup
            //                select new
            //                {
            //                    ContactID = customer.CustomerID,
            //                    OrderCount = customerGroup.Count(),
            //                    Orders = customerGroup
            //                }).Take(20);

            //    foreach (var group in query)
            //    {
            //        Console.WriteLine("ContactID: {0}", group.ContactID);
            //        Console.WriteLine("Order count: {0}", group.OrderCount);
            //        foreach (var orderInfo in group.Orders)
            //        {
            //            Console.WriteLine("   Sale ID: {0}", orderInfo.SalesOrderID);
            //        }
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            {
                var orders = context.SalesOrderHeader;
                var details = context.SalesOrderDetail;

                var query = (from order in orders
                            join detail in details
                            on order.SalesOrderID equals detail.SalesOrderID
                            where order.OnlineOrderFlag == true
                            && order.OrderDate.Month == 8
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                SalesOrderDetailID = detail.SalesOrderDetailID,
                                OrderDate = order.OrderDate,
                                ProductID = detail.ProductID
                            }).Take(20);

                foreach (var order in query)
                {
                    Console.WriteLine("{0}\t{1}\t{2:d}\t{3}",
                        order.SalesOrderID,
                        order.SalesOrderDetailID,
                        order.OrderDate,
                        order.ProductID);
                }
                Console.ReadKey();
            }
        }
    }
}
