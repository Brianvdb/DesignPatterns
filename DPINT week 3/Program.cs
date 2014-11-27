using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DPINT_week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Reclame reclame = new Reclame();

            BigScreen bigScreen = new BigScreen();
            SmallScreen smallScreen = new SmallScreen();

            reclame.Attach(bigScreen);
            reclame.Attach(smallScreen);

            reclame.Notify();

            Thread.Sleep(2000);

            reclame.SetState("Burger King");
            reclame.Notify();

            Console.Read();
        }
    }
}
