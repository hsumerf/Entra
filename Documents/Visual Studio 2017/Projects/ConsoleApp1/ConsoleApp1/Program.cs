using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine("hello"+ dt);
            Console.Read();
        }
    }
}
