using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Common;

namespace AdventureWorks
{
    class ElementOperators
    {
        static void Main(string[] args)
        {
            // FIRST
            string name = "caroline";
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var email = entities.EmailAddress;

                var query = email.First(em => em.EmailAddress1.StartsWith(name));

                Console.WriteLine("An email address starting with 'caroline': {0}", query.EmailAddress1);

                Console.ReadKey();
            }
        }
    }
}
