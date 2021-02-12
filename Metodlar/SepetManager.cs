using Metotlar;
using System;

namespace Metodlar
{
    public class SepetManager
    {
        // naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.ProductName);
        }
    }
}
