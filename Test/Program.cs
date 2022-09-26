using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg az első egész számot");
            int elsoszam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg a második egész számot");
            int masodikszam = Convert.ToInt32(Console.ReadLine());

            
            Console.ReadKey();
        }
    }
}
