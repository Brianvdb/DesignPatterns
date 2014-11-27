using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_week_3
{
    public class BigScreen : Screen
    {
        public override void Update(Subject subject)
        {
            string reclame = (string) subject.GetState();
            Console.WriteLine("BIG: " + reclame.ToUpper());
        }
    }
}
