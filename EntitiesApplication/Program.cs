using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ContosoUniversity2Entities entities = new ContosoUniversity2Entities())
            {
                var query = (from p in entities.Person where p.Discriminator == "Student" select p.FirstName).ToList();

                foreach(var queries in query)
                {
                    Console.WriteLine("First Name Student : {0}", queries);
                }
                Console.ReadKey();
            }
        }
    }
}
