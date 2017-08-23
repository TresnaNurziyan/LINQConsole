using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Grouping
    {
        static void Main(string[] args)
        {
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = entities.Address
            //        .GroupBy(address => address.PostalCode);

            //    foreach (IGrouping<string, Address> addressGroup in query)
            //    {
            //        Console.WriteLine("Postal Code: {0}", addressGroup.Key);
            //        foreach (Address address in addressGroup)
            //        {
            //            Console.WriteLine("\t" + address.AddressLine1 +
            //                address.AddressLine2);
            //        }
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = entities.Person
            //        .GroupBy(p => p.LastName.Substring(0, 1))
            //        .OrderBy(p => p.Key);

            //    foreach (IGrouping<string, Person> group in query)
            //    {
            //        Console.WriteLine("Last names that start with the letter '{0}':",
            //            group.Key);
            //        foreach (Person person in group)
            //        {
            //            Console.WriteLine(person.LastName);
            //        }
            //    }
            //    Console.ReadKey();
            //}

            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var query = entities.SalesOrderHeader
                    .GroupBy(order => order.CustomerID);

                foreach (IGrouping<int, SalesOrderHeader> group in query)
                {
                    Console.WriteLine("Customer ID: {0}", group.Key);
                    Console.WriteLine("Order Count: {0}", group.Count());

                    foreach (SalesOrderHeader sale in group)
                    {
                        Console.WriteLine("     Sale ID: {0}", sale.SalesOrderID);
                    }
                    Console.Write("");
                }
                Console.ReadKey();
            }
        }
    }
}
