using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var incoin = int.Parse(Console.ReadLine())* 1168;
            var inyuan =( double.Parse(Console.ReadLine())*0.15)*1.76 ;
            var commission = double.Parse(Console.ReadLine());
            var firstsum = (incoin + inyuan) / 1.95;
             Console.WriteLine(firstsum-(firstsum * commission / 100));

        }
    }
}
