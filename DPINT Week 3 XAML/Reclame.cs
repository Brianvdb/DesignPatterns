using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week_3_XAML
{
    public class Reclame : Subject
    {
        private string reclame;

        public Reclame()
        {
            reclame = "McDonalds";
        }
        public override object GetState()
        {
            return reclame;
        }

        public override void SetState(object o)
        {
            reclame = (string) o;
        }


    }
}
