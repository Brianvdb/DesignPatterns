using DPINT_Week1.Impl;
using DPINT_Week1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week1
{
    class Program
    {
        static void Main(string[] args)
        {     
            new ShowText(WriterFactory.create("LineWriter")).Show();
            Console.WriteLine();
            Console.WriteLine();
            new ShowText(WriterFactory.create("WaveWriter")).Show();
            Console.WriteLine();
            Console.WriteLine();
            new ShowText(WriterFactory.create("BlockWriter")).Show();
            Console.WriteLine();
            Console.WriteLine();
            new ShowText(WriterFactory.create("SpiralWriter")).Show();
            Console.WriteLine();
            Console.WriteLine();
            new ShowText(WriterFactory.create("ColumnWriter")).Show();
            Console.ReadKey();
        }
    }
}
