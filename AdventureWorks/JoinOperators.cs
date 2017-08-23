using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class JoinOperators
    {
        static void Main(string[] args)
        {
            // GroupJoin
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var orders = entities.SalesOrderHeader;
            //    var details = entities.SalesOrderDetail;

            //    var query = orders.GroupJoin(details,
            //        order => order.SalesOrderID,
            //        detail => detail.SalesOrderID,
            //        (order, orderGroup) => new
            //        {
            //            CustomerID = order.SalesOrderID,
            //            OrderCount = orderGroup.Count()
            //        });

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("CustomerID: {0}  Orders Count: {1}",
            //            order.CustomerID, order.OrderCount);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var customers = entities.Customer;
            //    var orders = entities.SalesOrderHeader;

            //    var query = customers.GroupJoin(orders,
            //        customer => customer.CustomerID,
            //        order => order.Customer.CustomerID,
            //        (customer, customerGroup) => new
            //        {
            //            CustomerID = customer.CustomerID,
            //            OrderCount = customerGroup.Count(),
            //            Orders = customerGroup
            //        }).Take(30);

            //    foreach (var group in query)
            //    {
            //        Console.WriteLine("CustomerID: {0}", group.CustomerID);
            //        Console.WriteLine("Order Count: {0}", group.OrderCount);
            //        foreach (var orderInfo in group.Orders)
            //        {
            //            Console.WriteLine("     Sale ID: {0}", orderInfo.SalesOrderID);
            //        }
            //        Console.Write("");
            //    }
            //    Console.ReadKey();
            //}

            // JOIN
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var customers = entities.Customer;
            //    var orders = entities.SalesOrderHeader;

            //    var query = customers.Join(orders,
            //        order => order.CustomerID,
            //        customer => customer.Customer.CustomerID,
            //        (customer, order) => new
            //        {
            //            CustomerID = customer.CustomerID,
            //            SalesOrderID = order.SalesOrderID,
            //            FirstName = customer.Person.FirstName,
            //            LastName = customer.Person.LastName,
            //            TotalDue = order.TotalDue
            //        }).Take(20); // <-- Limit the query

            //    foreach (var customer_order in query)
            //    {
            //        Console.WriteLine("CustomerID: {0} "
            //                        + "SalesOrderID: {1} "
            //                        + "FirstName: {2} "
            //                        + "LastName: {3} "
            //                        + "TotalDue: {4}",
            //                customer_order.CustomerID,
            //                customer_order.SalesOrderID,
            //                customer_order.FirstName,
            //                customer_order.LastName,
            //                customer_order.TotalDue);
            //    }
            //    Console.ReadKey();
            //}

            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var customers = entities.Customer;
                var orders = entities.SalesOrderHeader;

                var query = customers.Join(orders,
                    order => order.CustomerID,
                    contact => contact.Customer.CustomerID,
                    (customer, order) => new
                    {
                        CustomerID = customer.CustomerID,
                        SalesOrderID = order.SalesOrderID,
                        FirstName = customer.Person.FirstName,
                        Lastname = customer.Person.LastName,
                        TotalDue = order.TotalDue
                    }).GroupBy(record => record.CustomerID);

                foreach (var group in query)
                {
                    foreach (var customer_order in group)
                    {
                        Console.WriteLine("CustomerID: {0} "
                                        + "SalesOrderID: {1} "
                                        + "FirstName: {2} "
                                        + "LastName: {3} "
                                        + "TotalDue: {4}",
                                customer_order.CustomerID,
                                customer_order.SalesOrderID,
                                customer_order.FirstName,
                                customer_order.Lastname,
                                customer_order.TotalDue);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
