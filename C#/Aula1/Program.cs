using System;

namespace Aula1
{
    internal class Program
    {
        // static double Total(Product product)
        // {
        //     return product.Price * product.Quantity;
        // }
        // SEM ORIENTAÇÃO OBJETO
        // static void UpdatePrice(Product product, double percentage)
        // {
        //     product.Price = product.Price * (1.0 + percentage / 100.0);
        // }

        static void Main(string[] args)
        {
            var p1 = new Product("Laptop", 1000.0, 5);
            var p2 = new Product("Headphones", 200.0, 2);

            // Console.WriteLine(p1.ToString()); Acesso
            // Console.WriteLine(p2.ToString());
            // Console.WriteLine(p1.Name);
            // Console.WriteLine(p2.Name);
            var total1 = p1.Total();
            var total2 = p2.Total();
            Console.WriteLine(total1);
            Console.WriteLine(total2);

            p1.UpdatePrice(20.0);
            Console.WriteLine(p1.Price);

            //Struct
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

        }
    }
}