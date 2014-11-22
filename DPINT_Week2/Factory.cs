using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week2
{
    public class Factory
    {
        public static Clown GetClown(bool[] baChoice)
        {
            Clown result = new ClownKaal();
            if (baChoice[0])
            {
                result = new Linkeroog(result);
            }
            if (baChoice[1])
            {
                result = new Rechteroog(result);
            }
            if (baChoice[2])
            {
                result = new Linkerwenkbrauw(result);
            }
            if (baChoice[3])
            {
                result = new Rechterwenkbrauw(result);
            }
            if (baChoice[4])
            {
                result = new Neus(result);
            }
            if (baChoice[5])
            {
                result = new Mond(result);
            }
            if (baChoice[6])
            {
                result = new RoodOmMond(result);
            }
            if (baChoice[7])
            {
                result = new BlosOpDeWangen(result);
            }
            if (baChoice[8])
            {
                result = new Strik(result);
            }
            if (baChoice[9])
            {
                result = new Hoedje(result);
            }
            if (baChoice[10])
            {
                result = new Haar(result);
            }

            return result;
        }
    }
}
