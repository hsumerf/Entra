using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1{

    class Medication
    {
        public int Quantity { get; set; } = 30; // Has default value.
    }
    class Program
    {
        static void Main()
        {
            Medication med = new Medication();
            Console.WriteLine(med.Quantity);
            med.Quantity *= 2;
            Console.WriteLine(med.Quantity);
        }
    }
}