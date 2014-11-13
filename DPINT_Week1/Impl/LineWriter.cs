using DPINT_Week1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week1.Impl
{
    public class LineWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Line Writer implementation!");
        }
    }
}
