using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> proList = new List<string>();
            Console.WriteLine("Order Value");
            // this part we can use dependenct injection 
            ProductService productService = new ProductService();
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Please provide any of the following value  :A,B,C or D");
                string type = Console.ReadLine();
                proList.Add(type);
            }

            int totalPrice = productService.GetTotalPrice(proList);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }

}
