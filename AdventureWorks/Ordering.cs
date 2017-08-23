using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Ordering
    {
        // Use Orderby or thenby
        static void Main(string[] args)
        {
            // Using ThenBy
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    IQueryable<Person> sortedPersons = entities.Person
            //        .OrderBy(p => p.LastName)
            //        .ThenBy(p => p.FirstName);

            //    Console.WriteLine("The list of person sorted by last name then by first name:");
            //    foreach (Person sortedPerson in sortedPersons)
            //    {
            //        Console.WriteLine(sortedPerson.LastName + ", " + sortedPerson.FirstName);
            //    }
            //    Console.ReadKey();
            //}

            // Using ThenByDescending
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                IOrderedQueryable<Product> query = entities.Product
                    .OrderBy(product => product.ListPrice)
                    .ThenByDescending(product => product.Name);

                foreach (Product product in query)
                {
                    Console.WriteLine("Product ID: {0} Product Name: {1} List Price {2}",
                        product.ProductID,
                        product.Name,
                        product.ListPrice);
                }
                Console.ReadKey();
            }
        }
    }
}
