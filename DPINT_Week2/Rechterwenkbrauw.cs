using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week2
{
    public class Rechterwenkbrauw : ClownDecorator
    {
        public Rechterwenkbrauw(Clown next)
            : base(next)
        {

        }

        public override void Actie()
        {
            base.Actie();

        }
    }
}
