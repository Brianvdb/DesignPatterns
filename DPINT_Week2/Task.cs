using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week2
{
    public class Task
    {
        public void Go(bool[] baChoice)
        {
            Clown clown = Factory.GetClown(baChoice);
            clown.Actie();

        }
    }
}
