using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week_3_XAML
{
    public abstract class Observer
    {
        public abstract void Update(Subject subject);
    }
}
