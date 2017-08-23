using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class ElementOperators2
    {
        static void Main(string[] args)
        {
            // FIRST
            string firstName = "Brooke";
            using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            {
                var persons = context.Person;

                Person query = (from person in persons
                                where person.FirstName == firstName
                                select person).First();
                
                Console.WriteLine("FirstName: " + query.FirstName);
                Console.WriteLine("LastName: " + query.LastName);

                Console.ReadKey();
            }
        }
    }
}
