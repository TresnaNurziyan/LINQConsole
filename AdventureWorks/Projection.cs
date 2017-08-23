using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
    class Projection
    {
        static void Main(string[] args)
        {
            using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            {
                IQueryable<string> productNames = entities.Product
                    .Select(p => p.Name);

                Console.WriteLine("Product Names:");
                foreach (String productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
            }

            //using (AdventureWorks2014Entities entities = new AdventureWorks2014Entities())
            //{
            //    var query = entities.Product
            //        .Select(product => new
            //        {
            //            ProductId = product.ProductID,
            //            ProductName = product.Name
            //        });

            //    Console.WriteLine("Product Info:");
            //    foreach (var productInfo in query)
            //    {
            //        Console.WriteLine("Product Id: {0} Product name: {1} ", productInfo.ProductId, productInfo.ProductName);
            //    }
            //    Console.ReadKey();
            //}


        }
    }
}
