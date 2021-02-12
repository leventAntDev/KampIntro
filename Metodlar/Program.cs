using Metotlar;
using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id =1,
                ProductName = "Elma",
                Price = 15,
                Description = "Amasya Elması"
            };

            Product product2 = new Product
            {
                Id =2,
                ProductName = "Karpuz",
                Price = 80,
                Description = "Diyarbakır KArpuzu"
            };

            Product[] product = new Product[] { product1, product2 };
           
            foreach (var Product in product)
            {
                Console.WriteLine("Id           :" + Product.Id + "\n" + 
                                  "Pruduct Name :" + Product.ProductName +"\n" +
                                  "Price        :" + Product.Price +".TL"+ "\n" +
                                  "Description  :" + Product.Description + "\n"+
                                  "--------------------------------------------"
               );
            };

            Console.WriteLine("------------------------Metotlar----------------------------------");
            // instance - Örnek
            // encapsulation - Kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

        }
    }
}
