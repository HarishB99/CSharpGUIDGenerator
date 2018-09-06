using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateGUID();
            Console.WriteLine("Please press 'Enter' to exit the program...");
            Console.ReadKey();
        }

        static void GenerateGUID()
        {
            Console.WriteLine("GUID: " + System.Guid.NewGuid().ToString());
        }
    }
}
