using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 10;

            i = j;
            Console.WriteLine("i={0}, j={1}",i,j);

            Customer c = new Customer();
            c.Name = "Kalle";

            Customer d;
            d = c;
            d.Name = "Arne";

            Console.WriteLine("Kunden c's namn: {0}, d's namn: {1}",c.Name,d.Name );

            Console.WriteLine();
            Console.WriteLine("c.ToString() = {0}",c.ToString() );
            Console.WriteLine("c.GetType() = {0}", c.GetType());
            Console.WriteLine("i.ToString() = {0}", i.ToString());
            Console.WriteLine("i.GetType() = {0}", i.GetType());
        }
    }

    class Customer
    {
        public string Name { get; set; }
    }
}
