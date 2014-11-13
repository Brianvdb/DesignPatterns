using DPINT_Week1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week1.Impl
{
    public class WriterFactory
    {
        public static ShowText create(string id) {
            switch (id)
            {
                case "line":
                    return new ShowText(new LineWriter());
                case "wave":
                    return new ShowText(new WaveWriter());
                case "block":
                    return new ShowText(new BlockWriter());
                case "spiral":
                    return new ShowText(new SpiralWriter());
                case "column":
                    return new ShowText(new ColumnWriter());
            }
            return null;
        }
    }
}
