using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week_3_XAML
{
    public class BigScreen : Screen
    {
        public override void Update(Subject subject)
        {
            string reclame = (string) subject.GetState();
            Text = "BIG: " + reclame.ToUpper();
        }
    }
}
