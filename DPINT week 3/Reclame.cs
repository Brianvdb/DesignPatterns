using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_week_3
{
    public class Reclame : Subject
    {
        private string reclame;

        public Reclame()
        {
            reclame = "McDonalds";
        }
        public override object getState()
        {
            return reclame;
        }

        public override void setState(object o)
        {
            reclame = (string) o;
        }

    }
}
