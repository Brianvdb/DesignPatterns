using DPINT_Week1.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriterFactory.create("line").Show();
            Console.WriteLine();
            Console.WriteLine();
            WriterFactory.create("wave").Show();
            Console.WriteLine();
            Console.WriteLine();
            WriterFactory.create("block").Show();
            Console.WriteLine();
            Console.WriteLine();
            WriterFactory.create("spiral").Show();
            Console.WriteLine();
            Console.WriteLine();
            WriterFactory.create("column").Show();
        }
    }
}
