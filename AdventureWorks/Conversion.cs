using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AdventureWorks
{
    class Conversion
    {
        static void Main(string[] args)
        {
            // ToArray
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var products = entities.Product;

            //    Product[] prodArray = (from product in products
            //                           orderby product.ListPrice descending
            //                           select product).ToArray();

            //    Console.WriteLine("Every price from highest to lowest:");
            //    foreach (Product product in prodArray)
            //    {
            //        Console.WriteLine(product.ListPrice);
            //    }
            //    Console.ReadKey();
            //}

            // ToDictionary
            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var products = entities.Product;

            //    Dictionary<String, Product> scoreRecordsDict = products.
            //        ToDictionary(record => record.Name);

            //    Console.WriteLine("Top Tube's ProductID: {0}",
            //            scoreRecordsDict["Top Tube"].ProductID);

            //    Console.ReadKey();
            //}

            // ToList
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                var products = entities.Product;

                List<Product> query = (from product in products
                                       orderby product.Name
                                       select product).ToList();

                Console.WriteLine("The product list, ordered by product name:");
                foreach (Product product in query)
                {
                    Console.WriteLine(product.Name.ToLower(CultureInfo.InvariantCulture));
                }
                Console.ReadKey();
            }
        }
    }
}
