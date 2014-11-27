using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPINT_Week2
{
    public class Controller
    {
        private Task task;
        private bool[] baChoice;

        public Controller(bool[] baChoice)
        {
            this.baChoice = baChoice;
            task = new Task();
        }

        public void Go()
        {
            task.Go(baChoice);
        }
    }
}
