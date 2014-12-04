using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week_3_XAML
{
    public abstract class Screen : Observer
    {
        public string Text { get; set; }
    }
}
