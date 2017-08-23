using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Ordering2
    {
        static void Main(string[] args)
        {
            // ORDER...BY
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Person> sortedNames = (from n in entities.Person
            //                                     orderby n.LastName
            //                                     select n).Take(20);

            //    Console.WriteLine("The sorted list of last names:");
            //    foreach (Person n in sortedNames)
            //    {
            //        Console.WriteLine(n.LastName);
            //    }
            //    Console.ReadKey();
            //}

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Person> sortedNames = (from n in entities.Person
            //                                     orderby n.LastName.Length // <-- by lenght
            //                                     select n).Take(20);

            //    Console.WriteLine("The sorted list of last names (by lenght):");
            //    foreach (Person n in sortedNames)
            //    {
            //        Console.WriteLine(n.LastName);
            //    }
            //    Console.ReadKey();
            //}

            // ORDERBYDESCENDING
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Decimal> sortedPrices = (from p in entities.Product
            //                                       orderby p.ListPrice descending
            //                                       select p.ListPrice).Take(20);

            //    Console.WriteLine("The list price from highest to lowest:");
            //    foreach (Decimal price in sortedPrices)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    Console.ReadKey();
            //}

            // THENBY
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Person> sortedPersons = (from person in entities.Person
            //                                        orderby person.LastName, person.FirstName
            //                                        select person).Take(20);

            //    Console.WriteLine("The list of contacts sorted by last name then by first name:");
            //    foreach (Person sortedPerson in sortedPersons)
            //    {
            //        Console.WriteLine(sortedPerson.LastName + ", " + sortedPerson.FirstName);
            //    }
            //    Console.ReadKey();
            //}

            // THENBYDESCEDING
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                IQueryable<Product> query = (from product in entities.Product
                                            orderby product.Name, product.ListPrice descending
                                            select product).Take(20);

                foreach (Product product in query)
                {
                    Console.WriteLine("Product ID: {0} Product Name: {1} List Price {2}",
                        product.ProductID, product.Name, product.ListPrice);
                }
                Console.ReadKey();
            }
        }
    }
}
