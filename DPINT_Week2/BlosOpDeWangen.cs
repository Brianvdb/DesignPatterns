using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPINT_Week2
{
    public class BlosOpDeWangen: ClownDecorator
    {
        public BlosOpDeWangen(Clown next)
            : base(next)
        {

        }

        public override void Actie()
        {
            base.Actie();
            string message = "BlosOpDeWangen";
            var result = MessageBox.Show(message, message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
