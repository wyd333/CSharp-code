using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ret = Tools.Calculator.Mul(10, 20);
            Console.WriteLine(ret);
        }
    }
}
