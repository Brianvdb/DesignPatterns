using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week2
{
    public abstract class ClownDecorator : Clown
    {
        private Clown next;
        public ClownDecorator(Clown next)
        {
            this.next = next;
        }

        public virtual void Actie()
        {
            next.Actie();
        }
    }
}
