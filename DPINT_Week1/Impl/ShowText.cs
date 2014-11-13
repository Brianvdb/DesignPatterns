using DPINT_Week1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week1.Impl
{
    public class ShowText
    {
        private IWriter writer;

        public ShowText(IWriter writer)
        {
            this.writer = writer;
        }

        public void Show()
        {
            this.writer.Write();
        }
    }
}
