using DPINT_Week1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week1.Impl
{
    public class WriterFactory
    {
        public static IWriter create(string id) {
            var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(t => t.Name == id);
            return (IWriter) Activator.CreateInstance(type);
        }
    }
}
