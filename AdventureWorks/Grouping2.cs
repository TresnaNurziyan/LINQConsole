using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Grouping2
    {
        static void Main(string[] args)
        {
            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var query = (from address in context.Address
            //                group address by address.PostalCode into addressGroup
            //                select new
            //                {
            //                    PostalCode = addressGroup.Key,
            //                    AddressLine = addressGroup
            //                }).Take(20);

            //    foreach (var addressGroup in query)
            //    {
            //        Console.WriteLine("Postal Code: {0}", addressGroup.PostalCode);
            //        foreach (var address in addressGroup.AddressLine)
            //        {
            //            Console.WriteLine("\t" + address.AddressLine1 + address.AddressLine2);
            //        }
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var query = (from person in context.Person
            //                 group person by person.LastName.Substring(0, 1) into personGroup
            //                 select new
            //                 {
            //                     FirstLetter = personGroup.Key,
            //                     Names = personGroup
            //                 }).OrderBy(letter => letter.FirstLetter).Take(20);

            //    foreach (var person in query)
            //    {
            //        Console.WriteLine("Last names that start with the letter '{0}':",
            //            person.FirstLetter);
            //        foreach (var name in person.Names)
            //        {
            //            Console.WriteLine(name.LastName);
            //        }
            //    }
            //    Console.ReadKey();

            //}

            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var query = (from order in entities.SalesOrderHeader
                            group order by order.CustomerID into idGroup
                            select new
                            {
                                CustomerID = idGroup.Key,
                                OrderCount = idGroup.Count(),
                                Sales = idGroup
                            }).Take(20);

                foreach (var orderGroup in query)
                {
                    Console.WriteLine("Customer ID: {0}", orderGroup.CustomerID);
                    Console.WriteLine("Order Count: {0}", orderGroup.OrderCount);
                    foreach (SalesOrderHeader sale in orderGroup.Sales)
                    {
                        Console.WriteLine("     Sale ID: {0}", sale.SalesOrderID);
                    }
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }
        }
    }
}
